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
using System.IO.Compression;

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

        public void ByteArrayToFile(string fileName, byte[] byteArray)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                fs.Write(byteArray, 0, byteArray.Length);
            }
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
                    string InstallationFolder = txt_PathInstallation.Text;

                    //check if folder exists
                    if (!Directory.Exists(InstallationFolder))
                        Directory.CreateDirectory(InstallationFolder);

                    if (!InstallationFolder.EndsWith("\\"))
                        InstallationFolder += "\\";

                    // https://stackoverflow.com/questions/1581694/gzipstream-and-decompression
                    // GZipStream gzip = new GZipStream(null, CompressionMode.Decompress);

                    // copy files to installation path
                    ResourceSet resources = Resources.ResourceManager.GetResourceSet(new System.Globalization.CultureInfo("en"), false, true);
                    IDictionaryEnumerator resourceList = resources.GetEnumerator();
                    while (resourceList.MoveNext())
                    {
                        string file_name = (string)resourceList.Key;
                        //object value = resourceList.Value;
                        byte[] file_value = null;
                        if (resourceList.Value is byte[])
                            file_value = (byte[])resourceList.Value;

                        if (file_value == null)
                            continue;

                        if (file_name.StartsWith("instfile_"))
                            file_name = file_name.Replace("instfile_", "");

                        //Verify if this must be pun in a folder
                        if (file_name.StartsWith("x64_") || file_name.StartsWith("x86_"))
                        {
                            string folder = file_name.Substring(0, 3);
                            file_name = file_name.Remove(0, 4);
                            file_name = file_name.Replace("_", ".");

                            if (!Directory.Exists(InstallationFolder + folder))
                                Directory.CreateDirectory(InstallationFolder + folder);

                            ByteArrayToFile(InstallationFolder + folder + "\\" + file_name, file_value);
                        }
                        else // copy in installation directory
                        {
                            file_name = file_name.Replace("_", ".");
                            ByteArrayToFile(InstallationFolder + file_name, file_value);
                        }

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
