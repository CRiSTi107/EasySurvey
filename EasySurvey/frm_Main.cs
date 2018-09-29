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
            lbl_AutoComplete1.Text = txt_Username.Text + " 1";
            lbl_AutoComplete2.Text = txt_Username.Text + " 2";
            lbl_AutoComplete3.Text = txt_Username.Text + " 3";
            lbl_AutoComplete4.Text = txt_Username.Text + " 4";
            lbl_AutoComplete5.Text = txt_Username.Text + " 5";
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
                (sender as MaterialLabel).Visible = false;
            else
                (sender as MaterialLabel).Visible = true;
        }
    }
}
