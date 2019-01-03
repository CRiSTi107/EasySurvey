using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class UserRoleController
    {
        private Database DatabaseModel;

        public UserRoleController()
        {
            DatabaseModel = new Database();
        }

        public UserRoleController(Database DBEntity)
        {
            DatabaseModel = DBEntity;
        }

        public UserRole Get(long UserID)
        {
            return (from userRole in DatabaseModel.UserRole where userRole.UserID == UserID select userRole).First();
        }

        public void SetUserRole(long UserID, long RoleID)
        {
            List<UserRole> userRole = (from usrRole in DatabaseModel.UserRole where usrRole.UserID == UserID select usrRole).ToList();

            if (userRole.Count == 0)
                DatabaseModel.UserRole.Add(new UserRole() { UserID = UserID, RoleID = RoleID });
            else
                DatabaseModel.UserRole.Where(usrRole => usrRole.UserID == UserID).First().RoleID = RoleID;

            DatabaseModel.SaveChanges();
        }

        public void Delete(long UserID)
        {
            UserRole UserRoleToDelete = Get(UserID);
            Delete(UserRoleToDelete);
        }

        public void Delete(UserRole UserRoleToDelete)
        {
            DatabaseModel.UserRole.Remove(UserRoleToDelete);
            DatabaseModel.SaveChanges();
        }

    }
}
