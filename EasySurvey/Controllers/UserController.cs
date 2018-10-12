using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasySurvey.Models;

namespace EasySurvey.Controllers
{
    public class UserController
    {
        private DatabaseEntity DatabaseModel = new DatabaseEntity();

        public List<UserModelDataTransferObject> GetUsers()
        {
            List<UserModelDataTransferObject> Users = new List<UserModelDataTransferObject>();

            var list = from user in DatabaseModel.User
                       join userRole in DatabaseModel.UserRole on user.UserID equals userRole.UserID
                       select new
                       {
                           user.UserID,
                           user.UserName,
                           user.UserPassword,
                           userRole.RoleID
                       };

            RoleController roleController = new RoleController();

            foreach (var elem in list)
            {
                Users.Add(new UserModelDataTransferObject()
                {
                    UserID = elem.UserID,
                    UserName = elem.UserName,
                    UserPassword = elem.UserPassword,
                    RoleID = elem.RoleID,
                    RoleName = roleController.GetRoleName(elem.RoleID)
                });
            }

            return Users;
        }

        public UserModelDataTransferObject GetUserByID(long ID)
        {
            var user = from usr in DatabaseModel.User
                       join usrRole in DatabaseModel.UserRole on usr.UserID equals usrRole.UserID
                       where usr.UserID == ID
                       select new
                       {
                           usr.UserID,
                           usr.UserName,
                           usr.UserPassword,
                           usrRole.RoleID
                       };

            var firstUser = user.First();

            RoleController roleController = new RoleController();

            return new UserModelDataTransferObject()
            {
                UserID = firstUser.UserID,
                UserName = firstUser.UserName,
                UserPassword = firstUser.UserPassword,
                RoleID = firstUser.RoleID,
                RoleName = roleController.GetRoleName(firstUser.RoleID)
            };
        }

        public IEnumerable<UserModelDataTransferObject> Search(List<UserModelDataTransferObject> all_users, string search_in, bool caseSensitive = false, int limit = 5)
        {
            IEnumerable<UserModelDataTransferObject> result;
            if (!caseSensitive)
                result = (
                    from user in all_users
                    where user.UserName.ToLower().Contains(search_in.ToLower())
                    select user
                    ).Take(limit);
            else
                result = (
                    from user in all_users
                    where user.UserName.Contains(search_in)
                    select user
                    ).Take(limit);
            return result;
        }

        public IEnumerable<UserModelDataTransferObject> Search(string search_in, bool caseSensitive = false, int limit = 5)
        {
            IEnumerable<UserModelDataTransferObject> result;
            if (!caseSensitive)
                result = (
                    from user in this.GetUsers()
                    where user.UserName.ToLower().Contains(search_in.ToLower())
                    select user
                    ).Take(limit);
            else
                result = (
                    from user in this.GetUsers()
                    where user.UserName.Contains(search_in)
                    select user
                    ).Take(limit);
            return result;
        }

        public User Exists(string Username)
        {
            List<User> user = (from usr in DatabaseModel.User
                               where usr.UserName.ToLower() == Username.ToLower()
                               select usr).ToList();

            if (user.Count == 1)
                return user.First();

            return null;
        }

        public User Login(string Username, string Password = null)
        {
            if (Password != null)
            {
                Password = SHA256.Hash(Password);
            }

            IEnumerable<User> user = from usr in DatabaseModel.User
                                     where usr.UserName == Username && usr.UserPassword == Password
                                     select usr;
            if (user.Count() == 1)
            {
                return user.First();
            }
            else
            {
                return null;
            }
        }

    }
}
