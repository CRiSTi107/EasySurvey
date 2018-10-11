using EasySurvey.Controllers;
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
    public partial class Register : MaterialForm
    {
        public Register()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SetHorizontalMiddle(MaterialRaisedButton control)
        {
            control.Location = new Point(base.Width / 2 - control.Size.Width / 2, control.Location.Y);
        }

        private void SetStatus(string Status, bool IsWrong, bool AutoUpdateRegisterButton = true)
        {
            lbl_Status.Text = Status;
            if (IsWrong)
                lbl_Status.ForeColor = Color.Red;
            else
                lbl_Status.ForeColor = Color.Green;

            if (AutoUpdateRegisterButton)
                btn_Register.Enabled = !IsWrong;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            SetHorizontalMiddle(btn_Register);
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frm_Login.Show();
        }



        private void btn_BackToLogin_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            string Username = txt_Username.Text;

            UserController userController = new UserController();

            if (Username == String.Empty || Username.Trim() == String.Empty)
            {
                SetStatus("Username cannot be empty", true);
            }
            //else if (userController.Search(Username, false, 1).Count() > 0)
            //{
            //    SetStatus("Username already exists", true);
            //}
            else
            {
                SetStatus("Username is avabile", false);
            }
        }
    }
}
