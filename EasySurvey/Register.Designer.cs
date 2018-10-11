namespace EasySurvey
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lbl_Username = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_BackToLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_Status = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Register = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_ChooseUsername = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Depth = 0;
            this.lbl_Username.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Username.Location = new System.Drawing.Point(40, 168);
            this.lbl_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(70, 19);
            this.lbl_Username.TabIndex = 10;
            this.lbl_Username.Text = "Utilizator";
            // 
            // txt_Username
            // 
            this.txt_Username.Depth = 0;
            this.txt_Username.Hint = "";
            this.txt_Username.Location = new System.Drawing.Point(200, 164);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.SelectedText = "";
            this.txt_Username.SelectionLength = 0;
            this.txt_Username.SelectionStart = 0;
            this.txt_Username.Size = new System.Drawing.Size(349, 23);
            this.txt_Username.TabIndex = 9;
            this.txt_Username.TabStop = false;
            this.txt_Username.UseSystemPasswordChar = false;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // btn_BackToLogin
            // 
            this.btn_BackToLogin.AutoSize = true;
            this.btn_BackToLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_BackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BackToLogin.Depth = 0;
            this.btn_BackToLogin.Icon = null;
            this.btn_BackToLogin.Location = new System.Drawing.Point(44, 253);
            this.btn_BackToLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_BackToLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_BackToLogin.Name = "btn_BackToLogin";
            this.btn_BackToLogin.Primary = false;
            this.btn_BackToLogin.Size = new System.Drawing.Size(84, 36);
            this.btn_BackToLogin.TabIndex = 15;
            this.btn_BackToLogin.Text = "← Inapoi";
            this.btn_BackToLogin.UseVisualStyleBackColor = true;
            this.btn_BackToLogin.Click += new System.EventHandler(this.btn_BackToLogin_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.Depth = 0;
            this.lbl_Status.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Status.Location = new System.Drawing.Point(12, 309);
            this.lbl_Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(555, 40);
            this.lbl_Status.TabIndex = 14;
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Register
            // 
            this.btn_Register.AutoSize = true;
            this.btn_Register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Depth = 0;
            this.btn_Register.Icon = null;
            this.btn_Register.Location = new System.Drawing.Point(414, 253);
            this.btn_Register.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Primary = true;
            this.btn_Register.Size = new System.Drawing.Size(135, 36);
            this.btn_Register.TabIndex = 13;
            this.btn_Register.Text = "Creaza un cont";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // lbl_ChooseUsername
            // 
            this.lbl_ChooseUsername.AutoSize = true;
            this.lbl_ChooseUsername.Depth = 0;
            this.lbl_ChooseUsername.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_ChooseUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ChooseUsername.Location = new System.Drawing.Point(40, 88);
            this.lbl_ChooseUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ChooseUsername.Name = "lbl_ChooseUsername";
            this.lbl_ChooseUsername.Size = new System.Drawing.Size(223, 19);
            this.lbl_ChooseUsername.TabIndex = 16;
            this.lbl_ChooseUsername.Text = "Alegeti-va un nume de utilizator.";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 358);
            this.Controls.Add(this.lbl_ChooseUsername);
            this.Controls.Add(this.btn_BackToLogin);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Survey - Create Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_Username;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Username;
        private MaterialSkin.Controls.MaterialFlatButton btn_BackToLogin;
        private MaterialSkin.Controls.MaterialLabel lbl_Status;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Register;
        private MaterialSkin.Controls.MaterialLabel lbl_ChooseUsername;
    }
}