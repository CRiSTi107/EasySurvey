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
            { grb_SelectedSurveyUser.Visible = false; grb_SelectedSurveyAdmin.Visible = true; listView_AllSurveys.ContextMenuStrip = materialContextMenuStripSurveys_Admin; listView_EditSurveyQuestions.ContextMenuStrip = materialContextMenuStrip_Admin; }
            else
            { grb_SelectedSurveyUser.Visible = true; grb_SelectedSurveyAdmin.Visible = false; listView_AllSurveys.ContextMenuStrip = null; listView_EditSurveyQuestions.ContextMenuStrip = null; }

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
        private void UpdateEditSurveyDetails(long SurveyID)
        {
            SurveyController surveyController = new SurveyController();
            Survey selectedSurvey = surveyController.GetSurvey(SurveyID);

            SelectedSurveyOriginalName = selectedSurvey.SurveyName;
            IsSelectedSurveyOriginalNameChanged = false;

            txt_EditSurveyDetailsName.Text = selectedSurvey.SurveyName;
            txt_EditSurveyDetailsName.Tag = selectedSurvey.SurveyID.ToString();

            listView_EditSurveyQuestions.Clear();

            QuestionController questionController = new QuestionController();

            List<Question> Questions = questionController.GetQuestions(SurveyID);
            foreach (Question question in Questions)
            {
                listView_EditSurveyQuestions.Items.Add(new ListViewItem(question.Question1) { Tag = question.QuestionID });
            }
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
                listView_ViewSurveyQuestions.Items.Add(new ListViewItem(question.Question1) { Tag = question.QuestionID });
            }
        }

        private void listView_AllSurveys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_AllSurveys.SelectedItems.Count != 1)
            {
                txt_EditSurveyDetailsName.Text = ""; txt_ViewSurveyDetailsName.Text = "";
                listView_ViewSurveyQuestions.Items.Clear(); listView_EditSurveyQuestions.Items.Clear();
                txt_ViewSurveyDetailsName.Tag = null; txt_EditSurveyDetailsName.Tag = null;
                btn_StartSurvey.Enabled = btn_StartSurvey.Visible = false;
                pic_SaveChanges.BackgroundImage = Properties.Resources.save_icon_disabled_24x24;
                pic_SaveChanges.Cursor = Cursors.Arrow;
                IsSelectedSurveyOriginalNameChanged = false;
                return;
            }
            else
            { btn_StartSurvey.Enabled = btn_StartSurvey.Visible = true; }

            ListViewItem selectedItem = listView_AllSurveys.SelectedItems[0];
            long SurveyID = Convert.ToInt64(selectedItem.Tag);

            if (LoggedUser.IsAdministrator())
                UpdateEditSurveyDetails(SurveyID);
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

        #region ToolStripMenuItem - Add | Edit | Delete - Surveys

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedSurveysCount = listView_AllSurveys.SelectedItems.Count;
            MaterialMessageBox.MessageBoxResult result = MaterialMessageBox.MessageBoxResult.None;

            if (SelectedSurveysCount > 0)
                result = MaterialMessageBox.Show("Sunteti sigur ca vrei sa stergeti chestionarele selectate?", "Easy Survey - Delete Surveys", MaterialMessageBox.MessageBoxButtons.YesNo, MaterialMessageBox.MessageBoxIcon.Warning);

            if (result == MaterialMessageBox.MessageBoxResult.Yes)
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

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialMessageInput.MessageBoxResultInput result = MaterialMessageInput.Show("Ce nume are noul chestionar?", "Easy Survey - Add New Survey", MaterialMessageInput.MessageBoxButtonsInput.OKCancel);

            if (result == MaterialMessageInput.MessageBoxResultInput.OK)
            {
                SurveyController surveyController = new SurveyController();
                string SurveyName = MaterialMessageInput.Answer;

                Survey newSurvey = new Survey { SurveyName = SurveyName };
                surveyController.Add(ref newSurvey);
                Surveys.Add(newSurvey);
                ListViewItem newSurveyItem = new ListViewItem(listView_AllSurveys.Groups["listViewGroup4"]) { Tag = newSurvey.SurveyID.ToString(), Text = newSurvey.SurveyName };
                listView_AllSurveys.Items.Add(newSurveyItem);
                int SurveyIndex = listView_AllSurveys.Items.Count - 1;
                listView_AllSurveys.Items[SurveyIndex].Selected = true;
                listView_AllSurveys.Items[SurveyIndex].Focused = true;
                listView_AllSurveys.Items[SurveyIndex].EnsureVisible();
            }

        }

        #endregion



        #region ToolStripMenuItem - Add | Edit | Delete - Questions

        private void toolStripMenuItem_AddNewQuestion_Click(object sender, EventArgs e)
        {
            MaterialMessageInput.MessageBoxResultInput result = MaterialMessageInput.Show("Noua intrebare care sa fie adaugata in chestionar:", "Easy Survey - Add New Question", MaterialMessageInput.MessageBoxButtonsInput.OKCancel);

            if (result == MaterialMessageInput.MessageBoxResultInput.OK)
            {
                QuestionController questionController = new QuestionController();
                string QuestionName = MaterialMessageInput.Answer;
                long SurveyID = Convert.ToInt64(txt_EditSurveyDetailsName.Tag);
                Question newQuestion = new Question { Question1 = QuestionName };
                questionController.Add(ref newQuestion, SurveyID);

                ListViewItem newQuestionItem = new ListViewItem() { Tag = newQuestion.QuestionID.ToString(), Text = newQuestion.Question1 };
                listView_EditSurveyQuestions.Items.Add(newQuestionItem);
                int QuestionIndex = listView_EditSurveyQuestions.Items.Count - 1;
                listView_EditSurveyQuestions.Items[QuestionIndex].Selected = true;
                listView_EditSurveyQuestions.Items[QuestionIndex].Focused = true;
                listView_EditSurveyQuestions.Items[QuestionIndex].EnsureVisible();
            }
        }

        private void toolStripMenuItem_DeleteQuestions_Click(object sender, EventArgs e)
        {
            int SelectedQuestionsCount = listView_EditSurveyQuestions.SelectedItems.Count;
            MaterialMessageBox.MessageBoxResult result = MaterialMessageBox.MessageBoxResult.None;

            if (SelectedQuestionsCount > 0)
                result = MaterialMessageBox.Show("Sunteti sigur ca vrei sa stergeti intrebarile selectate?", "Easy Survey - Delete Questions", MaterialMessageBox.MessageBoxButtons.YesNo, MaterialMessageBox.MessageBoxIcon.Warning);

            if (result == MaterialMessageBox.MessageBoxResult.Yes)
            {
                QuestionController questionController = new QuestionController();

                foreach (ListViewItem selectedItem in listView_EditSurveyQuestions.SelectedItems)
                {
                    long QuestionID = Convert.ToInt64(selectedItem.Tag);
                    long SurveyID = Convert.ToInt64(txt_EditSurveyDetailsName.Tag);

                    questionController.Delete(QuestionID, SurveyID);
                    listView_EditSurveyQuestions.Items.Remove(selectedItem);
                }

            }
        }

        private void editToolStripMenuItem_EditQuestion_Click(object sender, EventArgs e)
        {
            int SelectedQuestionsCount = listView_EditSurveyQuestions.SelectedItems.Count;
            MaterialMessageInput.MessageBoxResultInput result = MaterialMessageInput.MessageBoxResultInput.None;

            if (SelectedQuestionsCount == 0)
                return;

            int CurrentQuestion = 0;

            foreach (ListViewItem SelectedQuestion in listView_EditSurveyQuestions.SelectedItems)
            {
                result = MaterialMessageInput.MessageBoxResultInput.None;

                result = MaterialMessageInput.Show("Editeaza intrebarea:", "Easy Survey - Edit Question (" + ++CurrentQuestion + "/" + SelectedQuestionsCount + ")", MaterialMessageInput.MessageBoxButtonsInput.OKCancel, SelectedQuestion.Text);

                if (result == MaterialMessageInput.MessageBoxResultInput.OK)
                {
                    QuestionController questionController = new QuestionController();
                    string NewQuestionName = MaterialMessageInput.Answer;
                    long QuestionID = Convert.ToInt64(SelectedQuestion.Tag.ToString());

                    questionController.Update(QuestionID, NewQuestionName);

                    int QuestionIndex = listView_EditSurveyQuestions.Items.IndexOf(SelectedQuestion);
                    listView_EditSurveyQuestions.Items[QuestionIndex].Text = NewQuestionName;
                }
                else if (result == MaterialMessageInput.MessageBoxResultInput.None)
                {
                    break;
                }
            }



        }

        #endregion

        private void btn_StartSurvey_Click(object sender, EventArgs e)
        {

        }

        #region Admin - Save Changes - Survey Name

        private string SelectedSurveyOriginalName = String.Empty;
        private bool IsSelectedSurveyOriginalNameChanged = false;

        private void txt_EditSurveyDetailsName_TextChanged(object sender, EventArgs e)
        {
            string CurrentSurveyName = txt_EditSurveyDetailsName.Text;

            if (CurrentSurveyName != SelectedSurveyOriginalName)
            {
                IsSelectedSurveyOriginalNameChanged = true;
                pic_SaveChanges.BackgroundImage = Properties.Resources.save_icon_24x24;
                pic_SaveChanges.Cursor = Cursors.Hand;
            }
            else
            {
                IsSelectedSurveyOriginalNameChanged = false;
                pic_SaveChanges.BackgroundImage = Properties.Resources.save_icon_disabled_24x24;
                pic_SaveChanges.Cursor = Cursors.Arrow;
            }
        }

        private void pic_SaveChanges_Click(object sender, EventArgs e)
        {
            if (IsSelectedSurveyOriginalNameChanged)
            {
                SurveyController surveyController = new SurveyController();

                long SurveyID = Convert.ToInt64(txt_EditSurveyDetailsName.Tag.ToString());
                string NewSurveyName = txt_EditSurveyDetailsName.Text;

                surveyController.UpdateSurveyName(SurveyID, NewSurveyName);
                int SurveyListItemIndex = -1;
                foreach (ListViewItem SurveyListItem in listView_AllSurveys.SelectedItems)
                {
                    if (Convert.ToInt64(SurveyListItem.Tag.ToString()) == SurveyID)
                    {
                        SurveyListItemIndex = listView_AllSurveys.Items.IndexOf(SurveyListItem);
                        Surveys.Where(item => item.SurveyID == SurveyID).ToList().ForEach(item => item.SurveyName = NewSurveyName);
                        listView_AllSurveys.Items[SurveyListItemIndex].Text = NewSurveyName;
                    }
                }

                IsSelectedSurveyOriginalNameChanged = false;
                pic_SaveChanges.BackgroundImage = Properties.Resources.save_icon_disabled_24x24;
                pic_SaveChanges.Cursor = Cursors.Arrow;
            }
        }

        #endregion


    }
}
