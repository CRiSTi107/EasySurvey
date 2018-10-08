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

        private void MainForm_Load(object sender, EventArgs e)
        {
            Surveys = GetSurveys();

            UpdateListView(Surveys);

            if (LoggedUser.IsAdministrator())
            { grb_SelectedSurveyUser.Visible = false; grb_SelectedSurveyAdmin.Visible = true; }
            else
            { grb_SelectedSurveyUser.Visible = true; grb_SelectedSurveyAdmin.Visible = false; }

            lbl_Welcome.Text = "Welcome " + LoggedUser.UserName;
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
        private void UpdateViewSurveyDetails(string SurveyName)
        {

        }

        private void listView_AllSurveys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_AllSurveys.SelectedItems.Count != 1)
            { txt_EditSurveyDetailsName.Text = "Select one"; return; }

            ListViewItem selectedItem = listView_AllSurveys.SelectedItems[0];

            if (LoggedUser.IsAdministrator())
                UpdateEditSurveyDetails(selectedItem.Text);
            else
                UpdateViewSurveyDetails(selectedItem.Text);

        }

        #endregion
    }
}
