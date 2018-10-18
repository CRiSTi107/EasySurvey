namespace EasySurvey
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_Username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_AutoComplete1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_AutoComplete2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_AutoComplete3 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_AutoComplete4 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel_Autocomplete = new System.Windows.Forms.Panel();
            this.lbl_Username = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Password = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_Status = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Register = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel_Autocomplete.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.Depth = 0;
            this.txt_Username.Hint = "";
            this.txt_Username.Location = new System.Drawing.Point(200, 129);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.SelectedText = "";
            this.txt_Username.SelectionLength = 0;
            this.txt_Username.SelectionStart = 0;
            this.txt_Username.Size = new System.Drawing.Size(349, 23);
            this.txt_Username.TabIndex = 0;
            this.txt_Username.TabStop = false;
            this.txt_Username.UseSystemPasswordChar = false;
            this.txt_Username.Enter += new System.EventHandler(this.txt_Username_Enter);
            this.txt_Username.Leave += new System.EventHandler(this.txt_Username_Leave);
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // lbl_AutoComplete1
            // 
            this.lbl_AutoComplete1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AutoComplete1.Depth = 0;
            this.lbl_AutoComplete1.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_AutoComplete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_AutoComplete1.Location = new System.Drawing.Point(-4, 0);
            this.lbl_AutoComplete1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_AutoComplete1.Name = "lbl_AutoComplete1";
            this.lbl_AutoComplete1.Size = new System.Drawing.Size(353, 22);
            this.lbl_AutoComplete1.TabIndex = 1;
            this.lbl_AutoComplete1.Visible = false;
            this.lbl_AutoComplete1.TextChanged += new System.EventHandler(this.lbl_AutoComplete_TextChanged);
            this.lbl_AutoComplete1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_AutoComplete_MouseClick);
            this.lbl_AutoComplete1.MouseEnter += new System.EventHandler(this.lbl_AutoComplete_MouseEnter);
            this.lbl_AutoComplete1.MouseLeave += new System.EventHandler(this.lbl_AutoComplete_MouseLeave);
            // 
            // lbl_AutoComplete2
            // 
            this.lbl_AutoComplete2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AutoComplete2.Depth = 0;
            this.lbl_AutoComplete2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_AutoComplete2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_AutoComplete2.Location = new System.Drawing.Point(-4, 22);
            this.lbl_AutoComplete2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_AutoComplete2.Name = "lbl_AutoComplete2";
            this.lbl_AutoComplete2.Size = new System.Drawing.Size(353, 22);
            this.lbl_AutoComplete2.TabIndex = 2;
            this.lbl_AutoComplete2.Visible = false;
            this.lbl_AutoComplete2.TextChanged += new System.EventHandler(this.lbl_AutoComplete_TextChanged);
            this.lbl_AutoComplete2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_AutoComplete_MouseClick);
            this.lbl_AutoComplete2.MouseEnter += new System.EventHandler(this.lbl_AutoComplete_MouseEnter);
            this.lbl_AutoComplete2.MouseLeave += new System.EventHandler(this.lbl_AutoComplete_MouseLeave);
            // 
            // lbl_AutoComplete3
            // 
            this.lbl_AutoComplete3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AutoComplete3.Depth = 0;
            this.lbl_AutoComplete3.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_AutoComplete3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_AutoComplete3.Location = new System.Drawing.Point(-4, 44);
            this.lbl_AutoComplete3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_AutoComplete3.Name = "lbl_AutoComplete3";
            this.lbl_AutoComplete3.Size = new System.Drawing.Size(353, 22);
            this.lbl_AutoComplete3.TabIndex = 3;
            this.lbl_AutoComplete3.Visible = false;
            this.lbl_AutoComplete3.TextChanged += new System.EventHandler(this.lbl_AutoComplete_TextChanged);
            this.lbl_AutoComplete3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_AutoComplete_MouseClick);
            this.lbl_AutoComplete3.MouseEnter += new System.EventHandler(this.lbl_AutoComplete_MouseEnter);
            this.lbl_AutoComplete3.MouseLeave += new System.EventHandler(this.lbl_AutoComplete_MouseLeave);
            // 
            // lbl_AutoComplete4
            // 
            this.lbl_AutoComplete4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AutoComplete4.Depth = 0;
            this.lbl_AutoComplete4.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_AutoComplete4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_AutoComplete4.Location = new System.Drawing.Point(-4, 66);
            this.lbl_AutoComplete4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_AutoComplete4.Name = "lbl_AutoComplete4";
            this.lbl_AutoComplete4.Size = new System.Drawing.Size(353, 22);
            this.lbl_AutoComplete4.TabIndex = 4;
            this.lbl_AutoComplete4.Visible = false;
            this.lbl_AutoComplete4.TextChanged += new System.EventHandler(this.lbl_AutoComplete_TextChanged);
            this.lbl_AutoComplete4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_AutoComplete_MouseClick);
            this.lbl_AutoComplete4.MouseEnter += new System.EventHandler(this.lbl_AutoComplete_MouseEnter);
            this.lbl_AutoComplete4.MouseLeave += new System.EventHandler(this.lbl_AutoComplete_MouseLeave);
            // 
            // txt_Password
            // 
            this.txt_Password.Depth = 0;
            this.txt_Password.Hint = "";
            this.txt_Password.Location = new System.Drawing.Point(200, 180);
            this.txt_Password.MaxLength = 32767;
            this.txt_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.Size = new System.Drawing.Size(349, 23);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.TabStop = false;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.Visible = false;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // panel_Autocomplete
            // 
            this.panel_Autocomplete.Controls.Add(this.lbl_AutoComplete1);
            this.panel_Autocomplete.Controls.Add(this.lbl_AutoComplete2);
            this.panel_Autocomplete.Controls.Add(this.lbl_AutoComplete3);
            this.panel_Autocomplete.Controls.Add(this.lbl_AutoComplete4);
            this.panel_Autocomplete.Location = new System.Drawing.Point(200, 155);
            this.panel_Autocomplete.Name = "panel_Autocomplete";
            this.panel_Autocomplete.Size = new System.Drawing.Size(349, 88);
            this.panel_Autocomplete.TabIndex = 7;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Depth = 0;
            this.lbl_Username.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Username.Location = new System.Drawing.Point(40, 133);
            this.lbl_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(70, 19);
            this.lbl_Username.TabIndex = 8;
            this.lbl_Username.Text = "Utilizator";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Depth = 0;
            this.lbl_Password.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Password.Location = new System.Drawing.Point(40, 180);
            this.lbl_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(52, 19);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Parola";
            this.lbl_Password.Visible = false;
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSize = true;
            this.btn_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Depth = 0;
            this.btn_Login.Icon = null;
            this.btn_Login.Location = new System.Drawing.Point(431, 253);
            this.btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Primary = true;
            this.btn_Login.Size = new System.Drawing.Size(118, 36);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Intra in cont";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
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
            this.lbl_Status.TabIndex = 11;
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Register
            // 
            this.btn_Register.AutoSize = true;
            this.btn_Register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Depth = 0;
            this.btn_Register.Icon = null;
            this.btn_Register.Location = new System.Drawing.Point(44, 253);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Register.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Primary = false;
            this.btn_Register.Size = new System.Drawing.Size(135, 36);
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "Creaza un cont";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 358);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.panel_Autocomplete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(579, 358);
            this.MinimumSize = new System.Drawing.Size(579, 358);
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Survey - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.VisibleChanged += new System.EventHandler(this.Login_VisibleChanged);
            this.panel_Autocomplete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Username;
        private MaterialSkin.Controls.MaterialLabel lbl_AutoComplete1;
        private MaterialSkin.Controls.MaterialLabel lbl_AutoComplete2;
        private MaterialSkin.Controls.MaterialLabel lbl_AutoComplete3;
        private MaterialSkin.Controls.MaterialLabel lbl_AutoComplete4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Password;
        private System.Windows.Forms.Panel panel_Autocomplete;
        private MaterialSkin.Controls.MaterialLabel lbl_Username;
        private MaterialSkin.Controls.MaterialLabel lbl_Password;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Login;
        private MaterialSkin.Controls.MaterialLabel lbl_Status;
        private MaterialSkin.Controls.MaterialFlatButton btn_Register;
    }
}

