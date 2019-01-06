using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Installer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            AddManyTo(MenuPanels, panel_Welcome, panel_License, panel_InstalationPath);
        }

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
            DisplayMenuPanel(MenuPanels[++PanelIndex]);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
