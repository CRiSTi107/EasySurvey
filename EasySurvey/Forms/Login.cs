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
using EasySurvey.Controllers;

namespace EasySurvey
{
    public partial class Login : MaterialForm
    {
        private List<MaterialLabel> AutocompleteLabels = new List<MaterialLabel>();

        private List<UserModelDataTransferObject> Users = new List<UserModelDataTransferObject>();
        private List<UserModelDataTransferObject> SearchUsers = new List<UserModelDataTransferObject>();
        private bool RequiresPassword = false;

        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            //Add Labels to Autocomplete List
            AutocompleteLabels.Add(lbl_AutoComplete1); AutocompleteLabels.Add(lbl_AutoComplete2); AutocompleteLabels.Add(lbl_AutoComplete3); AutocompleteLabels.Add(lbl_AutoComplete4);

            //Create Desktop Shortcut
            Shortcut.CreateDesktopShortcut();
        }

        private List<UserModelDataTransferObject> GetUsers()
        {
            using (UserController userController = new UserController())
                return userController.GetUsers();
        }

        private void ClearCredentials(bool clearStatus = true)
        {
            txt_Username.Clear();
            txt_Password.Clear();
            if (clearStatus)
                lbl_Status.Text = String.Empty;
        }

        private void HidePasswordField()
        {
            pic_Password.Visible = false;
            lbl_Password.Visible = false;
            txt_Password.Visible = false;
            txt_Password.Enabled = false;
            txt_Password.Clear();
        }

        private void ShowPasswordField()
        {
            pic_Password.Visible = true;
            lbl_Password.Visible = true;
            txt_Password.Visible = true;
            txt_Password.Enabled = true;
            txt_Password.Clear();
        }

        private void SetHorizontalMiddle(MaterialRaisedButton control)
        {
            control.Location = new Point(base.Width / 2 - control.Size.Width / 2, control.Location.Y);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Users = GetUsers();
            SetHorizontalMiddle(btn_Login);

            try
            {
                Updater updater = new Updater();
                updater.CheckForUpdates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            using (UserController userController = new UserController())
            {
                string Username = txt_Username.Text;
                SearchUsers = new List<UserModelDataTransferObject>(userController.Search(Users, Username));

                int index = 0;
                foreach (var elem in SearchUsers)
                {
                    AutocompleteLabels[index++].Text = elem.UserName;
                }
                for (; index <= AutocompleteLabels.Count - 1; index++)
                    AutocompleteLabels[index].Text = String.Empty;

                HidePasswordField();

                if (SearchUsers.Count == 1 && SearchUsers.First().UserName.ToLower() == Username.ToLower())
                {
                    txt_Password.Clear();
                }

                if (userController.Exists(Username) != null)
                {
                    if (SearchUsers.First().UserPassword != null)
                    { RequiresPassword = true; }
                    else
                    { RequiresPassword = false; }
                }

            }
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
            foreach (var elem in AutocompleteLabels)
                elem.Text = String.Empty;
            if (txt_Password.Visible)
                txt_Password.Focus();
            else
                btn_Login.Focus();
        }

        private void lbl_AutoComplete_TextChanged(object sender, EventArgs e)
        {
            if ((sender as MaterialLabel).Text == String.Empty)
            { (sender as MaterialLabel).Visible = false; /*panel_Autocomplete.Visible = false;*/ }
            else
            { (sender as MaterialLabel).Visible = true; /*panel_Autocomplete.Visible = true;*/ }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            using (UserController userController = new UserController())
            {
                string Username = txt_Username.Text;
                string Password = txt_Password.Text;

                User user = userController.Login(Username, (RequiresPassword) ? Password : null);

                if (user != null)
                {
                    ClearCredentials();

                    lbl_Password.Visible = false;
                    txt_Password.Visible = false;

                    lbl_Status.Text = String.Empty;

                    UserModelDataTransferObject User = userController.GetUserByID(user.UserID);

                    // Move to MainForm
                    Program.frm_Login.Hide();
                    Program.frm_MainForm = new MainForm(User);
                    Program.frm_MainForm.Show();
                }
                else
                {
                    lbl_Status.Text = "Utilizatorul si parola nu se potrivesc.";
                    lbl_Status.ForeColor = Color.Red;

                    txt_Password.Clear();
                }

            }
        }

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            panel_Autocomplete.Visible = true;
            HidePasswordField();
            txt_Username.Focus();
            if (txt_Username.Text != String.Empty)
                txt_Username_TextChanged(sender, e);
        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            panel_Autocomplete.Visible = false;

            using (UserController userController = new UserController())
                if (userController.Exists(txt_Username.Text) != null)

                    if (RequiresPassword)
                    {
                        ShowPasswordField();
                        txt_Password.Focus();
                    }
                    else if (!RequiresPassword)
                    {
                        HidePasswordField();
                    }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Login.PerformClick();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Program.frm_Login.Hide();

            ClearCredentials();

            if (Program.frm_Register != null)
            {
                if (Program.frm_Register.IsDisposed)
                    Program.frm_Register = new Register();
            }
            else
            {
                Program.frm_Register = new Register();
            }

            Program.frm_Register.Show();
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (base.Visible)
                Users = GetUsers();
        }
    }
}
