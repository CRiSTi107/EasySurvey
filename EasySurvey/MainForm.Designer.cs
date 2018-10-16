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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView_AllSurveys = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage_AllSurveys = new System.Windows.Forms.TabPage();
            this.pic_SearchAllSurveys = new System.Windows.Forms.PictureBox();
            this.txt_AllSurveysSearchBar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.grb_SelectedSurveyAdmin = new System.Windows.Forms.GroupBox();
            this.txt_EditSurveyDetailsName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_EditSurveyDetailsName = new MaterialSkin.Controls.MaterialLabel();
            this.grb_SelectedSurveyUser = new System.Windows.Forms.GroupBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Welcome = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialContextMenuStrip1.SuspendLayout();
            this.materialTabControl.SuspendLayout();
            this.tabPage_AllSurveys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchAllSurveys)).BeginInit();
            this.grb_SelectedSurveyAdmin.SuspendLayout();
            this.grb_SelectedSurveyUser.SuspendLayout();
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
            this.listView_AllSurveys.Location = new System.Drawing.Point(6, 51);
            this.listView_AllSurveys.MinimumSize = new System.Drawing.Size(100, 100);
            this.listView_AllSurveys.Name = "listView_AllSurveys";
            this.listView_AllSurveys.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView_AllSurveys.Size = new System.Drawing.Size(401, 352);
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
            this.materialTabControl.Controls.Add(this.tabPage_AllSurveys);
            this.materialTabControl.Controls.Add(this.tabPage2);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(12, 106);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(421, 435);
            this.materialTabControl.TabIndex = 2;
            // 
            // tabPage_AllSurveys
            // 
            this.tabPage_AllSurveys.Controls.Add(this.pic_SearchAllSurveys);
            this.tabPage_AllSurveys.Controls.Add(this.txt_AllSurveysSearchBar);
            this.tabPage_AllSurveys.Controls.Add(this.listView_AllSurveys);
            this.tabPage_AllSurveys.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AllSurveys.Name = "tabPage_AllSurveys";
            this.tabPage_AllSurveys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AllSurveys.Size = new System.Drawing.Size(413, 409);
            this.tabPage_AllSurveys.TabIndex = 0;
            this.tabPage_AllSurveys.Text = "All Surveys";
            // 
            // pic_SearchAllSurveys
            // 
            this.pic_SearchAllSurveys.BackgroundImage = global::EasySurvey.Properties.Resources.search_icon_24x24;
            this.pic_SearchAllSurveys.Location = new System.Drawing.Point(383, 21);
            this.pic_SearchAllSurveys.Name = "pic_SearchAllSurveys";
            this.pic_SearchAllSurveys.Size = new System.Drawing.Size(24, 24);
            this.pic_SearchAllSurveys.TabIndex = 5;
            this.pic_SearchAllSurveys.TabStop = false;
            // 
            // txt_AllSurveysSearchBar
            // 
            this.txt_AllSurveysSearchBar.Depth = 0;
            this.txt_AllSurveysSearchBar.Hint = "";
            this.txt_AllSurveysSearchBar.Location = new System.Drawing.Point(6, 22);
            this.txt_AllSurveysSearchBar.MaxLength = 32767;
            this.txt_AllSurveysSearchBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_AllSurveysSearchBar.Name = "txt_AllSurveysSearchBar";
            this.txt_AllSurveysSearchBar.PasswordChar = '\0';
            this.txt_AllSurveysSearchBar.SelectedText = "";
            this.txt_AllSurveysSearchBar.SelectionLength = 0;
            this.txt_AllSurveysSearchBar.SelectionStart = 0;
            this.txt_AllSurveysSearchBar.Size = new System.Drawing.Size(371, 23);
            this.txt_AllSurveysSearchBar.TabIndex = 4;
            this.txt_AllSurveysSearchBar.TabStop = false;
            this.txt_AllSurveysSearchBar.Text = "Search...";
            this.txt_AllSurveysSearchBar.UseSystemPasswordChar = false;
            this.txt_AllSurveysSearchBar.Enter += new System.EventHandler(this.txt_AllSurveysSearchBar_Enter);
            this.txt_AllSurveysSearchBar.Leave += new System.EventHandler(this.txt_AllSurveysSearchBar_Leave);
            this.txt_AllSurveysSearchBar.TextChanged += new System.EventHandler(this.txt_AllSurveysSearchBar_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 409);
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
            this.materialTabSelector.Size = new System.Drawing.Size(861, 37);
            this.materialTabSelector.TabIndex = 3;
            this.materialTabSelector.Text = "Material Tab Selector Home";
            // 
            // grb_SelectedSurveyAdmin
            // 
            this.grb_SelectedSurveyAdmin.Controls.Add(this.txt_EditSurveyDetailsName);
            this.grb_SelectedSurveyAdmin.Controls.Add(this.lbl_EditSurveyDetailsName);
            this.grb_SelectedSurveyAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grb_SelectedSurveyAdmin.Location = new System.Drawing.Point(439, 107);
            this.grb_SelectedSurveyAdmin.Name = "grb_SelectedSurveyAdmin";
            this.grb_SelectedSurveyAdmin.Size = new System.Drawing.Size(415, 435);
            this.grb_SelectedSurveyAdmin.TabIndex = 4;
            this.grb_SelectedSurveyAdmin.TabStop = false;
            this.grb_SelectedSurveyAdmin.Text = "Selected Survey - Details";
            // 
            // txt_EditSurveyDetailsName
            // 
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
            this.txt_EditSurveyDetailsName.Size = new System.Drawing.Size(371, 23);
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
            // grb_SelectedSurveyUser
            // 
            this.grb_SelectedSurveyUser.Controls.Add(this.materialSingleLineTextField1);
            this.grb_SelectedSurveyUser.Controls.Add(this.materialLabel1);
            this.grb_SelectedSurveyUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grb_SelectedSurveyUser.Location = new System.Drawing.Point(439, 106);
            this.grb_SelectedSurveyUser.Name = "grb_SelectedSurveyUser";
            this.grb_SelectedSurveyUser.Size = new System.Drawing.Size(415, 434);
            this.grb_SelectedSurveyUser.TabIndex = 5;
            this.grb_SelectedSurveyUser.TabStop = false;
            this.grb_SelectedSurveyUser.Text = "Selected Survey - Details";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(24, 54);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(371, 23);
            this.materialSingleLineTextField1.TabIndex = 3;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(20, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Nume";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome.Depth = 0;
            this.lbl_Welcome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Welcome.Location = new System.Drawing.Point(400, 32);
            this.lbl_Welcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(108, 19);
            this.lbl_Welcome.TabIndex = 6;
            this.lbl_Welcome.Text = "materialLabel1";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 553);
            this.Controls.Add(this.grb_SelectedSurveyAdmin);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.materialTabSelector);
            this.Controls.Add(this.materialTabControl);
            this.Controls.Add(this.grb_SelectedSurveyUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasySurvey - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.materialTabControl.ResumeLayout(false);
            this.tabPage_AllSurveys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchAllSurveys)).EndInit();
            this.grb_SelectedSurveyAdmin.ResumeLayout(false);
            this.grb_SelectedSurveyAdmin.PerformLayout();
            this.grb_SelectedSurveyUser.ResumeLayout(false);
            this.grb_SelectedSurveyUser.PerformLayout();
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
        private MaterialSkin.Controls.MaterialLabel lbl_Welcome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_EditSurveyDetailsName;
        private MaterialSkin.Controls.MaterialLabel lbl_EditSurveyDetailsName;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}