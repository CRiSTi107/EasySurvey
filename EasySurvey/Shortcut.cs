using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IWshRuntimeLibrary;
using System.Reflection;
using System.IO;

namespace EasySurvey
{
    public static class Shortcut
    {
        public static void CreateDesktopShortcut()
        {
            string DesktopShortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Easy Survey.lnk";
            string TargetAppPath = Assembly.GetExecutingAssembly().Location;
            string WorkingDirectoryApp = Path.GetDirectoryName(TargetAppPath);

            WshShell wsh = new WshShell();
            IWshShortcut shortcut = wsh.CreateShortcut(DesktopShortcutPath) as IWshShortcut;
            shortcut.Arguments = "";
            shortcut.TargetPath = TargetAppPath;
            // not sure about what this is for
            shortcut.WindowStyle = 1;
            shortcut.Description = "Easy Survey Software";
            shortcut.WorkingDirectory = WorkingDirectoryApp;
            shortcut.IconLocation = TargetAppPath;
            shortcut.Save();
        }
    }
}
