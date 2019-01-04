using EasySurvey.Controllers;
using EasySurvey.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

        private KeyValuePair<bool, string> Validate(string Username)
        {
            KeyValuePair<bool, string> validation = new KeyValuePair<bool, string>(false, "Username is avabile");

            using (UserController userController = new UserController())
                if (Username == String.Empty || Username.Trim() == String.Empty)
                    validation = new KeyValuePair<bool, string>(true, "Username cannot be empty");
                else if (Username.Length <= 2)
                    validation = new KeyValuePair<bool, string>(true, "Username must be atleast 3 characters long");
                else if (Username.First() == ' ' || Username.Last() == ' ')
                    validation = new KeyValuePair<bool, string>(true, "Username cannot start/end with a space");
                else if (new Regex(@"\s{2,}").IsMatch(Username))
                    validation = new KeyValuePair<bool, string>(true, "Username cannot contain more than 2 consecutive spaces");
                else if (userController.Exists(Username) != null)
                    validation = new KeyValuePair<bool, string>(true, "Username already exists");

            return validation;
        }

        private void btn_BackToLogin_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string Username = txt_Username.Text;

            //txt_Username_TextChanged(sender, e);

            using (UserController userController = new UserController())
                if (userController.AddUser(Username))
                { MessageBox.Show("Account succesfully created!", "Easy Survey - Register", MessageBoxButtons.OK, MessageBoxIcon.Information); base.Close(); }
                else
                { MessageBox.Show("Could not create user", "Easy Survey - Register", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            string Username = txt_Username.Text;

            KeyValuePair<bool, string> userValidate = Validate(Username);

            int LastPosition = txt_Username.SelectionStart;
            txt_Username.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Username.ToLower());
            SetStatus(userValidate.Value, userValidate.Key);
            txt_Username.SelectionStart = LastPosition;
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Register.PerformClick();
        }
    }
}
