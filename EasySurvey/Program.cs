using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EasySurvey
{
    static class Program
    {
        public static MaterialForm frm_Login;
        public static MaterialForm frm_Register;
        public static MaterialForm frm_MainForm;
        public static MaterialForm frm_ConductSurvey;
        public static MaterialForm frm_Settings;

        public static long InitDBCount1 = 0;
        public static long InitDBCount2 = 0;
        public static long DestructorDBCount1 = 0;
        public static long DestructorDBCount2 = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frm_Login = new Login();

            Application.Run(frm_Login);
        }
    }
}
