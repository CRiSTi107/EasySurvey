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

    }
}
