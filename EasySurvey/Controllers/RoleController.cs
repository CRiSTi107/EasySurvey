using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class RoleController
    {
        private DatabaseEntity DatabaseModel = new DatabaseEntity();

        public string GetRoleName(long RoleID)
        {
            return (from role in DatabaseModel.Role where role.RoleID == RoleID select role.RoleName).First();
        }
    }
}
