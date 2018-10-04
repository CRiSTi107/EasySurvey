using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey
{
    public class Version
    {
        /// <summary>
        /// Fills from String value.
        /// </summary>
        /// <param name="VersionString">[major].[minor].[release].[build]</param>
        public Version(string VersionString)
        {
            string[] version = VersionString.Split('.');

            this.Major = Convert.ToInt32(version[0]);
            this.Minor = Convert.ToInt32(version[1]);
            this.Release = Convert.ToInt32(version[2]);
            this.Build = Convert.ToInt32(version[3]);
        }

        /// <summary>
        /// Architecture Change
        /// </summary>
        public int Major { get; private set; }

        /// <summary>
        /// New Features
        /// </summary>
        public int Minor { get; private set; }

        /// <summary>
        /// Maintenance
        /// </summary>
        public int Release { get; private set; }

        /// <summary>
        /// Bug Fixes
        /// </summary>
        public int Build { get; private set; }

        public override string ToString()
        {
            return Major + "." + Minor + "." + Release + "." + Build;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator !=(Version lhs, Version rhs)
        {
            bool status = false;
            if (lhs.ToString() != rhs.ToString())
            {
                status = true;
            }
            return status;
        }

        public static bool operator ==(Version lhs, Version rhs)
        {
            bool status = false;
            if (lhs.ToString() == rhs.ToString())
            {
                status = true;
            }
            return status;
        }

        public static bool operator <(Version lhs, Version rhs)
        {
            bool status = false;

            if (lhs.Major < rhs.Major)
                status = true;
            else if (lhs.Minor < rhs.Minor)
                status = true;
            else if (lhs.Release < rhs.Release)
                status = true;
            else if (lhs.Build < rhs.Build)
                status = true;

            return status;
        }

        public static bool operator >(Version lhs, Version rhs)
        {
            bool status = false;

            if (lhs.Major > rhs.Major)
                status = true;
            else if (lhs.Minor > rhs.Minor)
                status = true;
            else if (lhs.Release > rhs.Release)
                status = true;
            else if (lhs.Build > rhs.Build)
                status = true;

            return status;
        }

        public static bool operator <=(Version lhs, Version rhs)
        {
            bool status = false;

            if (lhs.Major <= rhs.Major)
                status = true;
            else if (lhs.Minor <= rhs.Minor)
                status = true;
            else if (lhs.Release <= rhs.Release)
                status = true;
            else if (lhs.Build <= rhs.Build)
                status = true;

            return status;
        }

        public static bool operator >=(Version lhs, Version rhs)
        {
            bool status = false;

            if (lhs.Major >= rhs.Major)
                status = true;
            else if (lhs.Minor >= rhs.Minor)
                status = true;
            else if (lhs.Release >= rhs.Release)
                status = true;
            else if (lhs.Build >= rhs.Build)
                status = true;

            return status;
        }
    }
}
