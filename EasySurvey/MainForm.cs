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

        private void MainForm_Load(object sender, EventArgs e)
        {
            Surveys = GetSurveys();

            foreach (Survey survey in Surveys)
            {
                listView1.Items.Add(new ListViewItem(survey.SurveyName, listView1.Groups["listViewGroup4"]));
            }

            //for (int i = 0; i <= 499; i++)
            //{
            //    listView1.Items.Add(new ListViewItem("Test de inteligenta pentru avansati - " + i.ToString(), listView1.Groups["listViewGroup4"]));
            //}

            lbl_Welcome.Text = "Welcome " + LoggedUser.UserName;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frm_Login.Show();
        }
    }
}
