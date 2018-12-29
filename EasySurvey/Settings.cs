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

            //Setting App Logo in middle.
            SetHorizontalMiddle(pic_EasySurveyLogo);
            SetHorizontalMiddle(pic_GitHub);
        }



        private void Settings_Load(object sender, EventArgs e)
        {
            SetCurrentVersion();
            SetMeUsername();

            if (LoggedUser.IsAdministrator())
            {
                AddManyTo(MenuPanels, panel_About, panel_Me);
            }
            else
            {
                AddManyTo(MenuPanels, panel_About, panel_Me);
            }
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

        #region About

        private void SetHorizontalMiddle<T>(T control) where T : PictureBox
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

        public struct MenuPanelsEnum
        {
            public const string ABOUT = "About";
            public const string ME = "Me";
            public const string USERS = "Users";
            public const string DATABASE = "Database";
        }


        private List<Panel> MenuPanels = new List<Panel>();

        #region Me

        private void SetMeUsername()
        {
            lbl_Username.Text = LoggedUser.UserName;
        }

        private void pic_UnlockPassword_Click(object sender, EventArgs e)
        {
            rdb_UnlockPassword.Checked = true;
        }

        private void pic_LockPassword_Click(object sender, EventArgs e)
        {
            rdb_LockPassword.Checked = true;
        }

        private void rdb_UnlockPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_LockPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void treeView_Menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView_Menu.SelectedNode.Name)
            {
                case MenuPanelsEnum.ABOUT:
                    DisplayMenuPanel(panel_About);
                    break;

                case MenuPanelsEnum.ME:
                    DisplayMenuPanel(panel_Me);
                    break;

                case MenuPanelsEnum.USERS:
                    break;

                case MenuPanelsEnum.DATABASE:
                    break;

                default:
                    break;
            }
        }


    }
}
