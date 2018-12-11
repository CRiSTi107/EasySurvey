namespace EasySurvey
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.lbl_text = new MaterialSkin.Controls.MaterialLabel();
            this.btn_No = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_Yes = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_OK = new MaterialSkin.Controls.MaterialFlatButton();
            this.pic_Icon = new System.Windows.Forms.PictureBox();
            this.Divider_Menu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Cancel = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_text.Depth = 0;
            this.lbl_text.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_text.Location = new System.Drawing.Point(82, 74);
            this.lbl_text.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(329, 131);
            this.lbl_text.TabIndex = 16;
            this.lbl_text.Text = "Here goes your value of text argument.";
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_No
            // 
            this.btn_No.AutoSize = true;
            this.btn_No.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_No.Depth = 0;
            this.btn_No.Enabled = false;
            this.btn_No.Icon = null;
            this.btn_No.Location = new System.Drawing.Point(283, 230);
            this.btn_No.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_No.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_No.Name = "btn_No";
            this.btn_No.Primary = true;
            this.btn_No.Size = new System.Drawing.Size(40, 36);
            this.btn_No.TabIndex = 18;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Visible = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_Yes
            // 
            this.btn_Yes.AutoSize = true;
            this.btn_Yes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yes.Depth = 0;
            this.btn_Yes.Enabled = false;
            this.btn_Yes.Icon = null;
            this.btn_Yes.Location = new System.Drawing.Point(13, 229);
            this.btn_Yes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Yes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Primary = true;
            this.btn_Yes.Size = new System.Drawing.Size(45, 36);
            this.btn_Yes.TabIndex = 19;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Visible = false;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.AutoSize = true;
            this.btn_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.Depth = 0;
            this.btn_OK.Enabled = false;
            this.btn_OK.Icon = null;
            this.btn_OK.Location = new System.Drawing.Point(148, 229);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_OK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Primary = true;
            this.btn_OK.Size = new System.Drawing.Size(39, 36);
            this.btn_OK.TabIndex = 20;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Visible = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // pic_Icon
            // 
            this.pic_Icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_Icon.Location = new System.Drawing.Point(12, 109);
            this.pic_Icon.Name = "pic_Icon";
            this.pic_Icon.Size = new System.Drawing.Size(64, 64);
            this.pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Icon.TabIndex = 15;
            this.pic_Icon.TabStop = false;
            // 
            // Divider_Menu
            // 
            this.Divider_Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Divider_Menu.Depth = 0;
            this.Divider_Menu.Enabled = false;
            this.Divider_Menu.Icon = null;
            this.Divider_Menu.Location = new System.Drawing.Point(-2, 210);
            this.Divider_Menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider_Menu.Name = "Divider_Menu";
            this.Divider_Menu.Primary = true;
            this.Divider_Menu.Size = new System.Drawing.Size(460, 10);
            this.Divider_Menu.TabIndex = 23;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AutoSize = true;
            this.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Cancel.Depth = 0;
            this.btn_Cancel.Enabled = false;
            this.btn_Cancel.Icon = null;
            this.btn_Cancel.Location = new System.Drawing.Point(148, 230);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Primary = true;
            this.btn_Cancel.Size = new System.Drawing.Size(73, 36);
            this.btn_Cancel.TabIndex = 22;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.Divider_Menu);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.pic_Icon);
            this.Controls.Add(this.btn_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 280);
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Title";
            this.Load += new System.EventHandler(this.MsgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_Icon;
        private MaterialSkin.Controls.MaterialLabel lbl_text;
        private MaterialSkin.Controls.MaterialFlatButton btn_No;
        private MaterialSkin.Controls.MaterialFlatButton btn_Yes;
        private MaterialSkin.Controls.MaterialFlatButton btn_OK;
        private MaterialSkin.Controls.MaterialRaisedButton Divider_Menu;
        private MaterialSkin.Controls.MaterialFlatButton btn_Cancel;
    }
}