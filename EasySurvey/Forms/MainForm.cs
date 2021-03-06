﻿using EasySurvey.Controllers;
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
            lbl_AttitudeReportsInfo.Font = AttitudeReportsInfoFont;

            grb_SelectedSurveyAdmin.Location = new Point(472, 6);
            grb_SelectedSurveyUser.Location = new Point(472, 6);

            #endregion

            this.LoggedUser = loggedUser;
        }

        #region !== Surveys == !

        private List<Survey> Surveys = new List<Survey>();
        private List<Survey> SearchSurveys = new List<Survey>();

        private List<Survey> GetSurveys()
        {
            using (SurveyController surveyController = new SurveyController())
                return surveyController.GetAll();
        }

        #region Select Survey

        //For ADMIN
        private void UpdateEditSurveyDetails(long SurveyID)
        {
            UpdateSelectedSurvey(SurveyID, listView_EditSurveyQuestions);
        }

        //For USER
        private void UpdateViewSurveyDetails(long SurveyID)
        {
            UpdateSelectedSurvey(SurveyID, listView_ViewSurveyQuestions);
        }

        private void listView_AllSurveys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_AllSurveys.SelectedItems.Count != 1)
            {
                txt_EditSurveyDetailsName.Text = ""; txt_ViewSurveyDetailsName.Text = "";
                listView_ViewSurveyQuestions.Items.Clear(); listView_EditSurveyQuestions.Items.Clear();
                txt_ViewSurveyDetailsName.Tag = null; txt_EditSurveyDetailsName.Tag = null;
                btn_StartSurvey.Enabled = btn_StartSurvey.Visible = false;
                pic_SaveSurveyChanges.BackgroundImage = Properties.Resources.save_icon_disabled_24x24;
                pic_SaveSurveyChanges.Cursor = Cursors.Arrow;
                IsSelectedSurveyOriginalNameChanged = false;
                txt_EditSurveyDetailsName.Tag = -1;
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


        #region Search Survey

        private bool SearchSurvey = false;

        private void txt_AllSurveysSearchBar_Enter(object sender, EventArgs e)
        {
            SearchBarEnter(txt_AllSurveysSearchBar);
        }

        private void txt_AllSurveysSearchBar_Leave(object sender, EventArgs e)
        {
            SearchBarLeave(txt_AllAttitudesSearchBar);
        }

        private void txt_AllSurveysSearchBar_TextChanged(object sender, EventArgs e)
        {
            string Query = txt_AllSurveysSearchBar.Text;

            if (Query == "Search...") return;

            SearchSurveys = new List<Survey>();

            using (SurveyController surveyController = new SurveyController())
                SearchSurveys = new List<Survey>(surveyController.Search(Surveys, Query, ref SearchSurvey));

            UpdateListView(SearchSurveys, listView_AllSurveys);
        }

        #endregion

        #region Start Survey

        private void btn_StartSurvey_Click(object sender, EventArgs e)
        {
            // TODO: Display Make Survey Page.
            long SurveyID = Convert.ToInt64(txt_ViewSurveyDetailsName.Tag);
            Program.frm_ConductSurvey = new ConductSurvey(LoggedUser, SurveyID);
            base.Hide();
            Program.frm_ConductSurvey.ShowDialog();
        }

        #endregion

        #endregion

        // 908; 561
        private void MainForm_Load(object sender, EventArgs e)
        {
            txt_EditSurveyDetailsName.Clear();
            txt_ViewSurveyDetailsName.Text = String.Empty;
            listView_ViewSurveyQuestions.Clear();

            Surveys = GetSurveys();
            Attitudes = GetAttitudes();

            UpdateListView(Surveys, listView_AllSurveys);
            UpdateListView(Attitudes, listView_AllAttitudes);

            if (LoggedUser.IsAdministrator())
            {
                grb_SelectedSurveyUser.Visible = false;
                grb_SelectedSurveyAdmin.Visible = true;
                listView_AllSurveys.ContextMenuStrip = materialContextMenuStripSurvey_Admin;
                listView_EditSurveyQuestions.ContextMenuStrip = materialContextMenuStripQuestion_Admin;
                List<UserModelDataTransferObject> users;
                using (UserController userController = new UserController())
                    users = userController.GetUsers();
                cmb_SelectUserReport.Items.Clear();
                cmb_SelectUserReport.Items.Add("*");
                foreach (UserModelDataTransferObject user in users)
                    if (!user.IsAdministrator())
                        cmb_SelectUserReport.Items.Add(user.UserName);
                cmb_SelectUserReport.Text = "*";
            }
            else
            {
                grb_SelectedSurveyUser.Visible = true;
                grb_SelectedSurveyAdmin.Visible = false;
                listView_AllSurveys.ContextMenuStrip = null;
                listView_EditSurveyQuestions.ContextMenuStrip = null;

                materialTabControl.TabPages.Remove(tabPage_Attitudes);

                cmb_SelectUserReport.Items.Add(LoggedUser.UserName);
                cmb_SelectUserReport.Text = LoggedUser.UserName;
            }

            lbl_AboutUser.Text = LoggedUser.UserName;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frm_Login.Show();
        }

        #region About User - FontChanged and ForeColorChanged Events

        // private const string AboutUser_FontStringDefault = @"Roboto Black; 11,25pt; style=Bold";
        // private const string AboutUser_FontStringHover = @"Roboto Black; 11,25pt; style=Bold, Underline";

        private bool AboutUser_IsMouseEnter = false;

        private Color AboutUser_ForeColor = Color.White;

        private Font AboutUser_FontDefault = new Font("Roboto Black", 11.25F, FontStyle.Bold);
        private Font AboutUser_FontHover = new System.Drawing.Font("Roboto Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));


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
            base.Hide();
            Program.frm_Settings = new Settings(LoggedUser);
            Program.frm_Settings.Show();
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
            string TextMessage = "Sunteti sigur ca vrei sa stergeti chestionarele selectate?";
            MaterialMessageBox.MessageBoxIcon IconMessage = MaterialMessageBox.MessageBoxIcon.Warning;

            //Check if any Question from Surveys are contained into Attitudes
            long QuestionsCount = 0;
            using (AttitudeController attitudeController = new AttitudeController())
            using (QuestionController questionController = new QuestionController())
            {
                foreach (ListViewItem selectedItem in listView_AllSurveys.SelectedItems)
                {
                    long SurveyID = Convert.ToInt64(selectedItem.Tag);
                    List<Question> Questions = questionController.GetQuestionsForSurvey(SurveyID);

                    foreach (Question question in Questions)
                        if (attitudeController.Contains(question.QuestionID))
                            ++QuestionsCount;
                }
            }

            if (QuestionsCount > 0)
            {
                IconMessage = MaterialMessageBox.MessageBoxIcon.Error;
                TextMessage += Environment.NewLine + QuestionsCount + " (de) intrebari sunt continute in cateva Definitii de Atitudini(daca selectati DA acestea vor fi sterse din Definitii).";
            }

            if (SelectedSurveysCount > 0)
                result = MaterialMessageBox.Show(TextMessage, "Easy Survey - Delete Surveys", MaterialMessageBox.MessageBoxButtons.YesNo, IconMessage);

            if (result == MaterialMessageBox.MessageBoxResult.Yes)
                using (SurveyController surveyController = new SurveyController())
                    foreach (ListViewItem selectedItem in listView_AllSurveys.SelectedItems)
                    {
                        long SurveyID = Convert.ToInt64(selectedItem.Tag);

                        Surveys.Remove(Surveys.Find(i => i.SurveyID == SurveyID));
                        surveyController.Delete(SurveyID);
                        listView_AllSurveys.Items.Remove(selectedItem);
                    }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialMessageInput.MessageBoxResultInput result = MaterialMessageInput.Show("Ce nume are noul chestionar?", "Easy Survey - Add New Survey", MaterialMessageInput.MessageBoxButtonsInput.OKCancel, addSurvey: true);

            if (result == MaterialMessageInput.MessageBoxResultInput.OK)
                using (SurveyController surveyController = new SurveyController())
                {
                    string SurveyName = MaterialMessageInput.Answer;

                    Survey newSurvey = new Survey { SurveyName = SurveyName };
                    surveyController.Add(ref newSurvey);
                    Surveys.Add(newSurvey);
                    ListViewItem newSurveyItem = new ListViewItem(listView_AllSurveys.Groups["default"]) { Tag = newSurvey.SurveyID.ToString(), Text = newSurvey.SurveyName };
                    listView_AllSurveys.Items.Add(newSurveyItem);
                    int SurveyIndex = listView_AllSurveys.Items.Count - 1;
                    listView_AllSurveys.Items[SurveyIndex].Selected = true;
                    listView_AllSurveys.Items[SurveyIndex].Focused = true;
                    listView_AllSurveys.Items[SurveyIndex].EnsureVisible();
                }

        }

        #endregion

        private bool IsEmpty(string text)
        {
            if (text == String.Empty || text.Trim() == String.Empty)
                return true;
            return false;
        }

        private string TrimmedText(string text)
        {
            return text.Trim();
        }

        #region ToolStripMenuItem - Add | Edit | Delete - Questions

        private void toolStripMenuItem_AddNewQuestion_Click(object sender, EventArgs e)
        {
            MaterialMessageInput.MessageBoxResultInput result = MaterialMessageInput.MessageBoxResultInput.None;
            long SurveyID = Convert.ToInt64(txt_EditSurveyDetailsName.Tag);

            if (SurveyID != -1)
                result = MaterialMessageInput.Show("Noua intrebare care sa fie adaugata in chestionar:", "Easy Survey - Add New Question", MaterialMessageInput.MessageBoxButtonsInput.OKCancel, addQuestion: true);

            if (result == MaterialMessageInput.MessageBoxResultInput.OK)
                using (QuestionController questionController = new QuestionController())
                {
                    string QuestionName = MaterialMessageInput.Answer;
                    // long SurveyID = Convert.ToInt64(txt_EditSurveyDetailsName.Tag);
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
            string TextMessage = "Sunteti sigur ca vrei sa stergeti intrebarile selectate?";
            MaterialMessageBox.MessageBoxIcon IconMessage = MaterialMessageBox.MessageBoxIcon.Warning;

            long QuestionCount = 0;

            using (AttitudeController attitudeController = new AttitudeController())
                foreach (ListViewItem selectedItem in listView_EditSurveyQuestions.SelectedItems)
                {
                    long QuestionID = Convert.ToInt64(selectedItem.Tag);

                    if (attitudeController.Contains(QuestionID))
                        QuestionCount++;
                }

            if (QuestionCount > 0)
            {
                TextMessage += Environment.NewLine + QuestionCount + " (de) intrebari sunt continute in Definitii de Atitudini(daca selectati DA acestea vor fi sterse din Definitii)";
                IconMessage = MaterialMessageBox.MessageBoxIcon.Error;
            }

            if (SelectedQuestionsCount > 0)
                result = MaterialMessageBox.Show(TextMessage, "Easy Survey - Delete Questions", MaterialMessageBox.MessageBoxButtons.YesNo, IconMessage);

            if (result == MaterialMessageBox.MessageBoxResult.Yes)
            {
                using (QuestionController questionController = new QuestionController())
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

                result = MaterialMessageInput.Show("Editeaza intrebarea:", "Easy Survey - Edit Question (" + ++CurrentQuestion + "/" + SelectedQuestionsCount + ")", MaterialMessageInput.MessageBoxButtonsInput.OKCancel, SelectedQuestion.Text, editQuestion: true);

                if (result == MaterialMessageInput.MessageBoxResultInput.OK)
                    using (QuestionController questionController = new QuestionController())
                    {
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

        #region Save Changes - Survey Name

        private string SelectedSurveyOriginalName = String.Empty;
        private bool IsSelectedSurveyOriginalNameChanged = false;

        private void txt_EditSurveyDetailsName_TextChanged(object sender, EventArgs e)
        {
            string CurrentSurveyName = txt_EditSurveyDetailsName.Text;
            long SurveyID = Convert.ToInt64(txt_EditSurveyDetailsName.Tag);

            if (CurrentSurveyName != SelectedSurveyOriginalName && SurveyID != -1 && !IsEmpty(CurrentSurveyName))
            {
                IsSelectedSurveyOriginalNameChanged = true;
                pic_SaveSurveyChanges.BackgroundImage = Properties.Resources.save_icon_24x24;
                pic_SaveSurveyChanges.Cursor = Cursors.Hand;
            }
            else
            {
                IsSelectedSurveyOriginalNameChanged = false;
                pic_SaveSurveyChanges.BackgroundImage = Properties.Resources.save_icon_disabled_24x24;
                pic_SaveSurveyChanges.Cursor = Cursors.Arrow;
            }
        }

        private void pic_SaveChanges_Click(object sender, EventArgs e)
        {
            if (IsSelectedSurveyOriginalNameChanged)
            {
                long SurveyID = Convert.ToInt64(txt_EditSurveyDetailsName.Tag.ToString());
                string NewSurveyName = txt_EditSurveyDetailsName.Text;

                using (SurveyController surveyController = new SurveyController())
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

                SelectedSurveyOriginalName = NewSurveyName;
                IsSelectedSurveyOriginalNameChanged = false;
                pic_SaveSurveyChanges.BackgroundImage = Properties.Resources.save_icon_disabled_24x24;
                pic_SaveSurveyChanges.Cursor = Cursors.Arrow;
            }
        }

        #endregion



        #region !== Attitudes ==!

        private List<Attitude> Attitudes = new List<Attitude>();
        private List<Attitude> SearchAttitudes = new List<Attitude>();

        private List<Attitude> GetAttitudes()
        {
            using (AttitudeController attitudeController = new AttitudeController())
                return attitudeController.GetAttitudes();
        }

        #region Search Attitude

        private bool SearchAttitude = false;

        private void txt_AllAttitudesSearchBar_Enter(object sender, EventArgs e)
        {
            SearchBarEnter(txt_AllAttitudesSearchBar);
        }

        private void txt_AllAttitudesSearchBar_Leave(object sender, EventArgs e)
        {
            SearchBarLeave(txt_AllAttitudesSearchBar);
        }

        private void txt_AllAttitudesSearchBar_TextChanged(object sender, EventArgs e)
        {
            string Query = txt_AllAttitudesSearchBar.Text;

            if (Query == "Search...") return;

            SearchAttitudes = new List<Attitude>();

            using (AttitudeController attitudeController = new AttitudeController())
                SearchAttitudes = new List<Attitude>(attitudeController.Search(Attitudes, Query, ref SearchAttitude));

            UpdateListView(SearchAttitudes, listView_AllAttitudes);
        }

        #endregion

        #region Select Attitude

        private void listView_AllAttitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_AllAttitudes.SelectedItems.Count != 1)
            {
                txt_EditAttitudeDetailsName.Text = "";
                listView_EditAttitudeDefinition.Items.Clear();
                txt_EditAttitudeDetailsName.Tag = null;
                pic_SaveAttitudeChanges.BackgroundImage = Properties.Resources.save_icon_disabled_24x24;
                pic_SaveAttitudeChanges.Cursor = Cursors.Arrow;
                IsSelectedAttitudeOriginalNameChanged = false;
                txt_EditAttitudeDetailsName.Tag = -1;
                return;
            }

            ListViewItem selectedItem = listView_AllAttitudes.SelectedItems[0];
            long AttitudeID = Convert.ToInt64(selectedItem.Tag);

            if (LoggedUser.IsAdministrator())
                UpdateEditAttitudeDetails(AttitudeID);
        }

        private void UpdateEditAttitudeDetails(long AttitudeID)
        {
            UpdateSelectedAttitude(AttitudeID, listView_EditAttitudeDefinition);
        }

        #endregion

        #region Save Changes - Attitude Name

        private string SelectedAttitudeOriginalName = String.Empty;
        private bool IsSelectedAttitudeOriginalNameChanged = false;

        private void txt_EditAttitudeDetailsName_TextChanged(object sender, EventArgs e)
        {
            string CurrentAttitudeName = txt_EditAttitudeDetailsName.Text;
            long AttitudeID = Convert.ToInt64(txt_EditAttitudeDetailsName.Tag);

            if (CurrentAttitudeName != SelectedAttitudeOriginalName && AttitudeID != -1 && !IsEmpty(CurrentAttitudeName))
            {
                IsSelectedAttitudeOriginalNameChanged = true;
                pic_SaveAttitudeChanges.BackgroundImage = Properties.Resources.save_icon_24x24;
                pic_SaveAttitudeChanges.Cursor = Cursors.Hand;
            }
            else
            {
                IsSelectedAttitudeOriginalNameChanged = false;
                pic_SaveAttitudeChanges.BackgroundImage = Properties.Resources.save_icon_disabled_24x24;
                pic_SaveAttitudeChanges.Cursor = Cursors.Arrow;
            }
        }

        private void pic_SaveAttitudeChanges_Click(object sender, EventArgs e)
        {
            if (IsSelectedAttitudeOriginalNameChanged)
            {
                long AttitudeID = Convert.ToInt64(txt_EditAttitudeDetailsName.Tag);
                string NewAttitudeName = txt_EditAttitudeDetailsName.Text;

                using (AttitudeController attitudeController = new AttitudeController())
                    attitudeController.UpdateAttitudeName(AttitudeID, NewAttitudeName);

                int AttitudeListItemIndex = -1;
                foreach (ListViewItem AttitudeListItem in listView_AllAttitudes.SelectedItems)
                {
                    if (Convert.ToInt64(AttitudeListItem.Tag) == AttitudeID)
                    {
                        AttitudeListItemIndex = listView_AllAttitudes.Items.IndexOf(AttitudeListItem);
                        Attitudes.Where(item => item.AttitudeID == AttitudeID).ToList().ForEach(item => item.AttitudeName = NewAttitudeName);
                        listView_AllAttitudes.Items[AttitudeListItemIndex].Text = NewAttitudeName;
                    }
                }

                SelectedAttitudeOriginalName = NewAttitudeName;
                IsSelectedAttitudeOriginalNameChanged = false;
                pic_SaveAttitudeChanges.BackgroundImage = Properties.Resources.save_icon_disabled_24x24;
                pic_SaveAttitudeChanges.Cursor = Cursors.Arrow;
            }
        }

        #endregion

        #endregion



        #region !== Update Views ==!

        #region Update List View

        // START - Update All Surveys | Attitudes
        private void UpdateListView(List<Survey> surveys, ListView listView, string group_key = "default")
        {
            List<KeyValuePair<long, string>> IdNamePair = new List<KeyValuePair<long, string>>();

            foreach (Survey survey in surveys)
                IdNamePair.Add(new KeyValuePair<long, string>(survey.SurveyID, survey.SurveyName));

            UpdateListView(IdNamePair, listView, group_key);
        }

        private void UpdateListView(List<Attitude> attitudes, ListView listView, string group_key = "default")
        {
            List<KeyValuePair<long, string>> IdNamePair = new List<KeyValuePair<long, string>>();

            foreach (Attitude attitude in attitudes)
                IdNamePair.Add(new KeyValuePair<long, string>(attitude.AttitudeID, attitude.AttitudeName));

            UpdateListView(IdNamePair, listView, group_key);
        }

        private void UpdateListView(List<KeyValuePair<long, string>> list, ListView listView, string group_key = "default")
        {
            listView.Items.Clear();
            foreach (KeyValuePair<long, string> pair in list)
            {
                ListViewItem item = new ListViewItem(pair.Value, listView.Groups[group_key]);
                item.Tag = pair.Key;
                listView.Items.Add(item);
            }
        }
        // END - Update All Surveys | Attitudes


        // START - Update Selected Survey | Attitude
        private void UpdateSelectedSurvey(long SurveyID, ListView listView)
        {
            using (SurveyController surveyController = new SurveyController())
            {
                Survey selectedSurvey = surveyController.Get(SurveyID);

                if (LoggedUser.IsAdministrator())
                {
                    txt_EditSurveyDetailsName.Text = selectedSurvey.SurveyName;
                    txt_EditSurveyDetailsName.Tag = selectedSurvey.SurveyID.ToString();

                    SelectedSurveyOriginalName = selectedSurvey.SurveyName;
                    IsSelectedSurveyOriginalNameChanged = false;
                }
                else
                {
                    txt_ViewSurveyDetailsName.Text = selectedSurvey.SurveyName;
                    txt_ViewSurveyDetailsName.Tag = selectedSurvey.SurveyID.ToString();
                }
            }

            listView.Clear();

            using (QuestionController questionController = new QuestionController())
            {
                List<Question> Questions = questionController.GetQuestionsForSurvey(SurveyID);
                foreach (Question question in Questions)
                    listView.Items.Add(new ListViewItem(question.Question1) { Tag = question.QuestionID });
            }
        }

        private void UpdateSelectedAttitude(long AttitudeID, ListView listView)
        {
            using (AttitudeController attitudeController = new AttitudeController())
            {
                Attitude selectedAttitude = attitudeController.GetAttitude(AttitudeID);
                if (LoggedUser.IsAdministrator())
                {
                    txt_EditAttitudeDetailsName.Text = selectedAttitude.AttitudeName;
                    txt_EditAttitudeDetailsName.Tag = selectedAttitude.AttitudeID.ToString();

                    SelectedAttitudeOriginalName = selectedAttitude.AttitudeName;
                    IsSelectedAttitudeOriginalNameChanged = false;
                }
            }

            listView.Clear();

            using (QuestionController questionController = new QuestionController())
            {
                List<Question> Questions = questionController.GetQuestionsForAttitude(AttitudeID);
                foreach (Question question in Questions)
                    listView.Items.Add(new ListViewItem(question.Question1) { Tag = question.QuestionID });
            }
        }
        // END - Update Selected Survey | Attitude

        #endregion

        #region Search

        private void SearchBarEnter(MaterialSingleLineTextField txt_SearchBar)
        {
            string Query = txt_SearchBar.Text;
            if (Query == "Search...")
            {
                txt_SearchBar.Text = "";
                txt_SearchBar.ForeColor = Color.Black;
            }
        }

        private void SearchBarLeave(MaterialSingleLineTextField txt_SearchBar)
        {
            string Query = txt_SearchBar.Text;
            if (Query == "")
            {
                txt_SearchBar.Text = "Search...";
                txt_SearchBar.ForeColor = Color.Gray;
            }
        }

        #endregion

        #endregion

        private void addNewAttitudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialMessageInput.MessageBoxResultInput result = MaterialMessageInput.Show("Ce nume are noua atitudine?", "Easy Survey - Add New Attitude", MaterialMessageInput.MessageBoxButtonsInput.OKCancel, addAttitude: true);

            if (result == MaterialMessageInput.MessageBoxResultInput.OK)
            {
                string AttitudeName = MaterialMessageInput.Answer;

                Attitude newAttitude = new Attitude { AttitudeName = AttitudeName };
                using (AttitudeController attitudeController = new AttitudeController())
                    attitudeController.Add(ref newAttitude);
                Attitudes.Add(newAttitude);

                ListViewItem newAttitudeItem = new ListViewItem(listView_AllAttitudes.Groups["default"]) { Tag = newAttitude.AttitudeID.ToString(), Text = newAttitude.AttitudeName };
                listView_AllAttitudes.Items.Add(newAttitudeItem);

                int AttitudeIndex = listView_AllAttitudes.Items.Count - 1;
                listView_AllAttitudes.Items[AttitudeIndex].Selected = true;
                listView_AllAttitudes.Items[AttitudeIndex].Focused = true;
                listView_AllAttitudes.Items[AttitudeIndex].EnsureVisible();
            }
        }

        private void deleteAttitudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedAttitudesCount = listView_AllAttitudes.SelectedItems.Count;
            MaterialMessageBox.MessageBoxResult result = MaterialMessageBox.MessageBoxResult.None;

            if (SelectedAttitudesCount > 0)
                result = MaterialMessageBox.Show("Sunteti sigur ca vrei sa stergeti atitudinile selectate?", "Easy Survey - Delete Attitudes", MaterialMessageBox.MessageBoxButtons.YesNo, MaterialMessageBox.MessageBoxIcon.Warning);

            if (result == MaterialMessageBox.MessageBoxResult.Yes)
            {
                using (AttitudeController attitudeController = new AttitudeController())
                    foreach (ListViewItem selectedItem in listView_AllAttitudes.SelectedItems)
                    {
                        long AttitudeID = Convert.ToInt64(selectedItem.Tag);

                        Attitudes.Remove(Attitudes.Find(i => i.AttitudeID == AttitudeID));
                        attitudeController.Delete(AttitudeID);
                        listView_AllAttitudes.Items.Remove(selectedItem);
                    }
            }
        }

        private void toolStripMenuItem_DeleteAttitudeDefinitions_Click(object sender, EventArgs e)
        {
            int SelectedAttributesCount = listView_EditAttitudeDefinition.SelectedItems.Count;
            MaterialMessageBox.MessageBoxResult result = MaterialMessageBox.MessageBoxResult.None;

            if (SelectedAttributesCount > 0)
                result = MaterialMessageBox.Show("Sunteti sigur ca vrei sa stergeti intrebarile selectate din definitia atitudinii?", "Easy Survey - Delete Attitude Definition", MaterialMessageBox.MessageBoxButtons.YesNo, MaterialMessageBox.MessageBoxIcon.Warning);

            if (result == MaterialMessageBox.MessageBoxResult.Yes)
            {
                using (AttitudeDefinitionController attitudeDefinitionController = new AttitudeDefinitionController())
                    foreach (ListViewItem selectedItem in listView_EditAttitudeDefinition.SelectedItems)
                    {
                        long QuestionID = Convert.ToInt64(selectedItem.Tag);
                        long AttitudeID = Convert.ToInt64(txt_EditAttitudeDetailsName.Tag);

                        attitudeDefinitionController.Delete(QuestionID, AttitudeID);
                        listView_EditAttitudeDefinition.Items.Remove(selectedItem);
                    }

            }
        }

        private void toolStripMenuItem_AddAttitudeDefinitions_Click(object sender, EventArgs e)
        {
            MaterialMessageComboBox.MessageBoxResult result = MaterialMessageComboBox.MessageBoxResult.None;

            long AttitudeID = Convert.ToInt64(txt_EditAttitudeDetailsName.Tag);

            if (AttitudeID != -1)
                result = MaterialMessageComboBox.Show("Select survey and question.", "Easy Survey - Add New Attitude Definition", MaterialMessageComboBox.MessageBoxButtons.OKCancel, AttitudeID);

            if (result == MaterialMessageComboBox.MessageBoxResult.OK)
            {
                //long NewSurveyID = MaterialMessageComboBox.Answer1;
                long NewQuestionID = MaterialMessageComboBox.Answer2;

                using (QuestionController questionController = new QuestionController())
                using (AttitudeDefinitionController attitudeDefinitionController = new AttitudeDefinitionController())
                {
                    string QuestionName = questionController.Get(NewQuestionID).Question1;
                    if (attitudeDefinitionController.AddRelation(AttitudeID, NewQuestionID))
                    {
                        listView_EditAttitudeDefinition.Items.Add(new ListViewItem() { Text = QuestionName, Tag = NewQuestionID });
                    }
                }
            }

        }

        private void toolStripMenuItem_EditAttitudeDefinitions_Click(object sender, EventArgs e)
        {
            int SelectedAttitudeDefinitionCount = listView_EditAttitudeDefinition.SelectedItems.Count;
            MaterialMessageComboBox.MessageBoxResult result = MaterialMessageComboBox.MessageBoxResult.None;

            if (SelectedAttitudeDefinitionCount == 0)
                return;

            int CurrentAttitudeDefinition = 0;

            using (SurveyController surveyController = new SurveyController())
            using (QuestionController questionController = new QuestionController())
            {

                long AttitudeID = Convert.ToInt64(txt_EditAttitudeDetailsName.Tag);
                long SurveyID = -1;
                long QuestionID = -1;

                foreach (ListViewItem SelectedAttitudeDefinition in listView_EditAttitudeDefinition.SelectedItems)
                {
                    QuestionID = Convert.ToInt64(SelectedAttitudeDefinition.Tag);
                    SurveyID = surveyController.GetByQuestion(QuestionID).SurveyID;

                    result = MaterialMessageComboBox.MessageBoxResult.None;
                    result = MaterialMessageComboBox.Show("Editeaza definitia atitudinii:", "Easy Survey - Edit Attitude Definition (" + ++CurrentAttitudeDefinition + "/" + SelectedAttitudeDefinitionCount + ")", MaterialMessageComboBox.MessageBoxButtons.OKCancel, AttitudeID, SurveyID, QuestionID);

                    if (result == MaterialMessageComboBox.MessageBoxResult.OK)
                    {
                        AttitudeDefinitionController attitudeDefinitionController = new AttitudeDefinitionController();

                        long NewSurveyID = MaterialMessageComboBox.Answer1;
                        long NewQuestionID = MaterialMessageComboBox.Answer2;

                        attitudeDefinitionController.Update(AttitudeID, QuestionID, NewQuestionID);

                        string NewQuestionName = questionController.Get(NewQuestionID).Question1;

                        int AttitudeDefinitionIndex = listView_EditAttitudeDefinition.Items.IndexOf(SelectedAttitudeDefinition);
                        listView_EditAttitudeDefinition.Items[AttitudeDefinitionIndex].Text = NewQuestionName;
                        listView_EditAttitudeDefinition.Items[AttitudeDefinitionIndex].Tag = NewQuestionID;
                    }
                    else if (result == MaterialMessageComboBox.MessageBoxResult.None)
                    {
                        break;
                    }
                }
            }
        }

        private void materialTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TabIndex = materialTabControl.SelectedIndex;

            const int SURVEYS = 0;
            const int ATTITUDES = 1;

            if (TabIndex == SURVEYS)
            {

            }
            else if (TabIndex == ATTITUDES)
            {
                //Update selected Items and updates if any Question has been modified.
                List<int> ItemIndexes = new List<int>();

                for (int ItemIndex = 0; ItemIndex <= listView_AllAttitudes.Items.Count - 1; ItemIndex++)
                    if (listView_AllAttitudes.Items[ItemIndex].Selected)
                    {
                        ItemIndexes.Add(ItemIndex);
                        listView_AllAttitudes.Items[ItemIndex].Selected = false;
                    }

                foreach (int ItemIndex in ItemIndexes)
                {
                    listView_AllAttitudes.Items[ItemIndex].Selected = true;
                }
            }
        }

        private void tabPage_Reports_Enter(object sender, EventArgs e)
        {
            RefreshReports();
        }

        private void RefreshReports()
        {
            int SelectedIndex = cmb_SelectUserReport.SelectedIndex;
            cmb_SelectUserReport.SelectedIndex = -1;
            cmb_SelectUserReport.SelectedIndex = SelectedIndex;
        }

        private void cmb_SelectUserReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Username = cmb_SelectUserReport.Text;
            int SelectedIndex = cmb_SelectUserReport.SelectedIndex;

            listView_UserReports.Items.Clear();
            listView_AttitudeReports.Items.Clear();

            if (Username == "*" || SelectedIndex == -1) return;

            UserModelDataTransferObject SelectedUser;
            using (UserController userController = new UserController())
                SelectedUser = userController.GetUserByName(Username);
            long UserID = SelectedUser.UserID;

            List<Result> UserResults;
            using (ResultController resultController = new ResultController())
                UserResults = resultController.GetForUser(UserID);

            UserResults = UserResults.OrderBy(r => r.SurveyID).ThenByDescending(r => r.Date).ToList();

            SurveyController surveyController = new SurveyController();

            foreach (Result result in UserResults)
            {
                string SurveyName = surveyController.Get(result.SurveyID).SurveyName;
                listView_UserReports.Items.Add(new ListViewItem(listView_UserReports.Groups["default"]) { Text = result.ToString(), Tag = result.ResultID });
            }

            //Get list of lastest User Reports
            List<long> UsedSurveyID = new List<long>();
            List<Result> LastUserReports = new List<Result>();
            foreach (Result result in UserResults)
                if (!UsedSurveyID.Contains(result.SurveyID))
                {
                    UsedSurveyID.Add(result.SurveyID);
                    LastUserReports.Add(result);
                }
            UsedSurveyID = null;

            //Calculate Attitude Score
            using (AttitudeController attitudeController = new AttitudeController())
            using (AttitudeDefinitionController attitudeDefinitionController = new AttitudeDefinitionController())
            using (ResultDefinitionController resultDefinitionController = new ResultDefinitionController())
            {
                List<Attitude> attitudes = attitudeController.GetAttitudes();

                listView_AttitudeReports.Items.Clear();

                foreach (Attitude attitude in attitudes)
                {
                    long AttitudeSum = 0;
                    bool Found = false;

                    List<AttitudeDefinition> attitudeDefinitions = attitudeDefinitionController.GetRelation(attitude.AttitudeID);
                    foreach (AttitudeDefinition attitudeDefinition in attitudeDefinitions)
                    {
                        long QuestionID = attitudeDefinition.QuestionID;


                        foreach (Result result in LastUserReports)
                        {
                            List<ResultDefinition> resultDefinitions = resultDefinitionController.Get(result.ResultID);
                            Found = false;
                            foreach (ResultDefinition resultDefinition in resultDefinitions)
                                if (resultDefinition.QuestionID == QuestionID)
                                {
                                    AttitudeSum += resultDefinition.ResultAnswer;
                                    Found = true;
                                    break;
                                }
                            if (Found) break;
                        }

                        string SurveyName = surveyController.GetByQuestion(QuestionID).SurveyName;

                        if (!Found)
                        {
                            listView_AttitudeReports.Items.Add(
                                      new ListViewItem(listView_AttitudeReports.Groups["default"])
                                      {
                                          ForeColor = Color.Red,
                                          Text = attitude.AttitudeName + " - requires '" + SurveyName + "'",
                                          Tag = attitude.AttitudeID
                                      });
                            break;
                        }
                    }

                    if (Found)
                        listView_AttitudeReports.Items.Add(
                            new ListViewItem(listView_AttitudeReports.Groups["default"])
                            {
                                Text = attitude.AttitudeName + " - " + AttitudeSum,
                                Tag = attitude.AttitudeID
                            });
                }
            }
        }

        private Font AttitudeReportsInfoFont = (new FontConverter().ConvertFromString("Roboto Condensed; 9pt") as Font);

        private void lbl_AttitudeReportsInfo_FontChanged(object sender, EventArgs e)
        {
            lbl_AttitudeReportsInfo.Font = AttitudeReportsInfoFont;
        }

        private void deleteToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            int SelectedResults = listView_UserReports.SelectedItems.Count;

            if (SelectedResults == 0) return;

            MaterialMessageBox.MessageBoxResult result = MaterialMessageBox.MessageBoxResult.None;
            result = MaterialMessageBox.Show("Are you sure you want to delete " + SelectedResults + " selected reports?", "Easy Survey - Delete Reports", MaterialMessageBox.MessageBoxButtons.YesNo, MaterialMessageBox.MessageBoxIcon.Warning);

            IEnumerable<ListViewItem> SelectedUserReports = listView_UserReports.SelectedItems.Cast<ListViewItem>();

            if (result == MaterialMessageBox.MessageBoxResult.Yes)
            {
                using (ResultController resultController = new ResultController())
                    foreach (ListViewItem reportItem in SelectedUserReports)
                    {
                        long ResultID = Convert.ToInt64(reportItem.Tag);
                        resultController.Delete(ResultID);
                        listView_UserReports.Items.Remove(reportItem);
                    }
                RefreshReports();
            }
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            RefreshReports();
        }
    }
}
