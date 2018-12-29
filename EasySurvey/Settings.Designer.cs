namespace EasySurvey
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("About");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Me");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Users");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Database");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.treeView_Menu = new System.Windows.Forms.TreeView();
            this.imageList_Menu = new System.Windows.Forms.ImageList(this.components);
            this.panel_About = new System.Windows.Forms.Panel();
            this.lbl_CurrentVersion = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Owner = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_EasySurvey = new MaterialSkin.Controls.MaterialLabel();
            this.panel_GitHub = new System.Windows.Forms.Panel();
            this.pic_GitHub = new System.Windows.Forms.PictureBox();
            this.pic_EasySurveyLogo = new System.Windows.Forms.PictureBox();
            this.lbl_CheckForUpdates = new MaterialSkin.Controls.MaterialLabel();
            this.panel_About.SuspendLayout();
            this.panel_GitHub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EasySurveyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_Menu
            // 
            this.treeView_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView_Menu.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView_Menu.ImageIndex = 0;
            this.treeView_Menu.ImageList = this.imageList_Menu;
            this.treeView_Menu.Location = new System.Drawing.Point(12, 73);
            this.treeView_Menu.Name = "treeView_Menu";
            treeNode1.ImageKey = "info_20x20.png";
            treeNode1.Name = "About";
            treeNode1.SelectedImageKey = "info_20x20.png";
            treeNode1.Text = "About";
            treeNode2.ImageKey = "user_icon_20x20.png";
            treeNode2.Name = "Me";
            treeNode2.SelectedImageKey = "user_icon_20x20.png";
            treeNode2.Text = "Me";
            treeNode3.ImageKey = "userslogin_icon_20x20.png";
            treeNode3.Name = "Users";
            treeNode3.SelectedImageKey = "userslogin_icon_20x20.png";
            treeNode3.Text = "Users";
            treeNode4.ImageKey = "database_icon_20x20.png";
            treeNode4.Name = "Database";
            treeNode4.SelectedImageKey = "database_icon_20x20.png";
            treeNode4.Text = "Database";
            this.treeView_Menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView_Menu.SelectedImageIndex = 0;
            this.treeView_Menu.Size = new System.Drawing.Size(192, 348);
            this.treeView_Menu.TabIndex = 0;
            this.treeView_Menu.Click += new System.EventHandler(this.treeView_Menu_Click);
            // 
            // imageList_Menu
            // 
            this.imageList_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Menu.ImageStream")));
            this.imageList_Menu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Menu.Images.SetKeyName(0, "info_20x20.png");
            this.imageList_Menu.Images.SetKeyName(1, "userslogin_icon_20x20.png");
            this.imageList_Menu.Images.SetKeyName(2, "database_icon_20x20.png");
            this.imageList_Menu.Images.SetKeyName(3, "user_icon_20x20.png");
            // 
            // panel_About
            // 
            this.panel_About.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_About.BackColor = System.Drawing.Color.White;
            this.panel_About.Controls.Add(this.lbl_CheckForUpdates);
            this.panel_About.Controls.Add(this.panel_GitHub);
            this.panel_About.Controls.Add(this.lbl_CurrentVersion);
            this.panel_About.Controls.Add(this.lbl_Owner);
            this.panel_About.Controls.Add(this.lbl_EasySurvey);
            this.panel_About.Controls.Add(this.pic_EasySurveyLogo);
            this.panel_About.Location = new System.Drawing.Point(210, 73);
            this.panel_About.Name = "panel_About";
            this.panel_About.Size = new System.Drawing.Size(456, 348);
            this.panel_About.TabIndex = 1;
            // 
            // lbl_CurrentVersion
            // 
            this.lbl_CurrentVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_CurrentVersion.Depth = 0;
            this.lbl_CurrentVersion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CurrentVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CurrentVersion.Location = new System.Drawing.Point(3, 318);
            this.lbl_CurrentVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CurrentVersion.Name = "lbl_CurrentVersion";
            this.lbl_CurrentVersion.Size = new System.Drawing.Size(190, 30);
            this.lbl_CurrentVersion.TabIndex = 5;
            this.lbl_CurrentVersion.Text = "Version : x.x.x.x";
            this.lbl_CurrentVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Owner
            // 
            this.lbl_Owner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Owner.Depth = 0;
            this.lbl_Owner.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Owner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Owner.Location = new System.Drawing.Point(3, 178);
            this.lbl_Owner.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Owner.Name = "lbl_Owner";
            this.lbl_Owner.Size = new System.Drawing.Size(450, 21);
            this.lbl_Owner.TabIndex = 4;
            this.lbl_Owner.Text = "Cristian Voiculescu";
            this.lbl_Owner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Owner.FontChanged += new System.EventHandler(this.lbl_Owner_FontChanged);
            // 
            // lbl_EasySurvey
            // 
            this.lbl_EasySurvey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EasySurvey.Depth = 0;
            this.lbl_EasySurvey.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_EasySurvey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_EasySurvey.Location = new System.Drawing.Point(3, 134);
            this.lbl_EasySurvey.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_EasySurvey.Name = "lbl_EasySurvey";
            this.lbl_EasySurvey.Size = new System.Drawing.Size(450, 44);
            this.lbl_EasySurvey.TabIndex = 3;
            this.lbl_EasySurvey.Text = "Easy Survey";
            this.lbl_EasySurvey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_EasySurvey.FontChanged += new System.EventHandler(this.lbl_EasySurvey_FontChanged);
            // 
            // panel_GitHub
            // 
            this.panel_GitHub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_GitHub.Controls.Add(this.pic_GitHub);
            this.panel_GitHub.Location = new System.Drawing.Point(3, 202);
            this.panel_GitHub.Name = "panel_GitHub";
            this.panel_GitHub.Size = new System.Drawing.Size(450, 27);
            this.panel_GitHub.TabIndex = 7;
            // 
            // pic_GitHub
            // 
            this.pic_GitHub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_GitHub.BackgroundImage = global::EasySurvey.Properties.Resources.github_icon_512x512;
            this.pic_GitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_GitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_GitHub.Location = new System.Drawing.Point(191, 4);
            this.pic_GitHub.Name = "pic_GitHub";
            this.pic_GitHub.Size = new System.Drawing.Size(66, 20);
            this.pic_GitHub.TabIndex = 0;
            this.pic_GitHub.TabStop = false;
            this.pic_GitHub.Click += new System.EventHandler(this.pic_GitHub_Click);
            // 
            // pic_EasySurveyLogo
            // 
            this.pic_EasySurveyLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_EasySurveyLogo.BackgroundImage = global::EasySurvey.Properties.Resources.EasySurveyLogo_512x512;
            this.pic_EasySurveyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_EasySurveyLogo.Location = new System.Drawing.Point(163, 3);
            this.pic_EasySurveyLogo.Name = "pic_EasySurveyLogo";
            this.pic_EasySurveyLogo.Size = new System.Drawing.Size(128, 128);
            this.pic_EasySurveyLogo.TabIndex = 2;
            this.pic_EasySurveyLogo.TabStop = false;
            // 
            // lbl_CheckForUpdates
            // 
            this.lbl_CheckForUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckForUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CheckForUpdates.Depth = 0;
            this.lbl_CheckForUpdates.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CheckForUpdates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CheckForUpdates.Location = new System.Drawing.Point(317, 318);
            this.lbl_CheckForUpdates.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CheckForUpdates.Name = "lbl_CheckForUpdates";
            this.lbl_CheckForUpdates.Size = new System.Drawing.Size(136, 30);
            this.lbl_CheckForUpdates.TabIndex = 8;
            this.lbl_CheckForUpdates.Text = "Check for updates";
            this.lbl_CheckForUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_CheckForUpdates.Click += new System.EventHandler(this.lbl_CheckForUpdates_Click);
            this.lbl_CheckForUpdates.MouseEnter += new System.EventHandler(this.lbl_CheckForUpdates_MouseEnter);
            this.lbl_CheckForUpdates.MouseLeave += new System.EventHandler(this.lbl_CheckForUpdates_MouseLeave);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 433);
            this.Controls.Add(this.panel_About);
            this.Controls.Add(this.treeView_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(678, 433);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel_About.ResumeLayout(false);
            this.panel_GitHub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_GitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EasySurveyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_Menu;
        private System.Windows.Forms.ImageList imageList_Menu;
        private System.Windows.Forms.Panel panel_About;
        private System.Windows.Forms.PictureBox pic_EasySurveyLogo;
        private MaterialSkin.Controls.MaterialLabel lbl_CurrentVersion;
        private MaterialSkin.Controls.MaterialLabel lbl_Owner;
        private MaterialSkin.Controls.MaterialLabel lbl_EasySurvey;
        private System.Windows.Forms.Panel panel_GitHub;
        private System.Windows.Forms.PictureBox pic_GitHub;
        private MaterialSkin.Controls.MaterialLabel lbl_CheckForUpdates;
    }
}