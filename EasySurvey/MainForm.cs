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
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 499; i++)
            {
                listView1.Items.Add(new ListViewItem("Test de inteligenta pentru avansati - " + i.ToString(), listView1.Groups["listViewGroup4"]));
                //materialListView1.Items.Add(new ListViewItem("Survey - " + i.ToString(), listView1.Groups["listViewGroup4"]));
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frm_Login.Show();
        }
    }
}
