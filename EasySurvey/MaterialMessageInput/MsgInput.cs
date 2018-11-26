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
    public partial class MsgInput : MaterialForm
    {
        internal readonly MaterialSkinManager __materialSkinManager;

        public MsgInput(string text, string caption, MaterialMessageInput.MessageBoxButtonsInput buttons)
        {
            InitializeComponent();

            __materialSkinManager = MaterialSkinManager.Instance;
            __materialSkinManager.AddFormToManage(this);
            __materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            __materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            base.Text = caption;
            lbl_Text.Text = text;

            switch (buttons)
            {
                case MaterialMessageInput.MessageBoxButtonsInput.OKCancel: // For this we need only one type.
                    btn_OK.Visible = true;
                    btn_OK.Enabled = true;
                    btn_Cancel.Visible = true;
                    btn_Cancel.Enabled = true;
                    break;

                default:
                    break;
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

        private void MsgInput_Load(object sender, EventArgs e)
        {
            Divider_Menu.AutoSize = false;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MaterialMessageInput.Answer = txt_Answer.Text;
            MaterialMessageInput._Result = MaterialMessageInput.MessageBoxResultInput.OK;
            base.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MaterialMessageInput._Result = MaterialMessageInput.MessageBoxResultInput.Cancel;
            base.Close();
        }
    }
}
