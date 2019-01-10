namespace SetupCD
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_Logo = new System.Windows.Forms.Label();
            this.grb_Divider = new System.Windows.Forms.GroupBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_InstalldotNETFramework40 = new System.Windows.Forms.LinkLabel();
            this.lbl_InstallEasySurvey = new System.Windows.Forms.LinkLabel();
            this.lbl_Exit = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Logo
            // 
            this.pic_Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_Logo.BackgroundImage = global::SetupCD.Properties.Resources.EasySurveyLogo_512x512;
            this.pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Logo.Location = new System.Drawing.Point(81, 12);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(116, 105);
            this.pic_Logo.TabIndex = 0;
            this.pic_Logo.TabStop = false;
            // 
            // lbl_Logo
            // 
            this.lbl_Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Logo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Logo.Location = new System.Drawing.Point(203, 12);
            this.lbl_Logo.Name = "lbl_Logo";
            this.lbl_Logo.Size = new System.Drawing.Size(342, 105);
            this.lbl_Logo.TabIndex = 1;
            this.lbl_Logo.Text = "Easy Survey - Setup CD";
            this.lbl_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grb_Divider
            // 
            this.grb_Divider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_Divider.Location = new System.Drawing.Point(-6, 128);
            this.grb_Divider.Name = "grb_Divider";
            this.grb_Divider.Size = new System.Drawing.Size(595, 5);
            this.grb_Divider.TabIndex = 2;
            this.grb_Divider.TabStop = false;
            // 
            // lbl_1
            // 
            this.lbl_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_1.Location = new System.Drawing.Point(151, 166);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(22, 20);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "1.";
            // 
            // lbl_2
            // 
            this.lbl_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_2.Location = new System.Drawing.Point(151, 216);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(22, 20);
            this.lbl_2.TabIndex = 4;
            this.lbl_2.Text = "2.";
            // 
            // lbl_InstalldotNETFramework40
            // 
            this.lbl_InstalldotNETFramework40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_InstalldotNETFramework40.AutoSize = true;
            this.lbl_InstalldotNETFramework40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_InstalldotNETFramework40.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_InstalldotNETFramework40.Location = new System.Drawing.Point(176, 166);
            this.lbl_InstalldotNETFramework40.Name = "lbl_InstalldotNETFramework40";
            this.lbl_InstalldotNETFramework40.Size = new System.Drawing.Size(198, 20);
            this.lbl_InstalldotNETFramework40.TabIndex = 5;
            this.lbl_InstalldotNETFramework40.TabStop = true;
            this.lbl_InstalldotNETFramework40.Text = "Install .NET Framework 4.0";
            this.lbl_InstalldotNETFramework40.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_InstalldotNETFramework40_LinkClicked);
            // 
            // lbl_InstallEasySurvey
            // 
            this.lbl_InstallEasySurvey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_InstallEasySurvey.AutoSize = true;
            this.lbl_InstallEasySurvey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_InstallEasySurvey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_InstallEasySurvey.Location = new System.Drawing.Point(176, 216);
            this.lbl_InstallEasySurvey.Name = "lbl_InstallEasySurvey";
            this.lbl_InstallEasySurvey.Size = new System.Drawing.Size(138, 20);
            this.lbl_InstallEasySurvey.TabIndex = 6;
            this.lbl_InstallEasySurvey.TabStop = true;
            this.lbl_InstallEasySurvey.Text = "Install Easy Survey";
            this.lbl_InstallEasySurvey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_InstallEasySurvey_LinkClicked);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Exit.Location = new System.Drawing.Point(537, 263);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(35, 20);
            this.lbl_Exit.TabIndex = 7;
            this.lbl_Exit.TabStop = true;
            this.lbl_Exit.Text = "Exit";
            this.lbl_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Exit_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 292);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.lbl_InstallEasySurvey);
            this.Controls.Add(this.lbl_InstalldotNETFramework40);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.grb_Divider);
            this.Controls.Add(this.lbl_Logo);
            this.Controls.Add(this.pic_Logo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 330);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetupCD - Easy Survey";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Label lbl_Logo;
        private System.Windows.Forms.GroupBox grb_Divider;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.LinkLabel lbl_InstalldotNETFramework40;
        private System.Windows.Forms.LinkLabel lbl_InstallEasySurvey;
        private System.Windows.Forms.LinkLabel lbl_Exit;
    }
}

