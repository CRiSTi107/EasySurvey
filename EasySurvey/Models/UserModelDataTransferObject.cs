using EasySurvey.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Models
{
    public class UserModelDataTransferObject
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public long RoleID { get; set; }
        public string RoleName { get; set; }

        public bool IsAdministrator()
        {
            long AdminRoleID;
            using (RoleController roleController = new RoleController())
                AdminRoleID = roleController.GetRoleID("Admin");
            return (this.RoleID == AdminRoleID) ? true : false;
        }
    }
}
