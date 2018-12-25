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
            this.lbl_Welcome_SurveyName = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Welcome_QuestionCount = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Welcome_Start = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chb_Welcome_RandomizeQuestions = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel_ConductSurvey = new System.Windows.Forms.Panel();
            this.panel_Welcome.SuspendLayout();
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
            // lbl_Welcome_SurveyName
            // 
            this.lbl_Welcome_SurveyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Welcome_SurveyName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome_SurveyName.Depth = 0;
            this.lbl_Welcome_SurveyName.Font = new System.Drawing.Font("Roboto Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Welcome_SurveyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Welcome_SurveyName.Location = new System.Drawing.Point(12, 11);
            this.lbl_Welcome_SurveyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Welcome_SurveyName.Name = "lbl_Welcome_SurveyName";
            this.lbl_Welcome_SurveyName.Size = new System.Drawing.Size(903, 91);
            this.lbl_Welcome_SurveyName.TabIndex = 0;
            this.lbl_Welcome_SurveyName.Text = "Name of Survey here!";
            this.lbl_Welcome_SurveyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Welcome_SurveyName.FontChanged += new System.EventHandler(this.lbl_Welcome_SurveyName_FontChanged);
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
            // btn_Welcome_Start
            // 
            this.btn_Welcome_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Welcome_Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Welcome_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Welcome_Start.Depth = 0;
            this.btn_Welcome_Start.Icon = null;
            this.btn_Welcome_Start.Location = new System.Drawing.Point(368, 285);
            this.btn_Welcome_Start.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Welcome_Start.Name = "btn_Welcome_Start";
            this.btn_Welcome_Start.Primary = true;
            this.btn_Welcome_Start.Size = new System.Drawing.Size(190, 36);
            this.btn_Welcome_Start.TabIndex = 3;
            this.btn_Welcome_Start.Text = "Start";
            this.btn_Welcome_Start.UseVisualStyleBackColor = true;
            this.btn_Welcome_Start.Click += new System.EventHandler(this.btn_Welcome_Start_Click);
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
            // panel_ConductSurvey
            // 
            this.panel_ConductSurvey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ConductSurvey.BackColor = System.Drawing.Color.White;
            this.panel_ConductSurvey.Location = new System.Drawing.Point(0, 64);
            this.panel_ConductSurvey.Name = "panel_ConductSurvey";
            this.panel_ConductSurvey.Size = new System.Drawing.Size(927, 501);
            this.panel_ConductSurvey.TabIndex = 1;
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
            this.Text = "Easy Survey - Conduct";
            this.Load += new System.EventHandler(this.ConductSurvey_Load);
            this.panel_Welcome.ResumeLayout(false);
            this.panel_Welcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Welcome;
        private MaterialSkin.Controls.MaterialLabel lbl_Welcome_SurveyName;
        private MaterialSkin.Controls.MaterialLabel lbl_Welcome_QuestionCount;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Welcome_Start;
        private MaterialSkin.Controls.MaterialCheckBox chb_Welcome_RandomizeQuestions;
        private System.Windows.Forms.Panel panel_ConductSurvey;
    }
}