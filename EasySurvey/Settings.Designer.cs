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
            this.lbl_CheckForUpdates = new MaterialSkin.Controls.MaterialLabel();
            this.panel_GitHub = new System.Windows.Forms.Panel();
            this.pic_GitHub = new System.Windows.Forms.PictureBox();
            this.lbl_CurrentVersion = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Owner = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_EasySurvey = new MaterialSkin.Controls.MaterialLabel();
            this.pic_EasySurveyLogo = new System.Windows.Forms.PictureBox();
            this.panel_Me = new System.Windows.Forms.Panel();
            this.pic_LockPassword = new System.Windows.Forms.PictureBox();
            this.pic_UnlockPassword = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rdb_LockPassword = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdb_UnlockPassword = new MaterialSkin.Controls.MaterialRadioButton();
            this.lbl_Username = new MaterialSkin.Controls.MaterialLabel();
            this.pic_UserCard = new System.Windows.Forms.PictureBox();
            this.lbl_UnlockPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_CurrentPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_NewPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_ReTypeNewPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txt_CurrentPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_NewPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_ReTypeNewPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel_About.SuspendLayout();
            this.panel_GitHub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EasySurveyLogo)).BeginInit();
            this.panel_Me.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LockPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UnlockPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserCard)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_Menu
            // 
            this.treeView_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView_Menu.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView_Menu.HideSelection = false;
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
            this.treeView_Menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Menu_AfterSelect);
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
            // panel_Me
            // 
            this.panel_Me.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Me.BackColor = System.Drawing.Color.White;
            this.panel_Me.Controls.Add(this.txt_ReTypeNewPassword);
            this.panel_Me.Controls.Add(this.txt_NewPassword);
            this.panel_Me.Controls.Add(this.txt_CurrentPassword);
            this.panel_Me.Controls.Add(this.lbl_ReTypeNewPassword);
            this.panel_Me.Controls.Add(this.lbl_NewPassword);
            this.panel_Me.Controls.Add(this.lbl_CurrentPassword);
            this.panel_Me.Controls.Add(this.lbl_UnlockPassword);
            this.panel_Me.Controls.Add(this.pic_LockPassword);
            this.panel_Me.Controls.Add(this.pic_UnlockPassword);
            this.panel_Me.Controls.Add(this.materialRaisedButton1);
            this.panel_Me.Controls.Add(this.rdb_LockPassword);
            this.panel_Me.Controls.Add(this.rdb_UnlockPassword);
            this.panel_Me.Controls.Add(this.lbl_Username);
            this.panel_Me.Controls.Add(this.pic_UserCard);
            this.panel_Me.Location = new System.Drawing.Point(210, 73);
            this.panel_Me.Name = "panel_Me";
            this.panel_Me.Size = new System.Drawing.Size(456, 348);
            this.panel_Me.TabIndex = 2;
            // 
            // pic_LockPassword
            // 
            this.pic_LockPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_LockPassword.BackgroundImage = global::EasySurvey.Properties.Resources.lock_icon_32x32;
            this.pic_LockPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_LockPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_LockPassword.Location = new System.Drawing.Point(45, 148);
            this.pic_LockPassword.Name = "pic_LockPassword";
            this.pic_LockPassword.Size = new System.Drawing.Size(30, 30);
            this.pic_LockPassword.TabIndex = 6;
            this.pic_LockPassword.TabStop = false;
            this.pic_LockPassword.Click += new System.EventHandler(this.pic_LockPassword_Click);
            // 
            // pic_UnlockPassword
            // 
            this.pic_UnlockPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_UnlockPassword.BackgroundImage = global::EasySurvey.Properties.Resources.unlock_icon_32x32;
            this.pic_UnlockPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_UnlockPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_UnlockPassword.Location = new System.Drawing.Point(45, 107);
            this.pic_UnlockPassword.Name = "pic_UnlockPassword";
            this.pic_UnlockPassword.Size = new System.Drawing.Size(30, 30);
            this.pic_UnlockPassword.TabIndex = 5;
            this.pic_UnlockPassword.TabStop = false;
            this.pic_UnlockPassword.Click += new System.EventHandler(this.pic_UnlockPassword_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(170, 298);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(121, 36);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Save changes";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // rdb_LockPassword
            // 
            this.rdb_LockPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_LockPassword.AutoSize = true;
            this.rdb_LockPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_LockPassword.Depth = 0;
            this.rdb_LockPassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdb_LockPassword.Location = new System.Drawing.Point(17, 148);
            this.rdb_LockPassword.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_LockPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_LockPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_LockPassword.Name = "rdb_LockPassword";
            this.rdb_LockPassword.Ripple = true;
            this.rdb_LockPassword.Size = new System.Drawing.Size(25, 30);
            this.rdb_LockPassword.TabIndex = 3;
            this.rdb_LockPassword.TabStop = true;
            this.rdb_LockPassword.UseVisualStyleBackColor = true;
            this.rdb_LockPassword.CheckedChanged += new System.EventHandler(this.rdb_LockPassword_CheckedChanged);
            // 
            // rdb_UnlockPassword
            // 
            this.rdb_UnlockPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_UnlockPassword.AutoSize = true;
            this.rdb_UnlockPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_UnlockPassword.Depth = 0;
            this.rdb_UnlockPassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdb_UnlockPassword.Location = new System.Drawing.Point(17, 107);
            this.rdb_UnlockPassword.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_UnlockPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_UnlockPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_UnlockPassword.Name = "rdb_UnlockPassword";
            this.rdb_UnlockPassword.Ripple = true;
            this.rdb_UnlockPassword.Size = new System.Drawing.Size(25, 30);
            this.rdb_UnlockPassword.TabIndex = 2;
            this.rdb_UnlockPassword.TabStop = true;
            this.rdb_UnlockPassword.UseVisualStyleBackColor = true;
            this.rdb_UnlockPassword.CheckedChanged += new System.EventHandler(this.rdb_UnlockPassword_CheckedChanged);
            // 
            // lbl_Username
            // 
            this.lbl_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Username.Depth = 0;
            this.lbl_Username.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Username.Location = new System.Drawing.Point(87, 17);
            this.lbl_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(344, 64);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "root";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_UserCard
            // 
            this.pic_UserCard.BackgroundImage = global::EasySurvey.Properties.Resources.user_icon_512x512;
            this.pic_UserCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_UserCard.Location = new System.Drawing.Point(17, 17);
            this.pic_UserCard.Name = "pic_UserCard";
            this.pic_UserCard.Size = new System.Drawing.Size(64, 64);
            this.pic_UserCard.TabIndex = 0;
            this.pic_UserCard.TabStop = false;
            // 
            // lbl_UnlockPassword
            // 
            this.lbl_UnlockPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_UnlockPassword.AutoSize = true;
            this.lbl_UnlockPassword.Depth = 0;
            this.lbl_UnlockPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_UnlockPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_UnlockPassword.Location = new System.Drawing.Point(81, 112);
            this.lbl_UnlockPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_UnlockPassword.Name = "lbl_UnlockPassword";
            this.lbl_UnlockPassword.Size = new System.Drawing.Size(323, 19);
            this.lbl_UnlockPassword.TabIndex = 7;
            this.lbl_UnlockPassword.Text = "Your accout will not be protected by password.";
            // 
            // lbl_CurrentPassword
            // 
            this.lbl_CurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CurrentPassword.AutoSize = true;
            this.lbl_CurrentPassword.Depth = 0;
            this.lbl_CurrentPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CurrentPassword.Location = new System.Drawing.Point(121, 159);
            this.lbl_CurrentPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CurrentPassword.Name = "lbl_CurrentPassword";
            this.lbl_CurrentPassword.Size = new System.Drawing.Size(128, 19);
            this.lbl_CurrentPassword.TabIndex = 8;
            this.lbl_CurrentPassword.Text = "Current Password";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Depth = 0;
            this.lbl_NewPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_NewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_NewPassword.Location = new System.Drawing.Point(140, 188);
            this.lbl_NewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(109, 19);
            this.lbl_NewPassword.TabIndex = 9;
            this.lbl_NewPassword.Text = "New Password";
            // 
            // lbl_ReTypeNewPassword
            // 
            this.lbl_ReTypeNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ReTypeNewPassword.AutoSize = true;
            this.lbl_ReTypeNewPassword.Depth = 0;
            this.lbl_ReTypeNewPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_ReTypeNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ReTypeNewPassword.Location = new System.Drawing.Point(83, 217);
            this.lbl_ReTypeNewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ReTypeNewPassword.Name = "lbl_ReTypeNewPassword";
            this.lbl_ReTypeNewPassword.Size = new System.Drawing.Size(166, 19);
            this.lbl_ReTypeNewPassword.TabIndex = 10;
            this.lbl_ReTypeNewPassword.Text = "Re-Type New Password";
            // 
            // txt_CurrentPassword
            // 
            this.txt_CurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CurrentPassword.Depth = 0;
            this.txt_CurrentPassword.Hint = "";
            this.txt_CurrentPassword.Location = new System.Drawing.Point(255, 155);
            this.txt_CurrentPassword.MaxLength = 32767;
            this.txt_CurrentPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_CurrentPassword.Name = "txt_CurrentPassword";
            this.txt_CurrentPassword.PasswordChar = '\0';
            this.txt_CurrentPassword.SelectedText = "";
            this.txt_CurrentPassword.SelectionLength = 0;
            this.txt_CurrentPassword.SelectionStart = 0;
            this.txt_CurrentPassword.Size = new System.Drawing.Size(176, 23);
            this.txt_CurrentPassword.TabIndex = 11;
            this.txt_CurrentPassword.TabStop = false;
            this.txt_CurrentPassword.UseSystemPasswordChar = true;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NewPassword.Depth = 0;
            this.txt_NewPassword.Hint = "";
            this.txt_NewPassword.Location = new System.Drawing.Point(255, 184);
            this.txt_NewPassword.MaxLength = 32767;
            this.txt_NewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.PasswordChar = '\0';
            this.txt_NewPassword.SelectedText = "";
            this.txt_NewPassword.SelectionLength = 0;
            this.txt_NewPassword.SelectionStart = 0;
            this.txt_NewPassword.Size = new System.Drawing.Size(176, 23);
            this.txt_NewPassword.TabIndex = 12;
            this.txt_NewPassword.TabStop = false;
            this.txt_NewPassword.UseSystemPasswordChar = true;
            // 
            // txt_ReTypeNewPassword
            // 
            this.txt_ReTypeNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ReTypeNewPassword.Depth = 0;
            this.txt_ReTypeNewPassword.Hint = "";
            this.txt_ReTypeNewPassword.Location = new System.Drawing.Point(255, 213);
            this.txt_ReTypeNewPassword.MaxLength = 32767;
            this.txt_ReTypeNewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ReTypeNewPassword.Name = "txt_ReTypeNewPassword";
            this.txt_ReTypeNewPassword.PasswordChar = '\0';
            this.txt_ReTypeNewPassword.SelectedText = "";
            this.txt_ReTypeNewPassword.SelectionLength = 0;
            this.txt_ReTypeNewPassword.SelectionStart = 0;
            this.txt_ReTypeNewPassword.Size = new System.Drawing.Size(176, 23);
            this.txt_ReTypeNewPassword.TabIndex = 13;
            this.txt_ReTypeNewPassword.TabStop = false;
            this.txt_ReTypeNewPassword.UseSystemPasswordChar = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 433);
            this.Controls.Add(this.panel_Me);
            this.Controls.Add(this.panel_About);
            this.Controls.Add(this.treeView_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(678, 433);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Easy Survey - Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel_About.ResumeLayout(false);
            this.panel_GitHub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_GitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EasySurveyLogo)).EndInit();
            this.panel_Me.ResumeLayout(false);
            this.panel_Me.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LockPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UnlockPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList_Menu;
        private System.Windows.Forms.Panel panel_About;
        private System.Windows.Forms.PictureBox pic_EasySurveyLogo;
        private MaterialSkin.Controls.MaterialLabel lbl_CurrentVersion;
        private MaterialSkin.Controls.MaterialLabel lbl_Owner;
        private MaterialSkin.Controls.MaterialLabel lbl_EasySurvey;
        private System.Windows.Forms.Panel panel_GitHub;
        private System.Windows.Forms.PictureBox pic_GitHub;
        private MaterialSkin.Controls.MaterialLabel lbl_CheckForUpdates;
        private System.Windows.Forms.Panel panel_Me;
        private MaterialSkin.Controls.MaterialLabel lbl_Username;
        private System.Windows.Forms.PictureBox pic_UserCard;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRadioButton rdb_LockPassword;
        private MaterialSkin.Controls.MaterialRadioButton rdb_UnlockPassword;
        private System.Windows.Forms.PictureBox pic_LockPassword;
        private System.Windows.Forms.PictureBox pic_UnlockPassword;
        public System.Windows.Forms.TreeView treeView_Menu;
        private MaterialSkin.Controls.MaterialLabel lbl_UnlockPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ReTypeNewPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_NewPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_CurrentPassword;
        private MaterialSkin.Controls.MaterialLabel lbl_ReTypeNewPassword;
        private MaterialSkin.Controls.MaterialLabel lbl_NewPassword;
        private MaterialSkin.Controls.MaterialLabel lbl_CurrentPassword;
    }
}