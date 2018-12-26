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

            panel_ConductSurvey.Enabled = false;
            panel_ConductSurvey.Visible = false;

            lbl_Welcome_SurveyName.Font = lbl_SurveyName.Font = SurveyNameFont;
            btn_Welcome_Start.AutoSize = false;
            btn_Welcome_Start.Size = new Size(190, 36);
            SetHorizontalMiddle(btn_Welcome_Start);

            btn_Next.AutoSize = btn_Back.AutoSize = false;
            btn_Back.Size = btn_Next.Size = new Size(195, 36);

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
                //Results.Add(new ResultDefinition() {  })
            }
        }

        private void ConductSurvey_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frm_MainForm.Location = base.Location;
            Program.frm_MainForm.Show();
        }



        private void btn_Answer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

        }
    }
}
