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

            lbl_Welcome_SurveyName.Font = SurveyNameFont;
            btn_Welcome_Start.AutoSize = false;
            btn_Welcome_Start.Size = new Size(190, 36);
            SetHorizontalMiddle(btn_Welcome_Start);
        }

        #region Welcome Panel

        private Font SurveyNameFont = (new FontConverter().ConvertFromString("Roboto Medium; 21,75pt; style=Bold")) as Font;

        private void lbl_Welcome_SurveyName_FontChanged(object sender, EventArgs e)
        {
            lbl_Welcome_SurveyName.Font = SurveyNameFont;
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

        private List<Survey> Surveys = new List<Survey>();

        private void ConductSurvey_Load(object sender, EventArgs e)
        {

        }

        private void btn_Welcome_Start_Click(object sender, EventArgs e)
        {
            panel_Welcome.Enabled = false;
            panel_Welcome.Visible = false;

            panel_ConductSurvey.Enabled = true;
            panel_ConductSurvey.Visible = true;
        }
    }
}
