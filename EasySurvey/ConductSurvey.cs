using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using EasySurvey.Models;
using EasySurvey.Controllers;

namespace EasySurvey
{
    public partial class ConductSurvey : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private UserModelDataTransferObject LoggedUser;
        private long SurveyID;

        public ConductSurvey(UserModelDataTransferObject LoggedUser, long SurveyID)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            this.LoggedUser = LoggedUser;
            this.SurveyID = SurveyID;

            AnswerButtons = new List<MaterialRadioButton>();
            AnswerButtons.Add(btn_Answer_0);
            AnswerButtons.Add(btn_Answer_1);
            AnswerButtons.Add(btn_Answer_2);
            AnswerButtons.Add(btn_Answer_3);
            AnswerButtons.Add(btn_Answer_4);
            AnswerButtons.Add(btn_Answer_5);

            panel_ConductSurvey.Enabled = panel_Finish.Enabled = false;
            panel_ConductSurvey.Visible = panel_Finish.Visible = false;

            lbl_Welcome_SurveyName.Font = lbl_SurveyName.Font = SurveyNameFont;
            btn_Welcome_Start.AutoSize = btn_Success_Exit.AutoSize = false;
            btn_Welcome_Start.Size = btn_Success_Exit.Size = new Size(190, 36);
            SetHorizontalMiddle(btn_Welcome_Start); SetHorizontalMiddle(btn_Success_Exit);

            btn_Next.AutoSize = btn_Back.AutoSize = btn_Finish.AutoSize = false;
            btn_Back.Size = btn_Next.Size = btn_Finish.Size = new Size(195, 36);

            materialDivider_Menu.AutoSize = false;
            materialDivider_Menu.Location = new Point(0, 429);
            materialDivider_Menu.Size = new Size(927, 10);
        }

        #region Welcome Panel

        private Font SurveyNameFont = (new FontConverter().ConvertFromString("Roboto Medium; 21,75pt; style=Bold")) as Font;

        private void lbl_SurveyName_FontChanged(object sender, EventArgs e)
        {
            lbl_Welcome_SurveyName.Font = SurveyNameFont;
            lbl_SurveyName.Font = SurveyNameFont;
            lbl_Finish.Font = SurveyNameFont;
        }

        private void SetHorizontalMiddle(MaterialRaisedButton control)
        {
            control.Location = new Point(base.Width / 2 - control.Size.Width / 2, control.Location.Y);
        }

        private bool RandomizeQuestions = false;

        private void chb_Welcome_RandomizeQuestions_CheckedChanged(object sender, EventArgs e)
        {
            RandomizeQuestions = (chb_Welcome_RandomizeQuestions.CheckState == CheckState.Checked) ? true : false;
        }

        #endregion

        private List<MaterialRadioButton> AnswerButtons;

        private Survey CurrentSurvey;
        private List<Question> Questions;
        private Result FinalResult;
        private List<ResultDefinition> Results;

        private void ConductSurvey_Load(object sender, EventArgs e)
        {
            SurveyController surveyController = new SurveyController();
            CurrentSurvey = surveyController.Get(SurveyID);

            QuestionController questionController = new QuestionController();
            Questions = questionController.GetQuestionsForSurvey(SurveyID);

            lbl_Welcome_SurveyName.Text = lbl_SurveyName.Text = CurrentSurvey.SurveyName;
            lbl_Welcome_QuestionCount.Text = lbl_QuestionCount.Text = Questions.Count + " Questions";
            lbl_TotalQuestions.Text = "/ " + Questions.Count;
            txt_CurrentQuestion.Text = "1";
        }

        private Random rand = new Random();

        public void Shuffle<T>(List<T> list) where T : Question
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void btn_Welcome_Start_Click(object sender, EventArgs e)
        {
            panel_Welcome.Enabled = false;
            panel_Welcome.Visible = false;

            panel_ConductSurvey.Enabled = true;
            panel_ConductSurvey.Visible = true;

            if (RandomizeQuestions)
                Shuffle(Questions);

            Results = new List<ResultDefinition>();
            foreach (Question question in Questions)
            {
                Results.Add(new ResultDefinition() { QuestionID = question.QuestionID, ResultAnswer = -1 });
            }

            FinalResult = new Result();

            FinalResult.UserID = LoggedUser.UserID;
            FinalResult.SurveyID = SurveyID;

            FillQuestion(CurrentQuestionIndex);
        }

        private void ConductSurvey_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frm_MainForm.Location = base.Location;
            Program.frm_MainForm.Size = base.Size;
            Program.frm_MainForm.Show();
        }


        private void Uncheck<T>(List<T> list) where T : MaterialRadioButton
        {
            foreach (T RadioButton in list)
                RadioButton.Checked = false;
        }

        private void Check<T>(List<T> list, int value) where T : MaterialRadioButton
        {
            //Uncheck(list);

            foreach (T RadioButton in list)
            {
                int CurrentAnswerButtonIndex = Convert.ToInt32(RadioButton.Text);
                if (CurrentAnswerButtonIndex == value)
                    RadioButton.Checked = true;
                else
                    RadioButton.Checked = false;
            }
        }

        private int CurrentQuestionIndex = 0;

        private void btn_Answer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (CurrentQuestionIndex > 0)
            {
                FillQuestion(--CurrentQuestionIndex);

                txt_CurrentQuestion.Text = (CurrentQuestionIndex + 1).ToString();

                btn_Next.Enabled = (CurrentQuestionIndex == Questions.Count - 1) ? false : true;
                btn_Back.Enabled = (CurrentQuestionIndex == 0) ? false : true;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (CurrentQuestionIndex < Questions.Count - 1)
            {
                FillQuestion(++CurrentQuestionIndex);

                txt_CurrentQuestion.Text = (CurrentQuestionIndex + 1).ToString();

                btn_Next.Enabled = (CurrentQuestionIndex == Questions.Count - 1) ? false : true;
                btn_Back.Enabled = (CurrentQuestionIndex == 0) ? false : true;
            }
        }

        private void FillQuestion(int QuestionIndex)
        {
            lbl_Question.Text = (QuestionIndex + 1) + ". " + Questions[QuestionIndex].Question1;
            Check(AnswerButtons, (int)Results[QuestionIndex].ResultAnswer);
        }

        private void btn_Answer_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            long AnswerValue = Convert.ToInt64(ctrl.Text);
            Results[CurrentQuestionIndex].ResultAnswer = AnswerValue;

            //Display Finish button if all Results have an Answer
            foreach (ResultDefinition resultDefinition in Results)
                if (resultDefinition.ResultAnswer == -1)
                    return;

            btn_Finish.Visible = btn_Finish.Enabled = true;
        }

        private bool CanConvertToInt32(string Text)
        {
            if (Text == String.Empty)
                return false;

            foreach (char Chr in Text)
                if (Chr <= (char)'0' || Chr >= (char)'9')
                    return false;

            return true;
        }

        private string GetConvertableText(string Text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char Chr in Text)
                if (Chr <= (char)'9' && Chr >= (char)'0')
                    sb.Append(Chr);
            return (sb.ToString().Count() == 0) ? "0" : sb.ToString();
        }


        private void txt_CurrentQuestion_TextChanged(object sender, EventArgs e)
        {
            if (txt_CurrentQuestion.Text == (CurrentQuestionIndex + 1).ToString()) return;

            string NextQuestionNumberString = txt_CurrentQuestion.Text;

            if (!CanConvertToInt32(NextQuestionNumberString))
                NextQuestionNumberString = GetConvertableText(NextQuestionNumberString);


            int NextQuestionNumber = Convert.ToInt32(NextQuestionNumberString);
            txt_CurrentQuestion.Text = NextQuestionNumber.ToString();

            if (NextQuestionNumber < 1)
            {
                CurrentQuestionIndex = 0;
                txt_CurrentQuestion.Text = "1";
            }
            else if (NextQuestionNumber > Questions.Count)
            {
                CurrentQuestionIndex = Questions.Count - 1;
                txt_CurrentQuestion.Text = Questions.Count.ToString();
            }
            else
            {
                CurrentQuestionIndex = NextQuestionNumber - 1;
                FillQuestion(NextQuestionNumber - 1);
            }

            btn_Next.Enabled = (CurrentQuestionIndex == Questions.Count - 1) ? false : true;
            btn_Back.Enabled = (CurrentQuestionIndex == 0) ? false : true;
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            panel_ConductSurvey.Visible = false;
            panel_ConductSurvey.Enabled = false;
            panel_Finish.Visible = true;
            panel_Finish.Enabled = true;

            SurveyController surveyController = new SurveyController();
            string SurveyName = surveyController.Get(SurveyID).SurveyName;

            ResultController resultController = new ResultController();
            string DateNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            FinalResult.ResultName = "[" + DateNow + "] " + SurveyName;
            resultController.Add(FinalResult);

            foreach (ResultDefinition resultDefinition in Results)
                resultDefinition.ResultID = FinalResult.ResultID;

            ResultDefinitionController resultDefinitionController = new ResultDefinitionController();
            resultDefinitionController.Add(Results);
        }

        private void btn_Success_Exit_Click(object sender, EventArgs e)
        {
            Program.frm_MainForm.Show();
            base.Close();
        }
    }
}
