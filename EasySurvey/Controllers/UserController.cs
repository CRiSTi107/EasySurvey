using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasySurvey.Models;
using EasySurvey.Controllers;

namespace EasySurvey.Controller
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

        public bool Login(string Username, string Password = null)
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
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
