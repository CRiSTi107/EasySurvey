﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasySurvey.Models;
using EasySurvey.Controllers;

namespace EasySurvey
{
    public partial class MsgComboBox : MaterialForm
    {
        internal readonly MaterialSkinManager __materialSkinManager;

        public MsgComboBox(string text, string caption, MaterialMessageComboBox.MessageBoxButtons buttons)
        {
            InitializeComponent();

            __materialSkinManager = MaterialSkinManager.Instance;
            __materialSkinManager.AddFormToManage(this);
            __materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            __materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            base.Text = caption;
            lbl_Text.Text = text;

            Divider_Menu.AutoSize = false;
            Divider_Menu.Location = new Point(-12, 188);
            Divider_Menu.Size = new Size(568, 10);
            Divider_Menu.Enabled = false;

            switch (buttons)
            {
                case MaterialMessageComboBox.MessageBoxButtons.OKCancel:
                    btn_OK.Visible = true;
                    btn_OK.Enabled = true;
                    btn_Cancel.Visible = true;
                    btn_Cancel.Enabled = true;
                    break;
                default:
                    break;
            }

            MaterialMessageComboBox._Result = MaterialMessageComboBox.MessageBoxResult.None;
        }

        public MsgComboBox(string text, string caption, MaterialMessageComboBox.MessageBoxButtons buttons, long AttitudeID)
            : this(text, caption, buttons)
        {
            this.AttitudeID = AttitudeID;
        }

        private long AttitudeID = -1;

        private List<Survey> Surveys = new List<Survey>();
        private List<Question> Questions = new List<Question>();
        private List<Question> QuestionsOfSurvey = new List<Question>();

        private bool IsValidatedAnswer1 = false;
        private bool IsValidatedAnswer2 = false;

        private void MsgComboBox_Load(object sender, EventArgs e)
        {
            SurveyController surveyController = new SurveyController();
            Surveys = surveyController.GetAll();

            QuestionController questionController = new QuestionController();
            Questions = questionController.GetAll();

            //AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();

            //Surveys.ForEach(item => autoCompleteSource.Add(item.SurveyName));

            //cmb_Answer1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmb_Answer1.AutoCompleteCustomSource = autoCompleteSource;

            foreach (Survey survey in Surveys)
                cmb_Answer1.Items.Add(survey.SurveyName);

            //cmb_Answer2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (IsValidatedAnswer1 && IsValidatedAnswer2)
            {
                long SurveyID = MaterialMessageComboBox.Answer1;
                long QuestionID = MaterialMessageComboBox.Answer2;
                AttitudeDefinitionController attitudeDefinitionController = new AttitudeDefinitionController();
                if (attitudeDefinitionController.Exists(AttitudeID, QuestionID))
                {
                    SetStatus("This Question already exists in this Attitude Definition.");
                }
                else
                {
                    MaterialMessageComboBox._Result = MaterialMessageComboBox.MessageBoxResult.OK;
                    base.Close();
                }
            }
            else
                SetStatus("Please selected the Survey and Question properly.");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MaterialMessageComboBox._Result = MaterialMessageComboBox.MessageBoxResult.Cancel;
            base.Close();
        }

        private void cmb_Answer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedSurveyName = cmb_Answer1.Text;
            Survey SelectedSurvey = Surveys.Where(item => item.SurveyName == SelectedSurveyName).First();

            if (SelectedSurvey != null)
            {
                long SurveyID = SelectedSurvey.SurveyID;

                QuestionController questionController = new QuestionController();
                QuestionsOfSurvey = questionController.GetQuestionsForSurvey(SurveyID);

                cmb_Answer2.Items.Clear();

                foreach (Question question in QuestionsOfSurvey)
                    cmb_Answer2.Items.Add(question.Question1);

                MaterialMessageComboBox.Answer1 = SurveyID;
                IsValidatedAnswer1 = true;
            }
            else
            {
                SetStatus("Please choose from the existing Survey list.");
                cmb_Answer2.Items.Clear();
                IsValidatedAnswer1 = false;
            }

        }

        private void cmb_Answer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedQuestionName = cmb_Answer2.Text;
            Question SelectedQuestion = QuestionsOfSurvey.Where(item => item.Question1 == SelectedQuestionName).First();

            if (SelectedQuestion != null)
            {
                long QuestionID = SelectedQuestion.QuestionID;

                MaterialMessageComboBox.Answer2 = QuestionID;
                IsValidatedAnswer2 = true;
            }
            else
            {
                SetStatus("Please choose from the existing Question list.");
                IsValidatedAnswer2 = false;
            }


        }

        private void SetStatus(string text, bool error = true)
        {
            lbl_Status.Text = text;
            lbl_Status.ForeColor = error ? Color.Red : Color.Green;
        }
    }
}
