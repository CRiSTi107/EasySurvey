using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class RoleController : BaseController
    {
        public RoleController()
            : base()
        {
        }

        public RoleController(Database DBEntity)
            : base(DBEntity)
        {
        }

        public string GetRoleName(long RoleID)
        {
            return (from roleName in DatabaseModel.Role where roleName.RoleID == RoleID select roleName.RoleName).First();
        }

        public long GetRoleID(string RoleName)
        {
            return (from roleID in DatabaseModel.Role where roleID.RoleName.ToLower() == RoleName.ToLower() select roleID.RoleID).First();
        }

        public Role GetUserRole(long UserID)
        {
            List<UserRole> userRole = (from usrRole in DatabaseModel.UserRole where usrRole.UserID == UserID select usrRole).ToList();

            if (userRole.Count == 0)
                return null;

            return (from role in DatabaseModel.Role join usrRole in DatabaseModel.UserRole on role.RoleID equals usrRole.RoleID select role).First();
        }
    }
}
