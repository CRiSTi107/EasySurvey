using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey
{
    public static class MaterialMessageBox
    {
        public enum MessageBoxButtons : int
        {
            OK = 0,
            //OKCancel = 1,
            //AbortRetryIgnore = 2,
            YesNoCancel = 3,
            YesNo = 4
            //RetryCancel = 5
        }

        public enum MessageBoxResult : int
        {
            None = 0,
            OK = 1,
            Cancel = 2,
            Abort = 3,
            Retry = 4,
            //Ignore = 5,
            Yes = 6,
            No = 7
        }

        public enum MessageBoxIcon : int
        {
            None = 0,
            Error = 16,
            Question = 32,
            Warning = 48,
            Information = 64
        }

        public static MaterialMessageBox.MessageBoxResult _Result = MaterialMessageBox.MessageBoxResult.None;

        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MsgBox frm_MessageBox = new MsgBox(text, caption, buttons, icon);

            frm_MessageBox.ShowDialog();

            return _Result;

        }

    }
}
