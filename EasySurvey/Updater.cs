using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using System.Drawing;

namespace EasySurvey
{
    public class Updater
    {
        private const string VERSION_URL_GIT = @"https://raw.githubusercontent.com/CRiSTi107/EasySurvey/master/VERSION";
        private Version lastVersion;
        private bool AutoStartCheck = true;
        private bool DownloadingNewUpdate = false;
        private WebClient webClient = new WebClient();
        // private NotifyIcon notifyIcon;
        public Updater()
        {
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;

            // Icon AppIcon = Properties.Resources.Survey;

            // notifyIcon = new NotifyIcon();
            // notifyIcon.Icon = new Icon(AppIcon, new Size(AppIcon.Width, AppIcon.Height));
            // notifyIcon.BalloonTipTitle = "Easy Survey - Updater";
            // notifyIcon.BalloonTipText = "Update x % Downloaded";
            // notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
        }

        public void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

        }

        public void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadProgressChanged(sender, e);
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DownloadFileCompleted(sender, e);
        }

        public void CheckForUpdates(bool autoStartCheck = true)
        {
            AutoStartCheck = autoStartCheck;
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
                lastVersion = new Version(webClient.DownloadString(VERSION_URL_GIT));
                Version currentVersion = GetCurrentVersion();

                if (lastVersion > currentVersion)
                {
                    if (MessageBox.Show("A new update is avabile - " + lastVersion.ToString() + Environment.NewLine + "Would you like to download it now?", "EasySurvey - " + currentVersion, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        // Download from an URL or open easysurvey.github.io page.
                    }
                }
                else if (!AutoStartCheck)
                {
                    MessageBox.Show("Software is up to date!", "EasySurvey - Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (WebException we)
            {
                // throw we;
            }
        }
    }
}
