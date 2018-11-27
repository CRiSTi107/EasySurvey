using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey
{
    public static class MaterialMessageInput
    {
        public enum MessageBoxButtonsInput : int
        {
            //OK = 0,
            OKCancel = 1,
            //AbortRetryIgnore = 2,
            //YesNoCancel = 3,
            //YesNo = 4
            //RetryCancel = 5
        }

        public enum MessageBoxResultInput : int
        {
            None = 0,
            OK = 1,
            Cancel = 2
            //Abort = 3,
            //Retry = 4,
            //Ignore = 5,
            //Yes = 6,
            //No = 7
        }

        public static MessageBoxResultInput _Result = MessageBoxResultInput.None;
        public static string Answer = String.Empty;

        public static MessageBoxResultInput Show(string text, string caption, MessageBoxButtonsInput buttons, string defaultValue = "")
        {
            _Result = MessageBoxResultInput.None;

            MsgInput frm_MessageBoxInput = new MsgInput(text, caption, buttons, defaultValue);

            frm_MessageBoxInput.ShowDialog();

            return _Result;
        }

    }
}
