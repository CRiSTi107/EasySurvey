namespace EasySurvey
{
    partial class ConductSurvey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConductSurvey));
            this.panel_Welcome = new System.Windows.Forms.Panel();
            this.chb_Welcome_RandomizeQuestions = new MaterialSkin.Controls.MaterialCheckBox();
            this.btn_Welcome_Start = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_Welcome_QuestionCount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Welcome_SurveyName = new MaterialSkin.Controls.MaterialLabel();
            this.panel_ConductSurvey = new System.Windows.Forms.Panel();
            this.btn_Finish = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_TotalQuestions = new MaterialSkin.Controls.MaterialLabel();
            this.txt_CurrentQuestion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider_Menu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Answer_5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_Answer_4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_Answer_3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_Answer_2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_Answer_1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_Answer_0 = new MaterialSkin.Controls.MaterialRadioButton();
            this.lbl_Question = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_QuestionCount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_SurveyName = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Next = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel_Finish = new System.Windows.Forms.Panel();
            this.pic_Tick = new System.Windows.Forms.PictureBox();
            this.panel_Welcome.SuspendLayout();
            this.panel_ConductSurvey.SuspendLayout();
            this.panel_Finish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Tick)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Welcome
            // 
            this.panel_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Welcome.BackColor = System.Drawing.Color.White;
            this.panel_Welcome.Controls.Add(this.chb_Welcome_RandomizeQuestions);
            this.panel_Welcome.Controls.Add(this.btn_Welcome_Start);
            this.panel_Welcome.Controls.Add(this.lbl_Welcome_QuestionCount);
            this.panel_Welcome.Controls.Add(this.lbl_Welcome_SurveyName);
            this.panel_Welcome.Location = new System.Drawing.Point(2, 64);
            this.panel_Welcome.Name = "panel_Welcome";
            this.panel_Welcome.Size = new System.Drawing.Size(923, 499);
            this.panel_Welcome.TabIndex = 0;
            // 
            // chb_Welcome_RandomizeQuestions
            // 
            this.chb_Welcome_RandomizeQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chb_Welcome_RandomizeQuestions.AutoSize = true;
            this.chb_Welcome_RandomizeQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_Welcome_RandomizeQuestions.Depth = 0;
            this.chb_Welcome_RandomizeQuestions.Font = new System.Drawing.Font("Roboto", 10F);
            this.chb_Welcome_RandomizeQuestions.Location = new System.Drawing.Point(9, 460);
            this.chb_Welcome_RandomizeQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.chb_Welcome_RandomizeQuestions.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chb_Welcome_RandomizeQuestions.MouseState = MaterialSkin.MouseState.HOVER;
            this.chb_Welcome_RandomizeQuestions.Name = "chb_Welcome_RandomizeQuestions";
            this.chb_Welcome_RandomizeQuestions.Ripple = true;
            this.chb_Welcome_RandomizeQuestions.Size = new System.Drawing.Size(164, 30);
            this.chb_Welcome_RandomizeQuestions.TabIndex = 4;
            this.chb_Welcome_RandomizeQuestions.Text = "Randomize Questions";
            this.chb_Welcome_RandomizeQuestions.UseVisualStyleBackColor = true;
            this.chb_Welcome_RandomizeQuestions.CheckedChanged += new System.EventHandler(this.chb_Welcome_RandomizeQuestions_CheckedChanged);
            // 
            // btn_Welcome_Start
            // 
            this.btn_Welcome_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Welcome_Start.AutoSize = true;
            this.btn_Welcome_Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Welcome_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Welcome_Start.Depth = 0;
            this.btn_Welcome_Start.Icon = null;
            this.btn_Welcome_Start.Location = new System.Drawing.Point(366, 284);
            this.btn_Welcome_Start.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Welcome_Start.Name = "btn_Welcome_Start";
            this.btn_Welcome_Start.Primary = true;
            this.btn_Welcome_Start.Size = new System.Drawing.Size(64, 36);
            this.btn_Welcome_Start.TabIndex = 3;
            this.btn_Welcome_Start.Text = "Start";
            this.btn_Welcome_Start.UseVisualStyleBackColor = true;
            this.btn_Welcome_Start.Click += new System.EventHandler(this.btn_Welcome_Start_Click);
            // 
            // lbl_Welcome_QuestionCount
            // 
            this.lbl_Welcome_QuestionCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Welcome_QuestionCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome_QuestionCount.Depth = 0;
            this.lbl_Welcome_QuestionCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Welcome_QuestionCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Welcome_QuestionCount.Location = new System.Drawing.Point(12, 103);
            this.lbl_Welcome_QuestionCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Welcome_QuestionCount.Name = "lbl_Welcome_QuestionCount";
            this.lbl_Welcome_QuestionCount.Size = new System.Drawing.Size(899, 41);
            this.lbl_Welcome_QuestionCount.TabIndex = 1;
            this.lbl_Welcome_QuestionCount.Text = "70 Questions";
            this.lbl_Welcome_QuestionCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Welcome_SurveyName
            // 
            this.lbl_Welcome_SurveyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Welcome_SurveyName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome_SurveyName.Depth = 0;
            this.lbl_Welcome_SurveyName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Welcome_SurveyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Welcome_SurveyName.Location = new System.Drawing.Point(12, 11);
            this.lbl_Welcome_SurveyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Welcome_SurveyName.Name = "lbl_Welcome_SurveyName";
            this.lbl_Welcome_SurveyName.Size = new System.Drawing.Size(899, 91);
            this.lbl_Welcome_SurveyName.TabIndex = 0;
            this.lbl_Welcome_SurveyName.Text = "Name of Survey here!";
            this.lbl_Welcome_SurveyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Welcome_SurveyName.FontChanged += new System.EventHandler(this.lbl_SurveyName_FontChanged);
            // 
            // panel_ConductSurvey
            // 
            this.panel_ConductSurvey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ConductSurvey.BackColor = System.Drawing.Color.White;
            this.panel_ConductSurvey.Controls.Add(this.btn_Finish);
            this.panel_ConductSurvey.Controls.Add(this.lbl_TotalQuestions);
            this.panel_ConductSurvey.Controls.Add(this.txt_CurrentQuestion);
            this.panel_ConductSurvey.Controls.Add(this.materialDivider_Menu);
            this.panel_ConductSurvey.Controls.Add(this.btn_Answer_5);
            this.panel_ConductSurvey.Controls.Add(this.btn_Answer_4);
            this.panel_ConductSurvey.Controls.Add(this.btn_Answer_3);
            this.panel_ConductSurvey.Controls.Add(this.btn_Answer_2);
            this.panel_ConductSurvey.Controls.Add(this.btn_Answer_1);
            this.panel_ConductSurvey.Controls.Add(this.btn_Answer_0);
            this.panel_ConductSurvey.Controls.Add(this.lbl_Question);
            this.panel_ConductSurvey.Controls.Add(this.lbl_QuestionCount);
            this.panel_ConductSurvey.Controls.Add(this.lbl_SurveyName);
            this.panel_ConductSurvey.Controls.Add(this.btn_Back);
            this.panel_ConductSurvey.Controls.Add(this.btn_Next);
            this.panel_ConductSurvey.Location = new System.Drawing.Point(2, 64);
            this.panel_ConductSurvey.Name = "panel_ConductSurvey";
            this.panel_ConductSurvey.Size = new System.Drawing.Size(923, 499);
            this.panel_ConductSurvey.TabIndex = 1;
            // 
            // btn_Finish
            // 
            this.btn_Finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Finish.AutoSize = true;
            this.btn_Finish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Finish.Depth = 0;
            this.btn_Finish.Enabled = false;
            this.btn_Finish.Icon = null;
            this.btn_Finish.Location = new System.Drawing.Point(515, 451);
            this.btn_Finish.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Primary = true;
            this.btn_Finish.Size = new System.Drawing.Size(64, 36);
            this.btn_Finish.TabIndex = 15;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            this.btn_Finish.Visible = false;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // lbl_TotalQuestions
            // 
            this.lbl_TotalQuestions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_TotalQuestions.AutoSize = true;
            this.lbl_TotalQuestions.Depth = 0;
            this.lbl_TotalQuestions.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_TotalQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_TotalQuestions.Location = new System.Drawing.Point(457, 459);
            this.lbl_TotalQuestions.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_TotalQuestions.Name = "lbl_TotalQuestions";
            this.lbl_TotalQuestions.Size = new System.Drawing.Size(35, 19);
            this.lbl_TotalQuestions.TabIndex = 14;
            this.lbl_TotalQuestions.Text = "/ 70";
            // 
            // txt_CurrentQuestion
            // 
            this.txt_CurrentQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_CurrentQuestion.Depth = 0;
            this.txt_CurrentQuestion.Hint = "";
            this.txt_CurrentQuestion.Location = new System.Drawing.Point(363, 459);
            this.txt_CurrentQuestion.MaximumSize = new System.Drawing.Size(88, 23);
            this.txt_CurrentQuestion.MaxLength = 32767;
            this.txt_CurrentQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_CurrentQuestion.Name = "txt_CurrentQuestion";
            this.txt_CurrentQuestion.PasswordChar = '\0';
            this.txt_CurrentQuestion.SelectedText = "";
            this.txt_CurrentQuestion.SelectionLength = 0;
            this.txt_CurrentQuestion.SelectionStart = 0;
            this.txt_CurrentQuestion.Size = new System.Drawing.Size(88, 23);
            this.txt_CurrentQuestion.TabIndex = 13;
            this.txt_CurrentQuestion.TabStop = false;
            this.txt_CurrentQuestion.Text = "0";
            this.txt_CurrentQuestion.UseSystemPasswordChar = false;
            this.txt_CurrentQuestion.TextChanged += new System.EventHandler(this.txt_CurrentQuestion_TextChanged);
            // 
            // materialDivider_Menu
            // 
            this.materialDivider_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider_Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialDivider_Menu.Depth = 0;
            this.materialDivider_Menu.Icon = null;
            this.materialDivider_Menu.Location = new System.Drawing.Point(0, 427);
            this.materialDivider_Menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider_Menu.Name = "materialDivider_Menu";
            this.materialDivider_Menu.Primary = true;
            this.materialDivider_Menu.Size = new System.Drawing.Size(924, 10);
            this.materialDivider_Menu.TabIndex = 12;
            this.materialDivider_Menu.UseVisualStyleBackColor = true;
            // 
            // btn_Answer_5
            // 
            this.btn_Answer_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Answer_5.AutoSize = true;
            this.btn_Answer_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_5.Depth = 0;
            this.btn_Answer_5.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_5.Location = new System.Drawing.Point(851, 326);
            this.btn_Answer_5.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Answer_5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_Answer_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Answer_5.Name = "btn_Answer_5";
            this.btn_Answer_5.Ripple = true;
            this.btn_Answer_5.Size = new System.Drawing.Size(37, 30);
            this.btn_Answer_5.TabIndex = 11;
            this.btn_Answer_5.TabStop = true;
            this.btn_Answer_5.Text = "5";
            this.btn_Answer_5.UseVisualStyleBackColor = true;
            this.btn_Answer_5.CheckedChanged += new System.EventHandler(this.btn_Answer_CheckedChanged);
            this.btn_Answer_5.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // btn_Answer_4
            // 
            this.btn_Answer_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Answer_4.AutoSize = true;
            this.btn_Answer_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_4.Depth = 0;
            this.btn_Answer_4.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_4.Location = new System.Drawing.Point(678, 326);
            this.btn_Answer_4.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Answer_4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_Answer_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Answer_4.Name = "btn_Answer_4";
            this.btn_Answer_4.Ripple = true;
            this.btn_Answer_4.Size = new System.Drawing.Size(37, 30);
            this.btn_Answer_4.TabIndex = 10;
            this.btn_Answer_4.TabStop = true;
            this.btn_Answer_4.Text = "4";
            this.btn_Answer_4.UseVisualStyleBackColor = true;
            this.btn_Answer_4.CheckedChanged += new System.EventHandler(this.btn_Answer_CheckedChanged);
            this.btn_Answer_4.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // btn_Answer_3
            // 
            this.btn_Answer_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Answer_3.AutoSize = true;
            this.btn_Answer_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_3.Depth = 0;
            this.btn_Answer_3.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_3.Location = new System.Drawing.Point(515, 326);
            this.btn_Answer_3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Answer_3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_Answer_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Answer_3.Name = "btn_Answer_3";
            this.btn_Answer_3.Ripple = true;
            this.btn_Answer_3.Size = new System.Drawing.Size(37, 30);
            this.btn_Answer_3.TabIndex = 9;
            this.btn_Answer_3.TabStop = true;
            this.btn_Answer_3.Text = "3";
            this.btn_Answer_3.UseVisualStyleBackColor = true;
            this.btn_Answer_3.CheckedChanged += new System.EventHandler(this.btn_Answer_CheckedChanged);
            this.btn_Answer_3.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // btn_Answer_2
            // 
            this.btn_Answer_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Answer_2.AutoSize = true;
            this.btn_Answer_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_2.Depth = 0;
            this.btn_Answer_2.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_2.Location = new System.Drawing.Point(352, 326);
            this.btn_Answer_2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Answer_2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_Answer_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Answer_2.Name = "btn_Answer_2";
            this.btn_Answer_2.Ripple = true;
            this.btn_Answer_2.Size = new System.Drawing.Size(37, 30);
            this.btn_Answer_2.TabIndex = 8;
            this.btn_Answer_2.TabStop = true;
            this.btn_Answer_2.Text = "2";
            this.btn_Answer_2.UseVisualStyleBackColor = true;
            this.btn_Answer_2.CheckedChanged += new System.EventHandler(this.btn_Answer_CheckedChanged);
            this.btn_Answer_2.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // btn_Answer_1
            // 
            this.btn_Answer_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Answer_1.AutoSize = true;
            this.btn_Answer_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_1.Depth = 0;
            this.btn_Answer_1.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_1.Location = new System.Drawing.Point(189, 326);
            this.btn_Answer_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Answer_1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_Answer_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Answer_1.Name = "btn_Answer_1";
            this.btn_Answer_1.Ripple = true;
            this.btn_Answer_1.Size = new System.Drawing.Size(37, 30);
            this.btn_Answer_1.TabIndex = 7;
            this.btn_Answer_1.TabStop = true;
            this.btn_Answer_1.Text = "1";
            this.btn_Answer_1.UseVisualStyleBackColor = true;
            this.btn_Answer_1.CheckedChanged += new System.EventHandler(this.btn_Answer_CheckedChanged);
            this.btn_Answer_1.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // btn_Answer_0
            // 
            this.btn_Answer_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Answer_0.AutoSize = true;
            this.btn_Answer_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_0.Depth = 0;
            this.btn_Answer_0.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_0.Location = new System.Drawing.Point(26, 326);
            this.btn_Answer_0.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Answer_0.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_Answer_0.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Answer_0.Name = "btn_Answer_0";
            this.btn_Answer_0.Ripple = true;
            this.btn_Answer_0.Size = new System.Drawing.Size(37, 30);
            this.btn_Answer_0.TabIndex = 6;
            this.btn_Answer_0.TabStop = true;
            this.btn_Answer_0.Text = "0";
            this.btn_Answer_0.UseVisualStyleBackColor = true;
            this.btn_Answer_0.CheckedChanged += new System.EventHandler(this.btn_Answer_CheckedChanged);
            this.btn_Answer_0.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // lbl_Question
            // 
            this.lbl_Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Question.Depth = 0;
            this.lbl_Question.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Question.Location = new System.Drawing.Point(12, 158);
            this.lbl_Question.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(899, 124);
            this.lbl_Question.TabIndex = 5;
            this.lbl_Question.Text = "1. Here goes question??";
            this.lbl_Question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_QuestionCount
            // 
            this.lbl_QuestionCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_QuestionCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_QuestionCount.Depth = 0;
            this.lbl_QuestionCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_QuestionCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_QuestionCount.Location = new System.Drawing.Point(767, 11);
            this.lbl_QuestionCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_QuestionCount.Name = "lbl_QuestionCount";
            this.lbl_QuestionCount.Size = new System.Drawing.Size(144, 91);
            this.lbl_QuestionCount.TabIndex = 4;
            this.lbl_QuestionCount.Text = "70 Questions";
            this.lbl_QuestionCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SurveyName
            // 
            this.lbl_SurveyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SurveyName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SurveyName.Depth = 0;
            this.lbl_SurveyName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_SurveyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_SurveyName.Location = new System.Drawing.Point(12, 11);
            this.lbl_SurveyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_SurveyName.Name = "lbl_SurveyName";
            this.lbl_SurveyName.Size = new System.Drawing.Size(745, 91);
            this.lbl_SurveyName.TabIndex = 3;
            this.lbl_SurveyName.Text = "Name of Survey here!";
            this.lbl_SurveyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SurveyName.FontChanged += new System.EventHandler(this.lbl_SurveyName_FontChanged);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.AutoSize = true;
            this.btn_Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Depth = 0;
            this.btn_Back.Icon = null;
            this.btn_Back.Location = new System.Drawing.Point(12, 451);
            this.btn_Back.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Primary = true;
            this.btn_Back.Size = new System.Drawing.Size(75, 36);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "← Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.AutoSize = true;
            this.btn_Next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.Depth = 0;
            this.btn_Next.Icon = null;
            this.btn_Next.Location = new System.Drawing.Point(716, 451);
            this.btn_Next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Primary = true;
            this.btn_Next.Size = new System.Drawing.Size(74, 36);
            this.btn_Next.TabIndex = 0;
            this.btn_Next.Text = "Next →";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // panel_Finish
            // 
            this.panel_Finish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Finish.BackColor = System.Drawing.Color.White;
            this.panel_Finish.Controls.Add(this.pic_Tick);
            this.panel_Finish.Location = new System.Drawing.Point(2, 64);
            this.panel_Finish.Name = "panel_Finish";
            this.panel_Finish.Size = new System.Drawing.Size(923, 499);
            this.panel_Finish.TabIndex = 2;
            // 
            // pic_Tick
            // 
            this.pic_Tick.BackgroundImage = global::EasySurvey.Properties.Resources.tick_green_512x512;
            this.pic_Tick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Tick.Location = new System.Drawing.Point(167, 40);
            this.pic_Tick.Name = "pic_Tick";
            this.pic_Tick.Size = new System.Drawing.Size(180, 180);
            this.pic_Tick.TabIndex = 0;
            this.pic_Tick.TabStop = false;
            // 
            // ConductSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 565);
            this.Controls.Add(this.panel_Finish);
            this.Controls.Add(this.panel_ConductSurvey);
            this.Controls.Add(this.panel_Welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(927, 565);
            this.Name = "ConductSurvey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Easy Survey - Conduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConductSurvey_FormClosing);
            this.Load += new System.EventHandler(this.ConductSurvey_Load);
            this.panel_Welcome.ResumeLayout(false);
            this.panel_Welcome.PerformLayout();
            this.panel_ConductSurvey.ResumeLayout(false);
            this.panel_ConductSurvey.PerformLayout();
            this.panel_Finish.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Tick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Welcome;
        private MaterialSkin.Controls.MaterialLabel lbl_Welcome_SurveyName;
        private MaterialSkin.Controls.MaterialLabel lbl_Welcome_QuestionCount;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Welcome_Start;
        private MaterialSkin.Controls.MaterialCheckBox chb_Welcome_RandomizeQuestions;
        private System.Windows.Forms.Panel panel_ConductSurvey;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Back;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Next;
        private MaterialSkin.Controls.MaterialLabel lbl_QuestionCount;
        private MaterialSkin.Controls.MaterialLabel lbl_SurveyName;
        private MaterialSkin.Controls.MaterialLabel lbl_Question;
        private MaterialSkin.Controls.MaterialRadioButton btn_Answer_5;
        private MaterialSkin.Controls.MaterialRadioButton btn_Answer_4;
        private MaterialSkin.Controls.MaterialRadioButton btn_Answer_3;
        private MaterialSkin.Controls.MaterialRadioButton btn_Answer_2;
        private MaterialSkin.Controls.MaterialRadioButton btn_Answer_1;
        private MaterialSkin.Controls.MaterialRadioButton btn_Answer_0;
        private MaterialSkin.Controls.MaterialRaisedButton materialDivider_Menu;
        private MaterialSkin.Controls.MaterialLabel lbl_TotalQuestions;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_CurrentQuestion;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Finish;
        private System.Windows.Forms.Panel panel_Finish;
        private System.Windows.Forms.PictureBox pic_Tick;
    }
}