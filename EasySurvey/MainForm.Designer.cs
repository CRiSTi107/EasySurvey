namespace EasySurvey
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("asbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbca" +
        "sbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcasbcv");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("afvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvda" +
        "fvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdafvdvvsdsds");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(resources.GetString("listView_ViewSurveyQuestions.Items"));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("adsgfasd");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("asdfds");
            this.listView_AllSurveys = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage_AllSurveys = new System.Windows.Forms.TabPage();
            this.splitContainer_AllSurveys = new System.Windows.Forms.SplitContainer();
            this.panel_AllSurveys = new System.Windows.Forms.Panel();
            this.pic_SearchAllSurveys = new System.Windows.Forms.PictureBox();
            this.txt_AllSurveysSearchBar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grb_SelectedSurveyUser = new System.Windows.Forms.GroupBox();
            this.txt_ViewSurveyDetailsName = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_ViewSurveyDetailsName = new MaterialSkin.Controls.MaterialLabel();
            this.grb_SelectedSurveyAdmin = new System.Windows.Forms.GroupBox();
            this.txt_EditSurveyDetailsName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_EditSurveyDetailsName = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.lbl_AboutUser = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel_AboutUser = new System.Windows.Forms.Panel();
            this.pic_AboutUser = new System.Windows.Forms.PictureBox();
            this.lbl_ViewSurveyQuestions = new MaterialSkin.Controls.MaterialLabel();
            this.listView_ViewSurveyQuestions = new System.Windows.Forms.ListView();
            this.materialContextMenuStrip1.SuspendLayout();
            this.materialTabControl.SuspendLayout();
            this.tabPage_AllSurveys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_AllSurveys)).BeginInit();
            this.splitContainer_AllSurveys.Panel1.SuspendLayout();
            this.splitContainer_AllSurveys.Panel2.SuspendLayout();
            this.splitContainer_AllSurveys.SuspendLayout();
            this.panel_AllSurveys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchAllSurveys)).BeginInit();
            this.grb_SelectedSurveyUser.SuspendLayout();
            this.grb_SelectedSurveyAdmin.SuspendLayout();
            this.panel_AboutUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AboutUser)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_AllSurveys
            // 
            this.listView_AllSurveys.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_AllSurveys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_AllSurveys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_AllSurveys.ContextMenuStrip = this.materialContextMenuStrip1;
            this.listView_AllSurveys.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup4";
            this.listView_AllSurveys.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listView_AllSurveys.Location = new System.Drawing.Point(6, 34);
            this.listView_AllSurveys.MinimumSize = new System.Drawing.Size(100, 100);
            this.listView_AllSurveys.Name = "listView_AllSurveys";
            this.listView_AllSurveys.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView_AllSurveys.Size = new System.Drawing.Size(428, 478);
            this.listView_AllSurveys.TabIndex = 0;
            this.listView_AllSurveys.TileSize = new System.Drawing.Size(120, 40);
            this.listView_AllSurveys.UseCompatibleStateImageBehavior = false;
            this.listView_AllSurveys.View = System.Windows.Forms.View.Tile;
            this.listView_AllSurveys.SelectedIndexChanged += new System.EventHandler(this.listView_AllSurveys_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 122;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.testToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(108, 70);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // materialTabControl
            // 
            this.materialTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl.Controls.Add(this.tabPage_AllSurveys);
            this.materialTabControl.Controls.Add(this.tabPage2);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(12, 106);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(884, 549);
            this.materialTabControl.TabIndex = 2;
            // 
            // tabPage_AllSurveys
            // 
            this.tabPage_AllSurveys.Controls.Add(this.splitContainer_AllSurveys);
            this.tabPage_AllSurveys.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AllSurveys.Name = "tabPage_AllSurveys";
            this.tabPage_AllSurveys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AllSurveys.Size = new System.Drawing.Size(876, 523);
            this.tabPage_AllSurveys.TabIndex = 0;
            this.tabPage_AllSurveys.Text = "All Surveys";
            this.tabPage_AllSurveys.Click += new System.EventHandler(this.tabPage_AllSurveys_Click);
            // 
            // splitContainer_AllSurveys
            // 
            this.splitContainer_AllSurveys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_AllSurveys.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_AllSurveys.Name = "splitContainer_AllSurveys";
            // 
            // splitContainer_AllSurveys.Panel1
            // 
            this.splitContainer_AllSurveys.Panel1.Controls.Add(this.panel_AllSurveys);
            // 
            // splitContainer_AllSurveys.Panel2
            // 
            this.splitContainer_AllSurveys.Panel2.Controls.Add(this.grb_SelectedSurveyUser);
            this.splitContainer_AllSurveys.Panel2.Controls.Add(this.grb_SelectedSurveyAdmin);
            this.splitContainer_AllSurveys.Size = new System.Drawing.Size(870, 517);
            this.splitContainer_AllSurveys.SplitterDistance = 441;
            this.splitContainer_AllSurveys.TabIndex = 8;
            // 
            // panel_AllSurveys
            // 
            this.panel_AllSurveys.Controls.Add(this.pic_SearchAllSurveys);
            this.panel_AllSurveys.Controls.Add(this.txt_AllSurveysSearchBar);
            this.panel_AllSurveys.Controls.Add(this.listView_AllSurveys);
            this.panel_AllSurveys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AllSurveys.Location = new System.Drawing.Point(0, 0);
            this.panel_AllSurveys.Name = "panel_AllSurveys";
            this.panel_AllSurveys.Size = new System.Drawing.Size(441, 517);
            this.panel_AllSurveys.TabIndex = 9;
            // 
            // pic_SearchAllSurveys
            // 
            this.pic_SearchAllSurveys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_SearchAllSurveys.BackgroundImage = global::EasySurvey.Properties.Resources.search_icon_24x24;
            this.pic_SearchAllSurveys.Location = new System.Drawing.Point(410, 5);
            this.pic_SearchAllSurveys.Name = "pic_SearchAllSurveys";
            this.pic_SearchAllSurveys.Size = new System.Drawing.Size(24, 24);
            this.pic_SearchAllSurveys.TabIndex = 5;
            this.pic_SearchAllSurveys.TabStop = false;
            // 
            // txt_AllSurveysSearchBar
            // 
            this.txt_AllSurveysSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_AllSurveysSearchBar.Depth = 0;
            this.txt_AllSurveysSearchBar.Hint = "";
            this.txt_AllSurveysSearchBar.Location = new System.Drawing.Point(6, 5);
            this.txt_AllSurveysSearchBar.MaxLength = 32767;
            this.txt_AllSurveysSearchBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_AllSurveysSearchBar.Name = "txt_AllSurveysSearchBar";
            this.txt_AllSurveysSearchBar.PasswordChar = '\0';
            this.txt_AllSurveysSearchBar.SelectedText = "";
            this.txt_AllSurveysSearchBar.SelectionLength = 0;
            this.txt_AllSurveysSearchBar.SelectionStart = 0;
            this.txt_AllSurveysSearchBar.Size = new System.Drawing.Size(398, 23);
            this.txt_AllSurveysSearchBar.TabIndex = 4;
            this.txt_AllSurveysSearchBar.TabStop = false;
            this.txt_AllSurveysSearchBar.Text = "Search...";
            this.txt_AllSurveysSearchBar.UseSystemPasswordChar = false;
            this.txt_AllSurveysSearchBar.Enter += new System.EventHandler(this.txt_AllSurveysSearchBar_Enter);
            this.txt_AllSurveysSearchBar.Leave += new System.EventHandler(this.txt_AllSurveysSearchBar_Leave);
            this.txt_AllSurveysSearchBar.TextChanged += new System.EventHandler(this.txt_AllSurveysSearchBar_TextChanged);
            // 
            // grb_SelectedSurveyUser
            // 
            this.grb_SelectedSurveyUser.BackColor = System.Drawing.Color.White;
            this.grb_SelectedSurveyUser.Controls.Add(this.listView_ViewSurveyQuestions);
            this.grb_SelectedSurveyUser.Controls.Add(this.lbl_ViewSurveyQuestions);
            this.grb_SelectedSurveyUser.Controls.Add(this.txt_ViewSurveyDetailsName);
            this.grb_SelectedSurveyUser.Controls.Add(this.lbl_ViewSurveyDetailsName);
            this.grb_SelectedSurveyUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_SelectedSurveyUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grb_SelectedSurveyUser.Location = new System.Drawing.Point(0, 0);
            this.grb_SelectedSurveyUser.Name = "grb_SelectedSurveyUser";
            this.grb_SelectedSurveyUser.Size = new System.Drawing.Size(425, 517);
            this.grb_SelectedSurveyUser.TabIndex = 5;
            this.grb_SelectedSurveyUser.TabStop = false;
            this.grb_SelectedSurveyUser.Text = "Selected Survey - Details";
            // 
            // txt_ViewSurveyDetailsName
            // 
            this.txt_ViewSurveyDetailsName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ViewSurveyDetailsName.Depth = 0;
            this.txt_ViewSurveyDetailsName.Font = new System.Drawing.Font("Roboto", 11F);
            this.txt_ViewSurveyDetailsName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_ViewSurveyDetailsName.Location = new System.Drawing.Point(24, 58);
            this.txt_ViewSurveyDetailsName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ViewSurveyDetailsName.Name = "txt_ViewSurveyDetailsName";
            this.txt_ViewSurveyDetailsName.Size = new System.Drawing.Size(381, 60);
            this.txt_ViewSurveyDetailsName.TabIndex = 4;
            this.txt_ViewSurveyDetailsName.Text = "name name name name name name name name name name name name name name name name n" +
    "ame name name name name  ";
            // 
            // lbl_ViewSurveyDetailsName
            // 
            this.lbl_ViewSurveyDetailsName.AutoSize = true;
            this.lbl_ViewSurveyDetailsName.Depth = 0;
            this.lbl_ViewSurveyDetailsName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_ViewSurveyDetailsName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ViewSurveyDetailsName.Location = new System.Drawing.Point(20, 32);
            this.lbl_ViewSurveyDetailsName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ViewSurveyDetailsName.Name = "lbl_ViewSurveyDetailsName";
            this.lbl_ViewSurveyDetailsName.Size = new System.Drawing.Size(49, 19);
            this.lbl_ViewSurveyDetailsName.TabIndex = 2;
            this.lbl_ViewSurveyDetailsName.Text = "Nume";
            // 
            // grb_SelectedSurveyAdmin
            // 
            this.grb_SelectedSurveyAdmin.BackColor = System.Drawing.Color.White;
            this.grb_SelectedSurveyAdmin.Controls.Add(this.txt_EditSurveyDetailsName);
            this.grb_SelectedSurveyAdmin.Controls.Add(this.lbl_EditSurveyDetailsName);
            this.grb_SelectedSurveyAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_SelectedSurveyAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grb_SelectedSurveyAdmin.Location = new System.Drawing.Point(0, 0);
            this.grb_SelectedSurveyAdmin.Name = "grb_SelectedSurveyAdmin";
            this.grb_SelectedSurveyAdmin.Size = new System.Drawing.Size(425, 517);
            this.grb_SelectedSurveyAdmin.TabIndex = 4;
            this.grb_SelectedSurveyAdmin.TabStop = false;
            this.grb_SelectedSurveyAdmin.Text = "Selected Survey - Details";
            // 
            // txt_EditSurveyDetailsName
            // 
            this.txt_EditSurveyDetailsName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_EditSurveyDetailsName.Depth = 0;
            this.txt_EditSurveyDetailsName.Hint = "";
            this.txt_EditSurveyDetailsName.Location = new System.Drawing.Point(24, 54);
            this.txt_EditSurveyDetailsName.MaxLength = 32767;
            this.txt_EditSurveyDetailsName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_EditSurveyDetailsName.Name = "txt_EditSurveyDetailsName";
            this.txt_EditSurveyDetailsName.PasswordChar = '\0';
            this.txt_EditSurveyDetailsName.SelectedText = "";
            this.txt_EditSurveyDetailsName.SelectionLength = 0;
            this.txt_EditSurveyDetailsName.SelectionStart = 0;
            this.txt_EditSurveyDetailsName.Size = new System.Drawing.Size(381, 23);
            this.txt_EditSurveyDetailsName.TabIndex = 1;
            this.txt_EditSurveyDetailsName.TabStop = false;
            this.txt_EditSurveyDetailsName.UseSystemPasswordChar = false;
            // 
            // lbl_EditSurveyDetailsName
            // 
            this.lbl_EditSurveyDetailsName.AutoSize = true;
            this.lbl_EditSurveyDetailsName.Depth = 0;
            this.lbl_EditSurveyDetailsName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_EditSurveyDetailsName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_EditSurveyDetailsName.Location = new System.Drawing.Point(20, 32);
            this.lbl_EditSurveyDetailsName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_EditSurveyDetailsName.Name = "lbl_EditSurveyDetailsName";
            this.lbl_EditSurveyDetailsName.Size = new System.Drawing.Size(49, 19);
            this.lbl_EditSurveyDetailsName.TabIndex = 0;
            this.lbl_EditSurveyDetailsName.Text = "Nume";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // materialTabSelector
            // 
            this.materialTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector.BaseTabControl = this.materialTabControl;
            this.materialTabSelector.Depth = 0;
            this.materialTabSelector.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector.Name = "materialTabSelector";
            this.materialTabSelector.Size = new System.Drawing.Size(908, 37);
            this.materialTabSelector.TabIndex = 3;
            this.materialTabSelector.Text = "Material Tab Selector Home";
            // 
            // lbl_AboutUser
            // 
            this.lbl_AboutUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_AboutUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AboutUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AboutUser.Depth = 0;
            this.lbl_AboutUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_AboutUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_AboutUser.Location = new System.Drawing.Point(0, 0);
            this.lbl_AboutUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_AboutUser.Name = "lbl_AboutUser";
            this.lbl_AboutUser.Size = new System.Drawing.Size(149, 40);
            this.lbl_AboutUser.TabIndex = 6;
            this.lbl_AboutUser.Text = "root";
            this.lbl_AboutUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_AboutUser.FontChanged += new System.EventHandler(this.lbl_AboutUser_FontChanged);
            this.lbl_AboutUser.ForeColorChanged += new System.EventHandler(this.lbl_AboutUser_ForeColorChanged);
            this.lbl_AboutUser.Click += new System.EventHandler(this.AboutUser_Click);
            this.lbl_AboutUser.MouseEnter += new System.EventHandler(this.AboutUser_MouseEnter);
            this.lbl_AboutUser.MouseLeave += new System.EventHandler(this.AboutUser_MouseLeave);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(294, 65);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(79, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "REFRESH";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // panel_AboutUser
            // 
            this.panel_AboutUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_AboutUser.BackColor = System.Drawing.Color.Transparent;
            this.panel_AboutUser.Controls.Add(this.lbl_AboutUser);
            this.panel_AboutUser.Controls.Add(this.pic_AboutUser);
            this.panel_AboutUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_AboutUser.Location = new System.Drawing.Point(703, 24);
            this.panel_AboutUser.Name = "panel_AboutUser";
            this.panel_AboutUser.Size = new System.Drawing.Size(205, 40);
            this.panel_AboutUser.TabIndex = 7;
            this.panel_AboutUser.Click += new System.EventHandler(this.AboutUser_Click);
            this.panel_AboutUser.MouseEnter += new System.EventHandler(this.AboutUser_MouseEnter);
            this.panel_AboutUser.MouseLeave += new System.EventHandler(this.AboutUser_MouseLeave);
            // 
            // pic_AboutUser
            // 
            this.pic_AboutUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pic_AboutUser.BackColor = System.Drawing.Color.Transparent;
            this.pic_AboutUser.BackgroundImage = global::EasySurvey.Properties.Resources.user_icon_48x48;
            this.pic_AboutUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_AboutUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_AboutUser.Location = new System.Drawing.Point(151, 0);
            this.pic_AboutUser.Name = "pic_AboutUser";
            this.pic_AboutUser.Size = new System.Drawing.Size(52, 40);
            this.pic_AboutUser.TabIndex = 8;
            this.pic_AboutUser.TabStop = false;
            this.pic_AboutUser.Click += new System.EventHandler(this.AboutUser_Click);
            this.pic_AboutUser.MouseEnter += new System.EventHandler(this.AboutUser_MouseEnter);
            this.pic_AboutUser.MouseLeave += new System.EventHandler(this.AboutUser_MouseLeave);
            // 
            // lbl_ViewSurveyQuestions
            // 
            this.lbl_ViewSurveyQuestions.AutoSize = true;
            this.lbl_ViewSurveyQuestions.Depth = 0;
            this.lbl_ViewSurveyQuestions.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_ViewSurveyQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ViewSurveyQuestions.Location = new System.Drawing.Point(20, 144);
            this.lbl_ViewSurveyQuestions.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ViewSurveyQuestions.Name = "lbl_ViewSurveyQuestions";
            this.lbl_ViewSurveyQuestions.Size = new System.Drawing.Size(77, 19);
            this.lbl_ViewSurveyQuestions.TabIndex = 5;
            this.lbl_ViewSurveyQuestions.Text = "Questions";
            // 
            // listView_ViewSurveyQuestions
            // 
            this.listView_ViewSurveyQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_ViewSurveyQuestions.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView_ViewSurveyQuestions.Location = new System.Drawing.Point(24, 166);
            this.listView_ViewSurveyQuestions.Name = "listView_ViewSurveyQuestions";
            this.listView_ViewSurveyQuestions.Size = new System.Drawing.Size(381, 334);
            this.listView_ViewSurveyQuestions.TabIndex = 6;
            this.listView_ViewSurveyQuestions.TileSize = new System.Drawing.Size(188, 30);
            this.listView_ViewSurveyQuestions.UseCompatibleStateImageBehavior = false;
            this.listView_ViewSurveyQuestions.View = System.Windows.Forms.View.Tile;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 667);
            this.Controls.Add(this.panel_AboutUser);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialTabSelector);
            this.Controls.Add(this.materialTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Survey - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.materialTabControl.ResumeLayout(false);
            this.tabPage_AllSurveys.ResumeLayout(false);
            this.splitContainer_AllSurveys.Panel1.ResumeLayout(false);
            this.splitContainer_AllSurveys.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_AllSurveys)).EndInit();
            this.splitContainer_AllSurveys.ResumeLayout(false);
            this.panel_AllSurveys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchAllSurveys)).EndInit();
            this.grb_SelectedSurveyUser.ResumeLayout(false);
            this.grb_SelectedSurveyUser.PerformLayout();
            this.grb_SelectedSurveyAdmin.ResumeLayout(false);
            this.grb_SelectedSurveyAdmin.PerformLayout();
            this.panel_AboutUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_AboutUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ListView listView_AllSurveys;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPage_AllSurveys;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_AllSurveysSearchBar;
        private System.Windows.Forms.PictureBox pic_SearchAllSurveys;
        private System.Windows.Forms.GroupBox grb_SelectedSurveyAdmin;
        private System.Windows.Forms.GroupBox grb_SelectedSurveyUser;
        private MaterialSkin.Controls.MaterialLabel lbl_AboutUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_EditSurveyDetailsName;
        private MaterialSkin.Controls.MaterialLabel lbl_EditSurveyDetailsName;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel lbl_ViewSurveyDetailsName;
        private System.Windows.Forms.Panel panel_AboutUser;
        private System.Windows.Forms.PictureBox pic_AboutUser;
        private MaterialSkin.Controls.MaterialLabel txt_ViewSurveyDetailsName;
        private System.Windows.Forms.SplitContainer splitContainer_AllSurveys;
        private System.Windows.Forms.Panel panel_AllSurveys;
        private MaterialSkin.Controls.MaterialLabel lbl_ViewSurveyQuestions;
        private System.Windows.Forms.ListView listView_ViewSurveyQuestions;
    }
}