namespace EasySurvey
{
    partial class MsgInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgInput));
            this.lbl_Text = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Answer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_OK = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_Cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.Divider_Menu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbl_Text
            // 
            this.lbl_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Text.Depth = 0;
            this.lbl_Text.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Text.Location = new System.Drawing.Point(16, 76);
            this.lbl_Text.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(504, 60);
            this.lbl_Text.TabIndex = 0;
            this.lbl_Text.Text = "Here goes your question? . . . . .. . . . . . . . . . . .  .. . . . . . . . . . ." +
    " . .  . . . . . . . . . . .. . ";
            // 
            // txt_Answer
            // 
            this.txt_Answer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Answer.Depth = 0;
            this.txt_Answer.Hint = "";
            this.txt_Answer.Location = new System.Drawing.Point(16, 148);
            this.txt_Answer.MaxLength = 32767;
            this.txt_Answer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.PasswordChar = '\0';
            this.txt_Answer.SelectedText = "";
            this.txt_Answer.SelectionLength = 0;
            this.txt_Answer.SelectionStart = 0;
            this.txt_Answer.Size = new System.Drawing.Size(504, 23);
            this.txt_Answer.TabIndex = 1;
            this.txt_Answer.TabStop = false;
            this.txt_Answer.UseSystemPasswordChar = false;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_OK.AutoSize = true;
            this.btn_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.Depth = 0;
            this.btn_OK.Enabled = false;
            this.btn_OK.Icon = null;
            this.btn_OK.Location = new System.Drawing.Point(20, 207);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_OK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Primary = true;
            this.btn_OK.Size = new System.Drawing.Size(39, 36);
            this.btn_OK.TabIndex = 19;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Visible = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.AutoSize = true;
            this.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Depth = 0;
            this.btn_Cancel.Enabled = false;
            this.btn_Cancel.Icon = null;
            this.btn_Cancel.Location = new System.Drawing.Point(447, 207);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Primary = true;
            this.btn_Cancel.Size = new System.Drawing.Size(73, 36);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Divider_Menu
            // 
            this.Divider_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divider_Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Divider_Menu.Depth = 0;
            this.Divider_Menu.Icon = null;
            this.Divider_Menu.Location = new System.Drawing.Point(-5, 188);
            this.Divider_Menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider_Menu.Name = "Divider_Menu";
            this.Divider_Menu.Primary = true;
            this.Divider_Menu.Size = new System.Drawing.Size(558, 10);
            this.Divider_Menu.TabIndex = 24;
            // 
            // MsgInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 257);
            this.Controls.Add(this.Divider_Menu);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.lbl_Text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(542, 257);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(542, 257);
            this.Name = "MsgInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgInput";
            this.Load += new System.EventHandler(this.MsgInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_Text;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Answer;
        private MaterialSkin.Controls.MaterialFlatButton btn_OK;
        private MaterialSkin.Controls.MaterialFlatButton btn_Cancel;
        private MaterialSkin.Controls.MaterialRaisedButton Divider_Menu;
    }
}