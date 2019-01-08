using Installer.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Installer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            AddManyTo(MenuPanels, panel_Welcome, panel_License, panel_InstalationPath, panel_Finish);
        }

        private bool IsInstallationDone = false;
        private List<Panel> MenuPanels = new List<Panel>();
        private int _PanelIndex = 0;
        private int PanelIndex
        {
            get
            {
                return _PanelIndex;
            }
            set
            {
                UpdateButtons(value);
                _PanelIndex = value;
            }
        }

        private void UpdateButtons(int PageIndex)
        {
            if (PageIndex == 0)
            {
                btn_Back.Enabled = false;
                btn_Next.Enabled = true;
            }
            else if (PageIndex == MenuPanels.Count - 1) // last page index
            {
                btn_Back.Enabled = true;
                btn_Next.Enabled = false;
                if (IsInstallationDone)
                {
                    btn_Back.Enabled = btn_Back.Visible = false;
                    btn_Cancel.Enabled = btn_Cancel.Visible = false;
                    btn_Next.Enabled = btn_Next.Visible = true;
                    btn_Next.Text = "&Finish";
                }
            }
            else
            {
                btn_Back.Enabled = true;
                btn_Next.Enabled = true;
            }
        }

        private void DisplayMenuPanel(Panel PanelToDisplay)
        {
            foreach (Panel panel in MenuPanels)
            {
                if (panel.Equals(PanelToDisplay))
                {
                    panel.Visible = panel.Enabled = true;
                    panel.Dock = DockStyle.Top;
                }
                else
                    panel.Visible = panel.Enabled = false;
            }
        }

        private void AddManyTo<T>(List<T> ListToAdd, params T[] Panels) where T : Panel
        {
            for (int PanelIndex = 0; PanelIndex <= Panels.Length - 1; ++PanelIndex)
                ListToAdd.Add(Panels[PanelIndex]);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DisplayMenuPanel(panel_Welcome);
            PanelIndex = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            DisplayMenuPanel(MenuPanels[--PanelIndex]);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (IsInstallationDone)
            { base.Close(); return; }

            if (PanelIndex == MenuPanels.IndexOf(panel_InstalationPath))
            {
                if (txt_PathInstallation.Text == String.Empty)
                {
                    MessageBox.Show("Please choose a path where to install.", "Easy Survey - Choose path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // copy files to installation path

                    ResourceSet resources = Resources.ResourceManager.GetResourceSet(new System.Globalization.CultureInfo("en"), false, true);

                    IDictionaryEnumerator resourceList = resources.GetEnumerator();
                    while (resourceList.MoveNext())
                    {
                        string key = (string)resourceList.Key;
                        object value = resourceList.Value;
                    }

                    IsInstallationDone = true;
                }

            }

            DisplayMenuPanel(MenuPanels[++PanelIndex]);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsInstallationDone)
                if (MessageBox.Show("Are you sure you want to exit Easy Survey Installation?", "Easy Survey - Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
        }

        private void btn_PathInstallation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_ChoosePath.ShowDialog() == DialogResult.OK)
            {
                txt_PathInstallation.Text = folderBrowserDialog_ChoosePath.SelectedPath + "\\EasySurvey";
                txt_PathInstallation.Text = txt_PathInstallation.Text.Replace("\\\\", "\\");
            }
        }
    }
}
