namespace EasySurvey
{
    partial class MsgComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgComboBox));
            this.lbl_Status = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_OK = new MaterialSkin.Controls.MaterialFlatButton();
            this.Divider_Menu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_Text = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_Answer1 = new System.Windows.Forms.ComboBox();
            this.cmb_Answer2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Status.Depth = 0;
            this.lbl_Status.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Status.Location = new System.Drawing.Point(66, 207);
            this.lbl_Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(374, 36);
            this.lbl_Status.TabIndex = 28;
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Cancel.TabIndex = 27;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
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
            this.btn_OK.TabIndex = 26;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Visible = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // Divider_Menu
            // 
            this.Divider_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divider_Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Divider_Menu.Depth = 0;
            this.Divider_Menu.Icon = null;
            this.Divider_Menu.Location = new System.Drawing.Point(-12, 188);
            this.Divider_Menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider_Menu.Name = "Divider_Menu";
            this.Divider_Menu.Primary = true;
            this.Divider_Menu.Size = new System.Drawing.Size(568, 10);
            this.Divider_Menu.TabIndex = 29;
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
            this.lbl_Text.Size = new System.Drawing.Size(504, 40);
            this.lbl_Text.TabIndex = 30;
            this.lbl_Text.Text = "Here goes your question? . . . . .. . . . . . . . . . . .  .. . . . . . . . . . ." +
    " . .  . . . . . . . . . . .. . ";
            // 
            // cmb_Answer1
            // 
            this.cmb_Answer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Answer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Answer1.Font = new System.Drawing.Font("Roboto", 11F);
            this.cmb_Answer1.FormattingEnabled = true;
            this.cmb_Answer1.Location = new System.Drawing.Point(20, 119);
            this.cmb_Answer1.Name = "cmb_Answer1";
            this.cmb_Answer1.Size = new System.Drawing.Size(500, 27);
            this.cmb_Answer1.TabIndex = 31;
            this.cmb_Answer1.SelectedIndexChanged += new System.EventHandler(this.cmb_Answer1_SelectedIndexChanged);
            // 
            // cmb_Answer2
            // 
            this.cmb_Answer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Answer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Answer2.Font = new System.Drawing.Font("Roboto", 11F);
            this.cmb_Answer2.FormattingEnabled = true;
            this.cmb_Answer2.Location = new System.Drawing.Point(20, 152);
            this.cmb_Answer2.Name = "cmb_Answer2";
            this.cmb_Answer2.Size = new System.Drawing.Size(500, 27);
            this.cmb_Answer2.TabIndex = 32;
            this.cmb_Answer2.SelectedIndexChanged += new System.EventHandler(this.cmb_Answer2_SelectedIndexChanged);
            // 
            // MsgComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 257);
            this.Controls.Add(this.cmb_Answer2);
            this.Controls.Add(this.cmb_Answer1);
            this.Controls.Add(this.lbl_Text);
            this.Controls.Add(this.Divider_Menu);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(542, 257);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(542, 257);
            this.Name = "MsgComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgComboBox";
            this.Load += new System.EventHandler(this.MsgComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_Status;
        private MaterialSkin.Controls.MaterialFlatButton btn_Cancel;
        private MaterialSkin.Controls.MaterialFlatButton btn_OK;
        private MaterialSkin.Controls.MaterialRaisedButton Divider_Menu;
        private MaterialSkin.Controls.MaterialLabel lbl_Text;
        private System.Windows.Forms.ComboBox cmb_Answer1;
        private System.Windows.Forms.ComboBox cmb_Answer2;
    }
}