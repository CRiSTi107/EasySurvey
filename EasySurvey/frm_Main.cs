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

namespace EasySurvey
{
    public partial class frm_Main : MaterialForm
    {
        private List<MaterialLabel> AutocompleteLabels = new List<MaterialLabel>();

        public frm_Main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            // BLUE
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            // GREEN
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

            //Add Labels to Autocomplete List
            AutocompleteLabels.Add(lbl_AutoComplete1); AutocompleteLabels.Add(lbl_AutoComplete2); AutocompleteLabels.Add(lbl_AutoComplete3); AutocompleteLabels.Add(lbl_AutoComplete4); AutocompleteLabels.Add(lbl_AutoComplete5);
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=database.db;Version=3;"))
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Question", conn))
                {
                    conn.Open();

                    SQLiteDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        //MessageBox.Show(dr[1].ToString());
                    }

                    //MessageBox.Show("Connected successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            bool hide = true;

            if (txt_Username.Text == "" || txt_Username.Text == String.Empty || txt_Username.Text.Trim() == String.Empty)
                hide = false;

            panel1.Visible = (hide) ? true : false;
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
            { (sender as MaterialLabel).Visible = false; panel1.Visible = false; }
            else
            { (sender as MaterialLabel).Visible = true; panel1.Visible = true; }
        }
    }
}
