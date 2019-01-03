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
using System.IO;
using System.Reflection;

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
            lbl_Info.ForeColor = Color.Red;

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

        private void SetHorizontalMiddle<T>(T control) where T : Control
        {
            control.Location = new Point(control.Parent.Width / 2 - control.Size.Width / 2, control.Location.Y);
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

        public const string ABOUT = "About";
        public const string ME = "Me";
        public const string USERS = "Users";
        public const string DATABASE = "Database";

        private List<Panel> MenuPanels = new List<Panel>();

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
                    DisplayMenuPanel(panel_Database);
                    break;

                default:
                    break;
            }
        }


        #region About

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
                    itemToAdd.ForeColor = Color.Red;

                itemToAdd.Group = listView_Users.Groups[GroupName];
                listView_Users.Items.Add(itemToAdd);
            }

        }

        private void lbl_Info_ForeColorChanged(object sender, EventArgs e)
        {
            lbl_Info.ForeColor = Color.Red;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedUsersCount = listView_Users.SelectedItems.Count;
            if (SelectedUsersCount == 0) return;

            IEnumerable<ListViewItem> SelectedUsers = listView_Users.SelectedItems.Cast<ListViewItem>();
            UserController userController = new UserController();
            RoleController roleController = new RoleController();

            // Check if Admin selected all Admins to be deleted.
            long AdminRoleID = roleController.GetRoleID("Admin");
            List<UserModelDataTransferObject> AdminsList = userController.GetUsersByRoleID(AdminRoleID);
            long AdminCount = AdminsList.Count;
            long SelectedAdminCount = 0;
            foreach (ListViewItem item in SelectedUsers)
            {
                long UserID = Convert.ToInt64(item.Tag);
                UserModelDataTransferObject SelectedUser = userController.GetUserByID(UserID);
                if (SelectedUser.IsAdministrator())
                    ++SelectedAdminCount;
            }
            if (AdminCount == SelectedAdminCount)
            {
                MaterialMessageBox.Show("You cannot delete all Administrators.", "Easy Survey - Delete Users", MaterialMessageBox.MessageBoxButtons.OK, MaterialMessageBox.MessageBoxIcon.Error);
                return;
            }

            // Check if Admin selected his account to de deleted.
            bool SelectedSelfAccount = false;
            foreach (ListViewItem item in SelectedUsers)
            {
                long UserID = Convert.ToInt64(item.Tag);
                if (LoggedUser.UserID == UserID)
                { SelectedSelfAccount = true; break; }
            }
            if (SelectedSelfAccount)
            {
                MaterialMessageBox.Show("You cannot delete your own account.", "Easy Survey - Delete Users", MaterialMessageBox.MessageBoxButtons.OK, MaterialMessageBox.MessageBoxIcon.Error);
                return;
            }

            // Delete selected users.
            MaterialMessageBox.MessageBoxResult result = MaterialMessageBox.MessageBoxResult.None;
            result = MaterialMessageBox.Show("Are you sure you want to delete all " + SelectedUsersCount + " selected users?", "Easy Survey - Delete Users", MaterialMessageBox.MessageBoxButtons.YesNo, MaterialMessageBox.MessageBoxIcon.Warning);

            if (result == MaterialMessageBox.MessageBoxResult.Yes)
            {
                foreach (ListViewItem item in SelectedUsers)
                {
                    long UserID = Convert.ToInt64(item.Tag);

                    // Delete from Database
                    userController.Delete(UserID);

                    // Delete from ListView
                    foreach (ListViewItem listViewItemToDelete in listView_Users.SelectedItems)
                    {
                        long ListViewUserID = Convert.ToInt64(listViewItemToDelete.Tag);
                        if (UserID == ListViewUserID)
                            listView_Users.Items.Remove(listViewItemToDelete);
                    }
                }
            }
        }

        private void materialContextMenuStrip_Users_Opening(object sender, CancelEventArgs e)
        {
            long SelectedUsers = listView_Users.SelectedItems.Count;

            UserController userController = new UserController();

            // Promote / Demote ...
            bool Promote = false;
            bool Demote = false;

            foreach (ListViewItem item in listView_Users.SelectedItems)
            {
                long UserID = Convert.ToInt64(item.Tag);
                UserModelDataTransferObject CurrentUser = userController.GetUserByID(UserID);
                if (CurrentUser.IsAdministrator())
                    Demote = true;
                else
                    Promote = true;
            }

            if (Promote == Demote)
            {
                promoteDemoteToolStripMenuItem.Enabled = false;
                promoteDemoteToolStripMenuItem.Text = "Promote / Demote...";
            }
            else
            {
                promoteDemoteToolStripMenuItem.Enabled = true;
                if (Promote)
                {
                    promoteDemoteToolStripMenuItem.Image = Properties.Resources.promote_icon_16x16;
                    promoteDemoteToolStripMenuItem.Text = "Promote...";
                }
                else if (Demote)
                {
                    promoteDemoteToolStripMenuItem.Image = Properties.Resources.demote_icon_16x16;
                    promoteDemoteToolStripMenuItem.Text = "Demote...";
                }
            }

            // Change / New ...
            bool Change = false;
            bool New = false;

            if (SelectedUsers == 0) return;

            foreach (ListViewItem item in listView_Users.SelectedItems)
            {
                long UserID = Convert.ToInt64(item.Tag);
                UserModelDataTransferObject CurrentUser = userController.GetUserByID(UserID);
                if (CurrentUser.UserPassword == null)
                    New = true;
                else
                    Change = true;
            }

            if (Change && New)
                newToolStripMenuItem.Text = "Change / New...";
            else if (Change)
                newToolStripMenuItem.Text = "Change...";
            else if (New)
                newToolStripMenuItem.Text = "New...";

        }

        // Remove password protection
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedUsersCount = listView_Users.SelectedItems.Count;

            if (SelectedUsersCount == 0) return;

            MaterialMessageBox.MessageBoxResult result = MaterialMessageBox.MessageBoxResult.None;
            result = MaterialMessageBox.Show("Are you sure you want to remove password protection for all selected users?", "Easy Survey - Manage Users", MaterialMessageBox.MessageBoxButtons.YesNo, MaterialMessageBox.MessageBoxIcon.Information);

            UserController userController = new UserController();

            if (result == MaterialMessageBox.MessageBoxResult.Yes)
            {
                foreach (ListViewItem item in listView_Users.SelectedItems)
                {
                    long UserID = Convert.ToInt64(item.Tag);
                    userController.UpdatePassword(UserID, null);
                    item.ForeColor = Color.Red;
                }
            }
        }

        // Change / New password protection
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long SelectedUsers = listView_Users.SelectedItems.Count;

            if (SelectedUsers == 0) return;

            MaterialMessageInput.MessageBoxResultInput result = MaterialMessageInput.MessageBoxResultInput.None;
            result = MaterialMessageInput.Show("New password for " + SelectedUsers + " selected users is:",
                                               "Easy Survey - Change Users Password",
                                               MaterialMessageInput.MessageBoxButtonsInput.OKCancel,
                                               isPassword: true);

            if (result == MaterialMessageInput.MessageBoxResultInput.OK)
            {
                UserController userController = new UserController();

                string NewPlainPassword = MaterialMessageInput.Answer;
                string NewPassword = SHA256.Hash(NewPlainPassword);

                foreach (ListViewItem item in listView_Users.SelectedItems)
                {
                    long UserID = Convert.ToInt64(item.Tag);
                    userController.UpdatePassword(UserID, NewPassword);
                    item.ForeColor = Color.Black;
                }
            }
        }

        // Promote / Demote users
        private void promoteDemoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedUsersCount = listView_Users.SelectedItems.Count;
            if (SelectedUsersCount == 0) return;


            UserController userController = new UserController();
            RoleController roleController = new RoleController();

            long AdminRoleID = roleController.GetRoleID("Admin");
            long UserRoleID = roleController.GetRoleID("User");


            // Check if Admin want to demote all Admins
            List<UserModelDataTransferObject> AdminsList = userController.GetUsersByRoleID(AdminRoleID);
            long AdminCount = AdminsList.Count;
            long SelectedAdminCount = 0;

            foreach (ListViewItem item in listView_Users.SelectedItems)
            {
                long UserID = Convert.ToInt64(item.Tag);
                UserModelDataTransferObject CurrentUser = userController.GetUserByID(UserID);
                if (CurrentUser.IsAdministrator())
                    ++SelectedAdminCount;
            }

            if (AdminCount == SelectedAdminCount && AdminCount == listView_Users.SelectedItems.Count)
            {
                MaterialMessageBox.Show("You cannot demote all Administrators.", "Easy Survey - Demote Users", MaterialMessageBox.MessageBoxButtons.OK, MaterialMessageBox.MessageBoxIcon.Error);
                return;
            }


            // Check if Admin wants to demote himself
            bool AdminSelectedHimself = false;
            foreach (ListViewItem item in listView_Users.SelectedItems)
            {
                long UserID = Convert.ToInt64(item.Tag);
                if (LoggedUser.UserID == UserID)
                { AdminSelectedHimself = true; break; }
            }
            if (AdminSelectedHimself)
            {
                MaterialMessageBox.Show("You cannot demote yourself.", "Easy Survey - Demote Users", MaterialMessageBox.MessageBoxButtons.OK, MaterialMessageBox.MessageBoxIcon.Error);
                return;
            }

            // Demote / Promote selected users.
            UserRoleController userRoleController = new UserRoleController();

            foreach (ListViewItem item in listView_Users.SelectedItems)
            {
                long UserID = Convert.ToInt64(item.Tag);
                UserModelDataTransferObject CurrentUser = userController.GetUserByID(UserID);
                if (CurrentUser.IsAdministrator()) // Demote to standard user.
                {
                    userRoleController.SetUserRole(UserID, UserRoleID);
                    item.Group = listView_Users.Groups["User"];
                }
                else if (!CurrentUser.IsAdministrator()) // Promote to admin.
                {
                    userRoleController.SetUserRole(UserID, AdminRoleID);
                    item.Group = listView_Users.Groups["Administrator"];
                }

            }
        }

        #endregion

        #region Database

        private const string BACKUP = "Backup";
        private const string RESTORE = "Restore";
        private const string EXPORT = "Export";
        private const string IMPORT = "Import";

        private void pic_DatabaseMenu_MouseEnter(object sender, EventArgs e)
        {
            PictureBox SenderControl = (sender as PictureBox);
            string SenderTag = SenderControl.Tag.ToString();
            switch (SenderTag)
            {
                case BACKUP:
                    SenderControl.BackgroundImage = Properties.Resources.backup_icon_mouse_enter_512x512;
                    break;

                case RESTORE:
                    SenderControl.BackgroundImage = Properties.Resources.restore_icon_mouse_enter_512x512;
                    break;

                case EXPORT:
                    SenderControl.BackgroundImage = Properties.Resources.export_icon_mouse_enter_512x512;
                    break;

                case IMPORT:
                    SenderControl.BackgroundImage = Properties.Resources.import_icon_mouse_enter_512x512;
                    break;

                default:
                    break;
            }
        }

        private void pic_DatabaseMenu_MouseLeave(object sender, EventArgs e)
        {
            Control SenderControl = (sender as PictureBox);
            string SenderTag = SenderControl.Tag.ToString();
            switch (SenderTag)
            {
                case BACKUP:
                    SenderControl.BackgroundImage = Properties.Resources.backup_icon_512x512;
                    break;

                case RESTORE:
                    SenderControl.BackgroundImage = Properties.Resources.restore_icon_512x512;
                    break;

                case EXPORT:
                    SenderControl.BackgroundImage = Properties.Resources.export_icon_512x512;
                    break;

                case IMPORT:
                    SenderControl.BackgroundImage = Properties.Resources.import_icon_512x512;
                    break;

                default:
                    break;
            }
        }

        private void pic_Backup_Click(object sender, EventArgs e)
        {
            Database DB = new Database();
            string DatabaseBackupName = DB.Backup(Database.BackupReason.User);

            MaterialMessageBox.Show("Backup has been saved with name " + DatabaseBackupName, "Easy Survey - Database backup", MaterialMessageBox.MessageBoxButtons.OK, MaterialMessageBox.MessageBoxIcon.Information);
        }

        private void pic_Restore_Click(object sender, EventArgs e)
        {
            string AppPath = Assembly.GetExecutingAssembly().Location;
            string DirectoryApp = Path.GetDirectoryName(AppPath);
            string BackupDirectory = DirectoryApp + "\\backup";

            openFileDialog_Restore.InitialDirectory = BackupDirectory;

            DialogResult Result = openFileDialog_Restore.ShowDialog();

            Database DB = new Database();

            if (Result == DialogResult.OK)
            {
                string RestoreBackupPath = openFileDialog_Restore.FileName;
                DB.Restore(RestoreBackupPath);
                MaterialMessageBox.Show("Database Backup has been restored successfully!" + Environment.NewLine + "You will be redirecte to Login Page.", "Easy Survey - Database Restore", MaterialMessageBox.MessageBoxButtons.OK, MaterialMessageBox.MessageBoxIcon.Information);
                Program.frm_MainForm.Close();
                base.Close();
            }
        }

        private void pic_Export_Click(object sender, EventArgs e)
        {
            Database DB = new Database();
            string DatabaseExportName = DB.Export();

            MaterialMessageBox.Show("Database has been exported with name " + DatabaseExportName, "Easy Survey - Database export", MaterialMessageBox.MessageBoxButtons.OK, MaterialMessageBox.MessageBoxIcon.Information);
        }

        private void pic_Import_Click(object sender, EventArgs e)
        {
            openFileDialog_Import.InitialDirectory = SpecialDirectories.MyComputer;

            DialogResult Result = openFileDialog_Import.ShowDialog();

            Database DB = new Database();

            if (Result == DialogResult.OK)
            {
                string ImportDatabasePath = openFileDialog_Import.FileName;
                ImportDatabasePath = Path.GetFullPath(ImportDatabasePath);
                DB.Import(ImportDatabasePath);
                MaterialMessageBox.Show("Database has been imported successfully!" + Environment.NewLine + "You will be redirecte to Login Page.", "Easy Survey - Database Import", MaterialMessageBox.MessageBoxButtons.OK, MaterialMessageBox.MessageBoxIcon.Information);
                Program.frm_MainForm.Close();
                base.Close();
            }
        }

        #endregion

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Program.frm_MainForm.IsDisposed)
                Program.frm_MainForm.Show();
        }


    }
}
