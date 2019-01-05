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

        public static bool operator ==(UserModelDataTransferObject lhs, UserModelDataTransferObject rhs)
        {
            bool status = false;
            if (lhs.GetHashCode() == rhs.GetHashCode())
                status = true;
            return status;
        }

        public static bool operator !=(UserModelDataTransferObject lhs, UserModelDataTransferObject rhs)
        {
            bool status = false;
            if (lhs.GetHashCode() != rhs.GetHashCode())
                status = true;
            return status;
        }

        public override bool Equals(object obj)
        {
            return (this == (UserModelDataTransferObject)obj);
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ UserID.GetHashCode();
                hash = (hash * 16777619) ^ UserName.GetHashCode();
                // We dont care about password, for now
                // hash = (hash * 16777619) ^ UserPassword.GetHashCode();
                hash = (hash * 16777619) ^ RoleID.GetHashCode();
                hash = (hash * 16777619) ^ RoleName.GetHashCode();
                return hash;
            }
        }
    }
}
