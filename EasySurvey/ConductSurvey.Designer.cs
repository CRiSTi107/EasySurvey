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
            this.panel_Welcome.SuspendLayout();
            this.panel_ConductSurvey.SuspendLayout();
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
            this.panel_Welcome.Location = new System.Drawing.Point(0, 64);
            this.panel_Welcome.Name = "panel_Welcome";
            this.panel_Welcome.Size = new System.Drawing.Size(927, 501);
            this.panel_Welcome.TabIndex = 0;
            // 
            // chb_Welcome_RandomizeQuestions
            // 
            this.chb_Welcome_RandomizeQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chb_Welcome_RandomizeQuestions.AutoSize = true;
            this.chb_Welcome_RandomizeQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_Welcome_RandomizeQuestions.Depth = 0;
            this.chb_Welcome_RandomizeQuestions.Font = new System.Drawing.Font("Roboto", 10F);
            this.chb_Welcome_RandomizeQuestions.Location = new System.Drawing.Point(9, 462);
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
            this.btn_Welcome_Start.Location = new System.Drawing.Point(368, 285);
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
            this.lbl_Welcome_QuestionCount.Size = new System.Drawing.Size(903, 41);
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
            this.lbl_Welcome_SurveyName.Size = new System.Drawing.Size(903, 91);
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
            this.panel_ConductSurvey.Location = new System.Drawing.Point(0, 64);
            this.panel_ConductSurvey.Name = "panel_ConductSurvey";
            this.panel_ConductSurvey.Size = new System.Drawing.Size(927, 501);
            this.panel_ConductSurvey.TabIndex = 1;
            // 
            // materialDivider_Menu
            // 
            this.materialDivider_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider_Menu.AutoSize = true;
            this.materialDivider_Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialDivider_Menu.Depth = 0;
            this.materialDivider_Menu.Icon = null;
            this.materialDivider_Menu.Location = new System.Drawing.Point(0, 403);
            this.materialDivider_Menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider_Menu.Name = "materialDivider_Menu";
            this.materialDivider_Menu.Primary = true;
            this.materialDivider_Menu.Size = new System.Drawing.Size(16, 36);
            this.materialDivider_Menu.TabIndex = 12;
            this.materialDivider_Menu.UseVisualStyleBackColor = true;
            // 
            // btn_Answer_5
            // 
            this.btn_Answer_5.AutoSize = true;
            this.btn_Answer_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_5.Depth = 0;
            this.btn_Answer_5.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_5.Location = new System.Drawing.Point(853, 327);
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
            // 
            // btn_Answer_4
            // 
            this.btn_Answer_4.AutoSize = true;
            this.btn_Answer_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_4.Depth = 0;
            this.btn_Answer_4.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_4.Location = new System.Drawing.Point(680, 327);
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
            // 
            // btn_Answer_3
            // 
            this.btn_Answer_3.AutoSize = true;
            this.btn_Answer_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_3.Depth = 0;
            this.btn_Answer_3.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_3.Location = new System.Drawing.Point(517, 327);
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
            // 
            // btn_Answer_2
            // 
            this.btn_Answer_2.AutoSize = true;
            this.btn_Answer_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_2.Depth = 0;
            this.btn_Answer_2.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_2.Location = new System.Drawing.Point(354, 327);
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
            // 
            // btn_Answer_1
            // 
            this.btn_Answer_1.AutoSize = true;
            this.btn_Answer_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_1.Depth = 0;
            this.btn_Answer_1.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_1.Location = new System.Drawing.Point(191, 327);
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
            // 
            // btn_Answer_0
            // 
            this.btn_Answer_0.AutoSize = true;
            this.btn_Answer_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Answer_0.Depth = 0;
            this.btn_Answer_0.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Answer_0.Location = new System.Drawing.Point(28, 327);
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
            this.lbl_Question.Size = new System.Drawing.Size(903, 124);
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
            this.lbl_QuestionCount.Size = new System.Drawing.Size(148, 91);
            this.lbl_QuestionCount.TabIndex = 4;
            this.lbl_QuestionCount.Text = "70 Questions";
            this.lbl_QuestionCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.lbl_SurveyName.Size = new System.Drawing.Size(749, 91);
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
            this.btn_Back.Depth = 0;
            this.btn_Back.Icon = null;
            this.btn_Back.Location = new System.Drawing.Point(12, 453);
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
            this.btn_Next.Depth = 0;
            this.btn_Next.Icon = null;
            this.btn_Next.Location = new System.Drawing.Point(720, 453);
            this.btn_Next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Primary = true;
            this.btn_Next.Size = new System.Drawing.Size(74, 36);
            this.btn_Next.TabIndex = 0;
            this.btn_Next.Text = "Next →";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // ConductSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 565);
            this.Controls.Add(this.panel_ConductSurvey);
            this.Controls.Add(this.panel_Welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConductSurvey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Easy Survey - Conduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConductSurvey_FormClosing);
            this.Load += new System.EventHandler(this.ConductSurvey_Load);
            this.panel_Welcome.ResumeLayout(false);
            this.panel_Welcome.PerformLayout();
            this.panel_ConductSurvey.ResumeLayout(false);
            this.panel_ConductSurvey.PerformLayout();
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
    }
}