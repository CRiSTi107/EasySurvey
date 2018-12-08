using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace EasySurvey
{
    public class Updater
    {
        private const string VERSION_URL_GIT = @"https://raw.githubusercontent.com/CRiSTi107/EasySurvey/master/VERSION";
        private Version lastVersion;

        public void CheckForUpdates()
        {
            try
            {
                Task task = new Task(new Action(Update));
                task.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Version GetCurrentVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return new Version(AssemblyName.GetAssemblyName(assembly.Location).Version.ToString());
        }


        private void Update()
        {
            try
            {
                WebClient wc = new WebClient();

                lastVersion = new Version(wc.DownloadString(VERSION_URL_GIT));
                Version currentVersion = GetCurrentVersion();

                if (lastVersion > currentVersion)
                    if (MessageBox.Show("A new update is avabile - " + lastVersion.ToString() + Environment.NewLine + "Would you like to download it now?", "EasySurvey - " + currentVersion, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        // Download from an URL or open easysurvey.github.io page.
                    }
            }
            catch (WebException we)
            {
                // throw we;
            }
        }
    }
}
