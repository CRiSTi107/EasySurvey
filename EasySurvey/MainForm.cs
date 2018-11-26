using EasySurvey.Controllers;
using EasySurvey.Models;
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
    public partial class MainForm : MaterialForm
    {
        private UserModelDataTransferObject LoggedUser;

        public MainForm(UserModelDataTransferObject loggedUser)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            #region Initialize Component

            lbl_AboutUser.ForeColor = AboutUser_ForeColor;
            lbl_AboutUser.Font = AboutUser_FontDefault;

            grb_SelectedSurveyAdmin.Location = new Point(472, 6);
            grb_SelectedSurveyUser.Location = new Point(472, 6);

            #endregion

            this.LoggedUser = loggedUser;
        }

        private List<Survey> Surveys = new List<Survey>();
        private List<Survey> SearchSurveys = new List<Survey>();

        private List<Survey> GetSurveys()
        {
            SurveyController surveyController = new SurveyController();
            return surveyController.GetSurveys();
        }

        private void UpdateListView(List<Survey> list)
        {
            listView_AllSurveys.Items.Clear();
            foreach (Survey survey in list)
            {
                ListViewItem item = new ListViewItem(survey.SurveyName, listView_AllSurveys.Groups["listViewGroup4"]);
                item.Tag = survey.SurveyID;
                listView_AllSurveys.Items.Add(item);
            }
        }

        // 908; 561
        private void MainForm_Load(object sender, EventArgs e)
        {
            txt_EditSurveyDetailsName.Clear();
            txt_ViewSurveyDetailsName.Text = String.Empty;
            listView_ViewSurveyQuestions.Clear();

            Surveys = GetSurveys();

            UpdateListView(Surveys);

            if (LoggedUser.IsAdministrator())
            { grb_SelectedSurveyUser.Visible = false; grb_SelectedSurveyAdmin.Visible = true; listView_AllSurveys.ContextMenuStrip = materialContextMenuStrip_Admin; }
            else
            { grb_SelectedSurveyUser.Visible = true; grb_SelectedSurveyAdmin.Visible = false; listView_AllSurveys.ContextMenuStrip = null; }

            lbl_AboutUser.Text = LoggedUser.UserName;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frm_Login.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Surveys = GetSurveys();

            UpdateListView(Surveys);
        }

        #region Search

        private bool Search = false;

        private void txt_AllSurveysSearchBar_Enter(object sender, EventArgs e)
        {
            string Query = txt_AllSurveysSearchBar.Text;
            if (Query == "Search...")
            {
                txt_AllSurveysSearchBar.Text = "";
                txt_AllSurveysSearchBar.ForeColor = Color.Black;
            }

        }

        private void txt_AllSurveysSearchBar_Leave(object sender, EventArgs e)
        {
            string Query = txt_AllSurveysSearchBar.Text;
            if (Query == "")
            {
                txt_AllSurveysSearchBar.Text = "Search...";
                txt_AllSurveysSearchBar.ForeColor = Color.Gray;
            }

        }

        private void txt_AllSurveysSearchBar_TextChanged(object sender, EventArgs e)
        {
            string Query = txt_AllSurveysSearchBar.Text;

            if (Query == "Search...") return;

            SearchSurveys = new List<Survey>();

            SurveyController surveyController = new SurveyController();
            SearchSurveys = new List<Survey>(surveyController.Search(Surveys, Query, ref Search));

            UpdateListView(SearchSurveys);
        }


        #endregion

        #region Select Survey

        //For ADMIN
        private void UpdateEditSurveyDetails(string SurveyName)
        {
            txt_EditSurveyDetailsName.Text = SurveyName;
        }

        //For USER
        private void UpdateViewSurveyDetails(long SurveyID)
        {
            SurveyController surveyController = new SurveyController();
            Survey selectedSurvey = surveyController.GetSurvey(SurveyID);
            txt_ViewSurveyDetailsName.Text = selectedSurvey.SurveyName;

            listView_ViewSurveyQuestions.Clear();

            QuestionController questionController = new QuestionController();

            List<Question> Questions = questionController.GetQuestions(SurveyID);
            foreach (Question question in Questions)
            {
                listView_ViewSurveyQuestions.Items.Add(new ListViewItem(question.Question1));
            }
        }

        private void listView_AllSurveys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_AllSurveys.SelectedItems.Count != 1)
            { txt_EditSurveyDetailsName.Text = "Select one"; btn_StartSurvey.Enabled = btn_StartSurvey.Visible = false; return; }
            else
            { btn_StartSurvey.Enabled = btn_StartSurvey.Visible = true; }

            ListViewItem selectedItem = listView_AllSurveys.SelectedItems[0];
            long SurveyID = Convert.ToInt64(selectedItem.Tag);

            if (LoggedUser.IsAdministrator())
                UpdateEditSurveyDetails(selectedItem.Text);
            else
                UpdateViewSurveyDetails(SurveyID);

        }

        #endregion

        #region About User - FontChanged and ForeColorChanged Events

        private const string AboutUser_FontStringDefault = @"Roboto Black; 11,25pt; style=Bold";
        private const string AboutUser_FontStringHover = @"Roboto Black; 11,25pt; style=Bold, Underline";

        private bool AboutUser_IsMouseEnter = false;

        private Color AboutUser_ForeColor = Color.White;

        private Font AboutUser_FontDefault = ((new FontConverter().ConvertFromString(AboutUser_FontStringDefault)) as Font);
        private Font AboutUser_FontHover = ((new FontConverter().ConvertFromString(AboutUser_FontStringHover)) as Font);


        private void lbl_AboutUser_ForeColorChanged(object sender, EventArgs e)
        {
            lbl_AboutUser.ForeColor = AboutUser_ForeColor;
        }

        private void lbl_AboutUser_FontChanged(object sender, EventArgs e)
        {
            if (!AboutUser_IsMouseEnter)
                lbl_AboutUser.Font = AboutUser_FontDefault;
            else
                lbl_AboutUser.Font = AboutUser_FontHover;
        }

        #endregion

        #region About User - Mouse Enter/Leave and Click Events

        private void AboutUser_MouseEnter(object sender, EventArgs e)
        {
            AboutUser_IsMouseEnter = true;
            lbl_AboutUser.Font = AboutUser_FontHover;
        }

        private void AboutUser_MouseLeave(object sender, EventArgs e)
        {
            AboutUser_IsMouseEnter = false;
            lbl_AboutUser.Font = AboutUser_FontDefault;
        }

        private void AboutUser_Click(object sender, EventArgs e)
        {
            // TODO: Open - About User Dialog here
        }


        #endregion

        private void tabPage_AllSurveys_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            // Designer things **
            // decimal phi = (1 + (decimal)Math.Sqrt(5)) / 2;
            // 
            // base.Size = new Size(Convert.ToInt32(base.Height * phi), base.Height);
            // 
            // MessageBox.Show(base.Size.ToString());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("Sunteti sigur ca vrei sa stergeti chestionarele selectate?", "Easy Survey - Delete Surveys", MaterialMessageBox.MessageBoxButtons.YesNo, MaterialMessageBox.MessageBoxIcon.Warning);

            if (MaterialMessageBox._Result == MaterialMessageBox.MessageBoxResult.Yes)
            {
                SurveyController surveyController = new SurveyController();

                foreach (ListViewItem selectedItem in listView_AllSurveys.SelectedItems)
                {
                    long SurveyID = Convert.ToInt64(selectedItem.Tag);

                    Surveys.Remove(Surveys.Find(i => i.SurveyID == SurveyID));
                    surveyController.Delete(SurveyID);
                    listView_AllSurveys.Items.Remove(selectedItem);
                }


            }
        }
    }
}
