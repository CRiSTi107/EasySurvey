﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey
{
    public static class MaterialMessageComboBox
    {
        public enum MessageBoxButtons : int
        {
            //OK = 0,
            OKCancel = 1,
            //AbortRetryIgnore = 2,
            //YesNoCancel = 3,
            //YesNo = 4
            //RetryCancel = 5
        }

        public enum MessageBoxResult : int
        {
            None = 0,
            OK = 1,
            Cancel = 2,
            //Abort = 3,
            //Retry = 4,
            //Ignore = 5,
            //Yes = 6,
            //No = 7
        }

        public static MessageBoxResult _Result = MessageBoxResult.None;
        public static string Answer1 = String.Empty;
        public static string Answer2 = String.Empty;

        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            _Result = MessageBoxResult.None;

            MsgComboBox frm_MessageBox = new MsgComboBox(text, caption, buttons);

            frm_MessageBox.ShowDialog();

            return _Result;

        }

    }
}