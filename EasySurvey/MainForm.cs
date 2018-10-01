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

using System.Data.SQLite;
using System.Threading.Tasks;
using EasySurvey.Models;
using EasySurvey.Controller;

namespace EasySurvey
{
    public partial class MainForm : MaterialForm
    {
        private List<MaterialLabel> AutocompleteLabels = new List<MaterialLabel>();

        private List<UserModelDataTransferObject> Users = new List<UserModelDataTransferObject>();

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // GREY BLUE
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // LIGHT BLUE
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            // GREEN
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

            //Add Labels to Autocomplete List
            AutocompleteLabels.Add(lbl_AutoComplete1); AutocompleteLabels.Add(lbl_AutoComplete2); AutocompleteLabels.Add(lbl_AutoComplete3); AutocompleteLabels.Add(lbl_AutoComplete4); AutocompleteLabels.Add(lbl_AutoComplete5);
        }

        private List<UserModelDataTransferObject> GetUsers()
        {
            UserController userController = new UserController();
            return userController.GetUsers();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Users = GetUsers();

            //try
            //{
            //    using (var c = new DatabaseEntity())
            //    {
            //        foreach (var item in c.Question)
            //        {
            //            MessageBox.Show(item.Question1);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            bool hide = true;

            if (txt_Username.Text == "" || txt_Username.Text == String.Empty || txt_Username.Text.Trim() == String.Empty)
                hide = false;

            panel_Autocomplete.Visible = hide;


        }

        private void lbl_AutoComplete_MouseEnter(object sender, EventArgs e)
        {
            (sender as MaterialLabel).BackColor = Color.Gray;
        }

        private void lbl_AutoComplete_MouseLeave(object sender, EventArgs e)
        {
            (sender as MaterialLabel).BackColor = Color.Transparent;
        }

        private void lbl_AutoComplete_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Username.Text = (sender as MaterialLabel).Text;
        }

        private void lbl_AutoComplete_TextChanged(object sender, EventArgs e)
        {
            if ((sender as MaterialLabel).Text == String.Empty)
            { (sender as MaterialLabel).Visible = false; panel_Autocomplete.Visible = false; }
            else
            { (sender as MaterialLabel).Visible = true; panel_Autocomplete.Visible = true; }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SHA256.Hash(txt_Password.Text));
        }
    }
}
