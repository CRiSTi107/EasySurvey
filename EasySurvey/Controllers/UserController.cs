using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasySurvey.Models;

namespace EasySurvey.Controllers
{
    public class UserController : BaseController
    {
        public UserController()
            : base()
        {
        }

        public UserController(Database DBEntity)
            : base(DBEntity)
        {
        }

        public User Get(long UserID)
        {
            return (from user in DatabaseModel.User where user.UserID == UserID select user).First();
        }

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

            using (RoleController roleController = new RoleController(DatabaseModel))
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

        public List<UserModelDataTransferObject> GetUsersByRoleID(long RoleID)
        {
            List<UserModelDataTransferObject> Users = new List<UserModelDataTransferObject>();

            var list = from user in DatabaseModel.User
                       join userRole in DatabaseModel.UserRole on user.UserID equals userRole.UserID
                       where userRole.RoleID == RoleID
                       select new
                       {
                           user.UserID,
                           user.UserName,
                           user.UserPassword,
                           userRole.RoleID
                       };

            using (RoleController roleController = new RoleController(DatabaseModel))
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

            var firstUser = user.FirstOrDefault();

            using (RoleController roleController = new RoleController(DatabaseModel))
                return new UserModelDataTransferObject()
                {
                    UserID = firstUser.UserID,
                    UserName = firstUser.UserName,
                    UserPassword = firstUser.UserPassword,
                    RoleID = firstUser.RoleID,
                    RoleName = roleController.GetRoleName(firstUser.RoleID)
                };
        }

        public UserModelDataTransferObject GetUserByName(string Username)
        {
            var user = from usr in DatabaseModel.User
                       join usrRole in DatabaseModel.UserRole on usr.UserID equals usrRole.UserID
                       where usr.UserName == Username
                       select new
                       {
                           usr.UserID,
                           usr.UserName,
                           usr.UserPassword,
                           usrRole.RoleID
                       };
            var firstUser = user.FirstOrDefault();

            using (RoleController roleController = new RoleController(DatabaseModel))
                return new UserModelDataTransferObject()
                {
                    UserID = firstUser.UserID,
                    UserName = firstUser.UserName,
                    UserPassword = firstUser.UserPassword,
                    RoleID = firstUser.RoleID,
                    RoleName = roleController.GetRoleName(firstUser.RoleID)
                };
        }

        public IEnumerable<UserModelDataTransferObject> Search(List<UserModelDataTransferObject> all_users, string search_in, bool caseSensitive = false, int limit = 4)
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

        public IEnumerable<UserModelDataTransferObject> Search(string search_in, bool caseSensitive = false, int limit = 4)
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

        public bool AddUser(string Username)
        {
            if (Exists(Username) != null)
                return false;

            User user = DatabaseModel.User.Add(new User() { UserName = Username, UserPassword = null });
            DatabaseModel.SaveChanges();

            using (UserRoleController userRoleController = new UserRoleController(DatabaseModel))
            using (RoleController roleController = new RoleController(DatabaseModel))
                if (roleController.GetUserRole(user.UserID) == null)
                {
                    userRoleController.SetUserRole(user.UserID, roleController.GetRoleID("User"));
                }

            return true;
        }

        /// <summary>
        /// Update User's Password
        /// </summary>
        /// <param name="UserID">User ID that password will be changed.</param>
        /// <param name="NewPassword">New hashed password.</param>
        public void UpdatePassword(long UserID, string NewPassword)
        {
            DatabaseModel.User.Where(user => user.UserID == UserID).ToList().ForEach(user => user.UserPassword = NewPassword);
            DatabaseModel.SaveChanges();
        }

        public void Delete(long UserID)
        {
            User UserToDelete = Get(UserID);
            Delete(UserToDelete);
        }

        public void Delete(User UserToDelete)
        {
            long UserID = UserToDelete.UserID;

            //Delete everything that is linked to this UserID: UserRole, Reports and ReportDefinitions
            using (UserRoleController userRoleController = new UserRoleController(DatabaseModel))
            using (ResultController resultController = new ResultController(DatabaseModel))
            {
                userRoleController.Delete(UserID);
                resultController.DeleteAll(UserID);
            }

            DatabaseModel.User.Remove(UserToDelete);
            DatabaseModel.SaveChanges();
        }
    }
}
