using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Media;

namespace EasySurvey
{
    public partial class MsgBox : MaterialForm
    {
        internal readonly MaterialSkinManager __materialSkinManager;

        public MsgBox(string text, string caption, MaterialMessageBox.MessageBoxButtons buttons, MaterialMessageBox.MessageBoxIcon icon)
        {
            InitializeComponent();

            __materialSkinManager = MaterialSkinManager.Instance;
            __materialSkinManager.AddFormToManage(this);
            __materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            __materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            btn_No.AutoSize = false;
            btn_OK.AutoSize = false;
            btn_Yes.AutoSize = false;
            btn_Cancel.AutoSize = false;

            btn_No.Size = new Size(127, 36);
            btn_OK.Size = new Size(127, 36);
            btn_Yes.Size = new Size(127, 36);
            btn_Cancel.Size = new Size(127, 36);

            base.Text = caption;
            lbl_text.Text = text;

            switch (buttons)
            {
                case MaterialMessageBox.MessageBoxButtons.OK:
                    btn_OK.Visible = true; btn_OK.Enabled = true;

                    btn_OK.Location = new Point(base.Size.Width / 2 - btn_OK.Size.Width / 2, btn_OK.Location.Y);

                    btn_Yes.Visible = false; btn_Yes.Enabled = false;
                    btn_No.Visible = false; btn_No.Enabled = false;
                    btn_Cancel.Visible = false; btn_Cancel.Enabled = false;
                    break;

                case MaterialMessageBox.MessageBoxButtons.YesNo:
                    btn_Yes.Visible = true; btn_Yes.Enabled = true;
                    btn_No.Visible = true; btn_No.Enabled = true;

                    btn_OK.Visible = false; btn_OK.Enabled = false;
                    btn_Cancel.Enabled = false; btn_Cancel.Visible = false;

                    break;

                case MaterialMessageBox.MessageBoxButtons.YesNoCancel:
                    btn_Yes.Visible = true; btn_Yes.Enabled = true;
                    btn_Cancel.Enabled = true; btn_Cancel.Visible = true;
                    btn_No.Visible = true; btn_No.Enabled = true;
                    break;

                default: break;
            }

            switch (icon)
            {
                case MaterialMessageBox.MessageBoxIcon.Error:
                    pic_Icon.Image = Properties.Resources.icon_error_64x64;
                    SystemSounds.Hand.Play();
                    break;

                case MaterialMessageBox.MessageBoxIcon.Information:
                    pic_Icon.Image = Properties.Resources.icon_information_64x64;
                    SystemSounds.Asterisk.Play();
                    break;

                case MaterialMessageBox.MessageBoxIcon.None:
                    pic_Icon.Dispose();
                    lbl_text.Location = new Point(12, 74);
                    lbl_text.Size = new Size(399, 131);
                    break;

                case MaterialMessageBox.MessageBoxIcon.Question:
                    pic_Icon.Image = Properties.Resources.icon_question_64x64;
                    SystemSounds.Question.Play();
                    break;

                case MaterialMessageBox.MessageBoxIcon.Warning:
                    pic_Icon.Image = Properties.Resources.icon_warning_64x64;
                    SystemSounds.Exclamation.Play();
                    break;

                default: break;

            }

        }

        #region Shade the form
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion

        private void MsgBox_Load(object sender, EventArgs e)
        {
            Divider_Menu.AutoSize = false;
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            MaterialMessageBox._Result = MaterialMessageBox.MessageBoxResult.Yes;
            base.Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            MaterialMessageBox._Result = MaterialMessageBox.MessageBoxResult.No;
            base.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MaterialMessageBox._Result = MaterialMessageBox.MessageBoxResult.OK;
            base.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MaterialMessageBox._Result = MaterialMessageBox.MessageBoxResult.Cancel;
            base.Close();
        }
    }
}
