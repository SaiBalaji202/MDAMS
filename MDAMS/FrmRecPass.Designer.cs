namespace MDAMS
{
    partial class FrmRecPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecPass));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pnlQues = new MetroFramework.Controls.MetroPanel();
            this.lblQ1 = new MetroFramework.Controls.MetroLabel();
            this.lblQ2 = new MetroFramework.Controls.MetroLabel();
            this.lblQ3 = new MetroFramework.Controls.MetroLabel();
            this.btnValidateAnswer = new MetroFramework.Controls.MetroButton();
            this.txtA1 = new MetroFramework.Controls.MetroTextBox();
            this.txtA2 = new MetroFramework.Controls.MetroTextBox();
            this.txtA3 = new MetroFramework.Controls.MetroTextBox();
            this.errp = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlEmail = new MetroFramework.Controls.MetroPanel();
            this.btnValidateEmail = new MetroFramework.Controls.MetroButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtGmailID = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.pnlQues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errp)).BeginInit();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pnlEmail);
            this.metroPanel1.Controls.Add(this.pnlQues);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(602, 420);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pnlQues
            // 
            this.pnlQues.Controls.Add(this.txtA3);
            this.pnlQues.Controls.Add(this.txtA2);
            this.pnlQues.Controls.Add(this.txtA1);
            this.pnlQues.Controls.Add(this.btnValidateAnswer);
            this.pnlQues.Controls.Add(this.lblQ3);
            this.pnlQues.Controls.Add(this.lblQ2);
            this.pnlQues.Controls.Add(this.lblQ1);
            this.pnlQues.HorizontalScrollbarBarColor = true;
            this.pnlQues.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlQues.HorizontalScrollbarSize = 10;
            this.pnlQues.Location = new System.Drawing.Point(15, 113);
            this.pnlQues.Name = "pnlQues";
            this.pnlQues.Size = new System.Drawing.Size(574, 298);
            this.pnlQues.TabIndex = 12;
            this.pnlQues.VerticalScrollbarBarColor = true;
            this.pnlQues.VerticalScrollbarHighlightOnWheel = false;
            this.pnlQues.VerticalScrollbarSize = 10;
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.Location = new System.Drawing.Point(49, 25);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(74, 19);
            this.lblQ1.TabIndex = 2;
            this.lblQ1.Text = "1) Question";
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.Location = new System.Drawing.Point(49, 118);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(76, 19);
            this.lblQ2.TabIndex = 3;
            this.lblQ2.Text = "2) Question";
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.Location = new System.Drawing.Point(49, 212);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(76, 19);
            this.lblQ3.TabIndex = 4;
            this.lblQ3.Text = "3) Question";
            // 
            // btnValidateAnswer
            // 
            this.btnValidateAnswer.Location = new System.Drawing.Point(403, 123);
            this.btnValidateAnswer.Name = "btnValidateAnswer";
            this.btnValidateAnswer.Size = new System.Drawing.Size(109, 79);
            this.btnValidateAnswer.TabIndex = 5;
            this.btnValidateAnswer.Text = "Validate Answer";
            this.btnValidateAnswer.UseSelectable = true;
            this.btnValidateAnswer.Click += new System.EventHandler(this.btnValidateAnswer_Click);
            // 
            // txtA1
            // 
            // 
            // 
            // 
            this.txtA1.CustomButton.Image = null;
            this.txtA1.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtA1.CustomButton.Name = "";
            this.txtA1.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtA1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtA1.CustomButton.TabIndex = 1;
            this.txtA1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtA1.CustomButton.UseSelectable = true;
            this.txtA1.CustomButton.Visible = false;
            this.txtA1.Lines = new string[0];
            this.txtA1.Location = new System.Drawing.Point(103, 47);
            this.txtA1.MaxLength = 32767;
            this.txtA1.Multiline = true;
            this.txtA1.Name = "txtA1";
            this.txtA1.PasswordChar = '\0';
            this.txtA1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtA1.SelectedText = "";
            this.txtA1.SelectionLength = 0;
            this.txtA1.SelectionStart = 0;
            this.txtA1.ShortcutsEnabled = true;
            this.txtA1.Size = new System.Drawing.Size(251, 55);
            this.txtA1.TabIndex = 6;
            this.txtA1.UseSelectable = true;
            this.txtA1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtA1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtA2
            // 
            // 
            // 
            // 
            this.txtA2.CustomButton.Image = null;
            this.txtA2.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtA2.CustomButton.Name = "";
            this.txtA2.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtA2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtA2.CustomButton.TabIndex = 1;
            this.txtA2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtA2.CustomButton.UseSelectable = true;
            this.txtA2.CustomButton.Visible = false;
            this.txtA2.Lines = new string[0];
            this.txtA2.Location = new System.Drawing.Point(103, 140);
            this.txtA2.MaxLength = 32767;
            this.txtA2.Multiline = true;
            this.txtA2.Name = "txtA2";
            this.txtA2.PasswordChar = '\0';
            this.txtA2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtA2.SelectedText = "";
            this.txtA2.SelectionLength = 0;
            this.txtA2.SelectionStart = 0;
            this.txtA2.ShortcutsEnabled = true;
            this.txtA2.Size = new System.Drawing.Size(251, 55);
            this.txtA2.TabIndex = 6;
            this.txtA2.UseSelectable = true;
            this.txtA2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtA2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtA3
            // 
            // 
            // 
            // 
            this.txtA3.CustomButton.Image = null;
            this.txtA3.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtA3.CustomButton.Name = "";
            this.txtA3.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtA3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtA3.CustomButton.TabIndex = 1;
            this.txtA3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtA3.CustomButton.UseSelectable = true;
            this.txtA3.CustomButton.Visible = false;
            this.txtA3.Lines = new string[0];
            this.txtA3.Location = new System.Drawing.Point(103, 231);
            this.txtA3.MaxLength = 32767;
            this.txtA3.Multiline = true;
            this.txtA3.Name = "txtA3";
            this.txtA3.PasswordChar = '\0';
            this.txtA3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtA3.SelectedText = "";
            this.txtA3.SelectionLength = 0;
            this.txtA3.SelectionStart = 0;
            this.txtA3.ShortcutsEnabled = true;
            this.txtA3.Size = new System.Drawing.Size(251, 55);
            this.txtA3.TabIndex = 6;
            this.txtA3.UseSelectable = true;
            this.txtA3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtA3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // errp
            // 
            this.errp.ContainerControl = this;
            this.errp.Icon = ((System.Drawing.Icon)(resources.GetObject("errp.Icon")));
            // 
            // pnlEmail
            // 
            this.pnlEmail.Controls.Add(this.btnValidateEmail);
            this.pnlEmail.Controls.Add(this.pictureBox5);
            this.pnlEmail.Controls.Add(this.txtGmailID);
            this.pnlEmail.HorizontalScrollbarBarColor = true;
            this.pnlEmail.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlEmail.HorizontalScrollbarSize = 10;
            this.pnlEmail.Location = new System.Drawing.Point(15, 18);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(574, 89);
            this.pnlEmail.TabIndex = 13;
            this.pnlEmail.VerticalScrollbarBarColor = true;
            this.pnlEmail.VerticalScrollbarHighlightOnWheel = false;
            this.pnlEmail.VerticalScrollbarSize = 10;
            // 
            // btnValidateEmail
            // 
            this.btnValidateEmail.Location = new System.Drawing.Point(261, 58);
            this.btnValidateEmail.Name = "btnValidateEmail";
            this.btnValidateEmail.Size = new System.Drawing.Size(94, 23);
            this.btnValidateEmail.TabIndex = 14;
            this.btnValidateEmail.Text = "Validate Email";
            this.btnValidateEmail.UseSelectable = true;
            this.btnValidateEmail.Click += new System.EventHandler(this.btnValidateEmail_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MDAMS.Properties.Resources.gmail_1_;
            this.pictureBox5.Location = new System.Drawing.Point(159, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // txtGmailID
            // 
            // 
            // 
            // 
            this.txtGmailID.CustomButton.Image = null;
            this.txtGmailID.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtGmailID.CustomButton.Name = "";
            this.txtGmailID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGmailID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGmailID.CustomButton.TabIndex = 1;
            this.txtGmailID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGmailID.CustomButton.UseSelectable = true;
            this.txtGmailID.CustomButton.Visible = false;
            this.txtGmailID.Lines = new string[0];
            this.txtGmailID.Location = new System.Drawing.Point(227, 14);
            this.txtGmailID.MaxLength = 32767;
            this.txtGmailID.Name = "txtGmailID";
            this.txtGmailID.PasswordChar = '\0';
            this.txtGmailID.PromptText = "Email Id(Gmail)";
            this.txtGmailID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGmailID.SelectedText = "";
            this.txtGmailID.SelectionLength = 0;
            this.txtGmailID.SelectionStart = 0;
            this.txtGmailID.ShortcutsEnabled = true;
            this.txtGmailID.Size = new System.Drawing.Size(189, 23);
            this.txtGmailID.TabIndex = 12;
            this.txtGmailID.UseSelectable = true;
            this.txtGmailID.WaterMark = "Email Id(Gmail)";
            this.txtGmailID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGmailID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGmailID.Validating += new System.ComponentModel.CancelEventHandler(this.txtGmailID_Validating);
            // 
            // FrmRecPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 498);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmRecPass";
            this.Text = "Recover My Password";
            this.Load += new System.EventHandler(this.FrmRecPass_Load);
            this.metroPanel1.ResumeLayout(false);
            this.pnlQues.ResumeLayout(false);
            this.pnlQues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errp)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel pnlQues;
        private MetroFramework.Controls.MetroTextBox txtA3;
        private MetroFramework.Controls.MetroTextBox txtA2;
        private MetroFramework.Controls.MetroTextBox txtA1;
        private MetroFramework.Controls.MetroButton btnValidateAnswer;
        private MetroFramework.Controls.MetroLabel lblQ3;
        private MetroFramework.Controls.MetroLabel lblQ2;
        private MetroFramework.Controls.MetroLabel lblQ1;
        private System.Windows.Forms.ErrorProvider errp;
        private MetroFramework.Controls.MetroPanel pnlEmail;
        private MetroFramework.Controls.MetroButton btnValidateEmail;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MetroFramework.Controls.MetroTextBox txtGmailID;
    }
}