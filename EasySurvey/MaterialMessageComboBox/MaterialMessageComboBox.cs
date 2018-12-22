using System;
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
        public static long Answer1 = -1;
        public static long Answer2 = -1;

        //Add
        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons, long AttitudeID)
        {
            _Result = MessageBoxResult.None;
            MsgComboBox frm_MessageBox = new MsgComboBox(text, caption, buttons, AttitudeID);
            frm_MessageBox.ShowDialog();
            return _Result;
        }

        //Edit
        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons, long AttitudeID, long SurveyID, long QuestionID)
        {
            _Result = MessageBoxResult.None;
            MsgComboBox frm_MessageBox = new MsgComboBox(text, caption, buttons, AttitudeID, SurveyID, QuestionID);
            frm_MessageBox.ShowDialog();
            return _Result;
        }

    }
}
