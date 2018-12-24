using EasySurvey.Controllers;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasySurvey
{
    public partial class MsgInput : MaterialForm
    {
        internal readonly MaterialSkinManager __materialSkinManager;

        private bool AddSurveyMode = false;
        private bool AddQuestionMode = false;
        private bool AddAttitudeMode = false;
        private bool EditQuestionMode = false;

        private string DefaultInputValue = String.Empty;

        public MsgInput(string text, string caption, MaterialMessageInput.MessageBoxButtonsInput buttons, string defaultValue = "")
        {
            InitializeComponent();

            __materialSkinManager = MaterialSkinManager.Instance;
            __materialSkinManager.AddFormToManage(this);
            __materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            __materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            base.Text = caption;
            lbl_Text.Text = text;

            txt_Answer.Text = defaultValue;
            DefaultInputValue = defaultValue;

            switch (buttons)
            {
                case MaterialMessageInput.MessageBoxButtonsInput.OKCancel: // For this we need only one type.
                    btn_OK.Visible = true;
                    btn_OK.Enabled = true;
                    btn_Cancel.Visible = true;
                    btn_Cancel.Enabled = true;
                    break;

                default:
                    break;
            }

            Divider_Menu.AutoSize = false;
        }

        public MsgInput(string text, string caption, MaterialMessageInput.MessageBoxButtonsInput buttons, string defaultValue,
                        bool addSurvey = false, bool addQuestion = false, bool addAttitude = false, bool editQuestion = false)
            : this(text, caption, buttons, defaultValue)
        {
            AddSurveyMode = addSurvey;
            AddQuestionMode = addQuestion;
            AddAttitudeMode = addAttitude;
            EditQuestionMode = editQuestion;
        }

        #region Shade the form
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion

        private void MsgInput_Load(object sender, EventArgs e)
        {
            Divider_Menu.AutoSize = false;
            Divider_Menu.Location = new Point(-12, 188);
            Divider_Menu.Size = new Size(613, 10);
        }

        private bool AnswerIsEmpty = true;
        private string Status = String.Empty;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            AnswerIsEmpty = false;

            if (txt_Answer.Text == null || txt_Answer.Text == "" || txt_Answer.Text == String.Empty || txt_Answer.Text.Trim() == String.Empty)
            {
                AnswerIsEmpty = true;
                SetStatus("Text cannot be empty");
                return;
            }

            string InputText = txt_Answer.Text;

            if (!AnswerIsEmpty)
            {
                SurveyController surveyController = new SurveyController();
                QuestionController questionController = new QuestionController();
                AttitudeController attitudeController = new AttitudeController();

                bool isOK = false;

                if (AddSurveyMode)
                {
                    if (surveyController.Exists(InputText))
                    {
                        SetStatus("A Survey with the same name already exists");
                        return;
                    }
                    else isOK = true;
                }
                else if (AddQuestionMode)
                {
                    if (questionController.Exists(InputText))
                    {
                        SetStatus("A Question with the same name already exists");
                        return;
                    }
                    else isOK = true;
                }
                else if (AddAttitudeMode)
                {
                    if (attitudeController.Exists(InputText))
                    {
                        SetStatus("An Attitude with the same name already exists");
                        return;
                    }
                    else isOK = true;
                }
                else if (EditQuestionMode)
                {
                    if (DefaultInputValue != InputText)
                    {
                        if (questionController.Exists(InputText))
                        {
                            SetStatus("A Question with the same name already exists");
                            return;
                        }
                        else isOK = true;
                    }
                    else isOK = true;
                }

                if (isOK || (!AddSurveyMode && !AddQuestionMode && !AddAttitudeMode && !EditQuestionMode))
                {
                    MaterialMessageInput.Answer = txt_Answer.Text;
                    MaterialMessageInput._Result = MaterialMessageInput.MessageBoxResultInput.OK;
                    base.Close();
                }

            }

        }

        private void SetStatus(string status, bool isError = true)
        {
            lbl_Status.Text = status;
            lbl_Status.ForeColor = isError ? Color.Red : Color.Green;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MaterialMessageInput._Result = MaterialMessageInput.MessageBoxResultInput.Cancel;
            base.Close();
        }

        private void txt_Answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_OK.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                btn_Cancel.PerformClick();
        }

        private void txt_Answer_TextChanged(object sender, EventArgs e)
        {
            lbl_Status.Text = String.Empty;
        }
    }
}
