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
    }
}
