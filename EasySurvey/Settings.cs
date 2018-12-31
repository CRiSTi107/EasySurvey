using EasySurvey.Controllers;
using EasySurvey.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasySurvey
{
    public partial class Settings : MaterialForm
    {
        private UserModelDataTransferObject LoggedUser;
        private readonly MaterialSkinManager materialSkinManager;

        public Settings(UserModelDataTransferObject LoggedUser)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            // Logged User
            this.LoggedUser = LoggedUser;

            // Initialize Fonts (Material Skin is buggy)
            lbl_EasySurvey.Font = EasySurveyFont;
            lbl_Owner.Font = OwnerFont;
            lbl_Username.Font = UsernameFont;
            lbl_UserRole.Font = UserRoleFont;

            //Setting App Logo in middle.
            SetHorizontalMiddle(pic_EasySurveyLogo);
            SetHorizontalMiddle(pic_GitHub);
            SetHorizontalMiddle(btn_MeSaveChanges);
        }



        private void Settings_Load(object sender, EventArgs e)
        {
            AddManyTo(MenuPanels, panel_About, panel_Me, panel_Users, panel_Database);

            if (!LoggedUser.IsAdministrator())
            {
                RemoveManyFrom(treeView_Menu.Nodes, USERS, DATABASE);
            }

            treeView_Menu.SelectedNode = treeView_Menu.Nodes[ABOUT];
        }

        private void DisplayMenuPanel(Panel PanelToDisplay)
        {
            foreach (Panel panel in MenuPanels)
            {
                if (panel.Equals(PanelToDisplay))
                    panel.Visible = panel.Enabled = true;
                else
                    panel.Visible = panel.Enabled = false;
            }
        }

        private void AddManyTo<T>(List<T> ListToAdd, params T[] Panels) where T : Panel
        {
            for (int PanelIndex = 0; PanelIndex <= Panels.Count() - 1; ++PanelIndex)
                ListToAdd.Add(Panels[PanelIndex]);
        }

        private void RemoveManyFrom<T>(T collection, params string[] Nodes) where T : TreeNodeCollection
        {
            foreach (TreeNode tn in collection.Cast<TreeNode>().ToList())
                if (Nodes.Contains(tn.Text))
                    collection.Remove(tn);
        }

        #region About

        private void SetHorizontalMiddle<T>(T control) where T : Control
        {
            control.Location = new Point(control.Parent.Width / 2 - control.Size.Width / 2, control.Location.Y);
        }


        private Font EasySurveyFont = new Font("Roboto", 21.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
        private Color EasySurveyColor = Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        private void lbl_EasySurvey_FontChanged(object sender, EventArgs e)
        {
            lbl_EasySurvey.Font = EasySurveyFont;
            lbl_EasySurvey.ForeColor = EasySurveyColor;
        }

        private Font OwnerFont = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
        private Color OwnerColor = Color.Gray;
        private void lbl_Owner_FontChanged(object sender, EventArgs e)
        {
            lbl_Owner.Font = OwnerFont;
            lbl_Owner.ForeColor = OwnerColor;
        }

        private void pic_GitHub_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/CRiSTi107/EasySurvey");
        }

        private Updater updater = new Updater();

        private void SetCurrentVersion()
        {
            Version CurrentVersion = updater.GetCurrentVersion();
            lbl_CurrentVersion.Text = "Version: " + CurrentVersion.ToString();
        }

        private void lbl_CheckForUpdates_Click(object sender, EventArgs e)
        {
            updater.CheckForUpdates(false);
            SetCurrentVersion();
        }

        private void lbl_CheckForUpdates_MouseEnter(object sender, EventArgs e)
        {
            lbl_CheckForUpdates.ForeColor = Color.Gray;
        }

        private void lbl_CheckForUpdates_MouseLeave(object sender, EventArgs e)
        {
            lbl_CheckForUpdates.ForeColor = Color.Black;
        }

        #endregion


        public const string ABOUT = "About";
        public const string ME = "Me";
        public const string USERS = "Users";
        public const string DATABASE = "Database";


        private List<Panel> MenuPanels = new List<Panel>();

        #region Me

        private void SetMeUsername()
        {
            lbl_Username.Text = LoggedUser.UserName;
            lbl_UserRole.Text = LoggedUser.RoleName;
        }

        private void PasswordSetStatus(string StatusText, bool IsError = true)
        {
            lbl_PasswordStatus.Text = StatusText;
            lbl_PasswordStatus.ForeColor = (IsError) ? Color.Red : Color.Green;
        }

        private void pic_UnlockPassword_Click(object sender, EventArgs e)
        {
            rdb_UnlockPassword.Checked = true;
        }

        private void pic_LockPassword_Click(object sender, EventArgs e)
        {
            rdb_LockPassword.Checked = true;
        }

        private bool ProtectUserByPassword;

        private void rdb_UnlockPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_UnlockPassword.Checked)
            {
                ProtectUserByPassword = false;
                lbl_UnlockPassword.ForeColor = Color.Black;
                panel_NewPassword.Enabled = false;
            }
            else
            {
                lbl_UnlockPassword.ForeColor = Color.Gray;
                panel_NewPassword.Enabled = true;
            }
        }

        private void rdb_LockPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_LockPassword.Checked)
            {
                ProtectUserByPassword = true;
                panel_NewPassword.Enabled = true;
                if (LoggedUser.UserPassword == null)
                {
                    lbl_CurrentPassword.Enabled = lbl_CurrentPassword.Visible = false;
                    txt_CurrentPassword.Enabled = txt_CurrentPassword.Visible = false;
                }
                else
                {
                    lbl_CurrentPassword.Enabled = lbl_CurrentPassword.Visible = true;
                    txt_CurrentPassword.Enabled = txt_CurrentPassword.Visible = true;
                }
                lbl_UnlockPassword.ForeColor = Color.Gray;
            }
            else
            {
                panel_NewPassword.Enabled = false;
                lbl_UnlockPassword.ForeColor = Color.Black;
            }
        }

        private void btn_MeSaveChanges_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            long UserID = LoggedUser.UserID;
            string ErrorMessage = String.Empty;

            if (!ProtectUserByPassword)
            {
                userController.UpdatePassword(LoggedUser.UserID, null);
                LoggedUser = userController.GetUserByID(UserID);
            }
            else
            {
                string CurrentPassword = SHA256.Hash(txt_CurrentPassword.Text);
                string NewPassword = txt_NewPassword.Text;
                string ReTypeNewPassword = txt_ReTypeNewPassword.Text;

                if (CurrentPassword != String.Empty || LoggedUser.UserPassword == null)
                    if (CurrentPassword == LoggedUser.UserPassword || LoggedUser.UserPassword == null)
                        if (NewPassword != String.Empty)
                            if (NewPassword.Equals(ReTypeNewPassword))
                            {
                                NewPassword = SHA256.Hash(NewPassword);
                                userController.UpdatePassword(LoggedUser.UserID, NewPassword);
                                LoggedUser = userController.GetUserByID(UserID);
                            }
                            else ErrorMessage = "The new passwords are not the same";
                        else ErrorMessage = "New password cannot be empty";
                    else ErrorMessage = "Current password do not match";
                else ErrorMessage = "Current password cannot be empty";
            }



            if (ErrorMessage == String.Empty)
            {
                txt_CurrentPassword.Clear();
                txt_NewPassword.Clear();
                txt_ReTypeNewPassword.Clear();
                PasswordSetStatus("You password has been successfully changed", false);
            }
            else
                PasswordSetStatus(ErrorMessage);
        }

        private void LoadPasswordSettings()
        {
            string UserPassword = LoggedUser.UserPassword;

            if (UserPassword == null) // No Password protection
            {
                rdb_UnlockPassword.Checked = true;
            }
            else // Password protected
            {
                rdb_LockPassword.Checked = true;
            }
        }

        private Font UsernameFont = new FontConverter().ConvertFromString("Roboto; 20,25pt") as Font;
        private void lbl_Username_FontChanged(object sender, EventArgs e)
        {
            lbl_Username.Font = UsernameFont;
        }

        private Font UserRoleFont = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
        private Color UserRoleColor = Color.Gray;
        private void lbl_UserRole_FontChanged(object sender, EventArgs e)
        {
            lbl_UserRole.Font = UserRoleFont;
            lbl_UserRole.ForeColor = UserRoleColor;
        }

        #endregion

        #region Users

        private void SetUsers()
        {
            listView_Users.Items.Clear();

            UserController userController = new UserController();
            List<UserModelDataTransferObject> users = userController.GetUsers();

            foreach (UserModelDataTransferObject user in users)
            {
                ListViewItem itemToAdd = new ListViewItem() { Text = user.UserName, Tag = user.UserID };
                string GroupName = String.Empty;

                if (user.IsAdministrator())
                    GroupName = "Administrator";
                else
                    GroupName = "User";

                if (user.UserPassword == null)
                    itemToAdd.ForeColor = Color.Gold;

                itemToAdd.Group = listView_Users.Groups[GroupName];
                listView_Users.Items.Add(itemToAdd);
            }

        }

        #endregion

        private void treeView_Menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView_Menu.SelectedNode.Name)
            {
                case ABOUT:
                    SetCurrentVersion();
                    DisplayMenuPanel(panel_About);
                    break;

                case ME:
                    SetMeUsername();
                    PasswordSetStatus(String.Empty);
                    LoadPasswordSettings();
                    DisplayMenuPanel(panel_Me);
                    break;

                case USERS:
                    SetUsers();
                    DisplayMenuPanel(panel_Users);
                    break;

                case DATABASE:
                    break;

                default:
                    break;
            }
        }

        private void materialContextMenuStrip_Users_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedUsers = listView_Users.SelectedItems.Count;

            if (SelectedUsers == 0) return;

            MaterialMessageBox.MessageBoxResult result = MaterialMessageBox.MessageBoxResult.None;
            result = MaterialMessageBox.Show("Are you sure you want to delete all " + SelectedUsers + " selected users?", "Easy Survey - Delete Users", MaterialMessageBox.MessageBoxButtons.YesNo, MaterialMessageBox.MessageBoxIcon.Warning);

            if (result == MaterialMessageBox.MessageBoxResult.Yes)
            {
                UserController userController = new UserController();

                foreach (ListViewItem item in listView_Users.SelectedItems)
                {

                }
            }
        }
    }
}
