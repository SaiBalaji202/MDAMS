namespace MDAMS
{
    partial class FrmMedicalDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicalDetails));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.picClear = new System.Windows.Forms.PictureBox();
            this.btnAddDetails = new MetroFramework.Controls.MetroButton();
            this.txtMRP = new MetroFramework.Controls.MetroTextBox();
            this.txtUnitSize = new MetroFramework.Controls.MetroTextBox();
            this.txtGrp = new MetroFramework.Controls.MetroTextBox();
            this.txtMedName = new MetroFramework.Controls.MetroTextBox();
            this.txtDrugNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picBack = new System.Windows.Forms.PictureBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.picClear);
            this.metroPanel1.Controls.Add(this.btnAddDetails);
            this.metroPanel1.Controls.Add(this.txtMRP);
            this.metroPanel1.Controls.Add(this.txtUnitSize);
            this.metroPanel1.Controls.Add(this.txtGrp);
            this.metroPanel1.Controls.Add(this.txtMedName);
            this.metroPanel1.Controls.Add(this.txtDrugNo);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 76);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(473, 309);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // picClear
            // 
            this.picClear.Image = global::MDAMS.Properties.Resources.clear3;
            this.picClear.Location = new System.Drawing.Point(90, 257);
            this.picClear.Name = "picClear";
            this.picClear.Size = new System.Drawing.Size(39, 36);
            this.picClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClear.TabIndex = 5;
            this.picClear.TabStop = false;
            this.toolTip1.SetToolTip(this.picClear, "Clear All Data");
            this.picClear.Click += new System.EventHandler(this.picClear_Click);
            this.picClear.MouseEnter += new System.EventHandler(this.picClear_MouseEnter);
            this.picClear.MouseLeave += new System.EventHandler(this.picClear_MouseLeave);
            // 
            // btnAddDetails
            // 
            this.btnAddDetails.Location = new System.Drawing.Point(159, 257);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(114, 36);
            this.btnAddDetails.TabIndex = 4;
            this.btnAddDetails.Text = "Add Details";
            this.btnAddDetails.UseSelectable = true;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // txtMRP
            // 
            // 
            // 
            // 
            this.txtMRP.CustomButton.Image = null;
            this.txtMRP.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtMRP.CustomButton.Name = "";
            this.txtMRP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMRP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMRP.CustomButton.TabIndex = 1;
            this.txtMRP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMRP.CustomButton.UseSelectable = true;
            this.txtMRP.CustomButton.Visible = false;
            this.txtMRP.Lines = new string[0];
            this.txtMRP.Location = new System.Drawing.Point(178, 169);
            this.txtMRP.MaxLength = 32767;
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.PasswordChar = '\0';
            this.txtMRP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMRP.SelectedText = "";
            this.txtMRP.SelectionLength = 0;
            this.txtMRP.SelectionStart = 0;
            this.txtMRP.ShortcutsEnabled = true;
            this.txtMRP.Size = new System.Drawing.Size(95, 23);
            this.txtMRP.TabIndex = 3;
            this.txtMRP.UseSelectable = true;
            this.txtMRP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMRP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMRP.Validating += new System.ComponentModel.CancelEventHandler(this.txtMRP_Validating);
            // 
            // txtUnitSize
            // 
            // 
            // 
            // 
            this.txtUnitSize.CustomButton.Image = null;
            this.txtUnitSize.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtUnitSize.CustomButton.Name = "";
            this.txtUnitSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnitSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitSize.CustomButton.TabIndex = 1;
            this.txtUnitSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitSize.CustomButton.UseSelectable = true;
            this.txtUnitSize.CustomButton.Visible = false;
            this.txtUnitSize.Lines = new string[0];
            this.txtUnitSize.Location = new System.Drawing.Point(178, 124);
            this.txtUnitSize.MaxLength = 32767;
            this.txtUnitSize.Name = "txtUnitSize";
            this.txtUnitSize.PasswordChar = '\0';
            this.txtUnitSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitSize.SelectedText = "";
            this.txtUnitSize.SelectionLength = 0;
            this.txtUnitSize.SelectionStart = 0;
            this.txtUnitSize.ShortcutsEnabled = true;
            this.txtUnitSize.Size = new System.Drawing.Size(95, 23);
            this.txtUnitSize.TabIndex = 3;
            this.txtUnitSize.UseSelectable = true;
            this.txtUnitSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGrp
            // 
            // 
            // 
            // 
            this.txtGrp.CustomButton.Image = null;
            this.txtGrp.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtGrp.CustomButton.Name = "";
            this.txtGrp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGrp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrp.CustomButton.TabIndex = 1;
            this.txtGrp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrp.CustomButton.UseSelectable = true;
            this.txtGrp.CustomButton.Visible = false;
            this.txtGrp.Lines = new string[0];
            this.txtGrp.Location = new System.Drawing.Point(178, 215);
            this.txtGrp.MaxLength = 32767;
            this.txtGrp.Name = "txtGrp";
            this.txtGrp.PasswordChar = '\0';
            this.txtGrp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrp.SelectedText = "";
            this.txtGrp.SelectionLength = 0;
            this.txtGrp.SelectionStart = 0;
            this.txtGrp.ShortcutsEnabled = true;
            this.txtGrp.Size = new System.Drawing.Size(211, 23);
            this.txtGrp.TabIndex = 3;
            this.txtGrp.UseSelectable = true;
            this.txtGrp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMedName
            // 
            // 
            // 
            // 
            this.txtMedName.CustomButton.Image = null;
            this.txtMedName.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtMedName.CustomButton.Name = "";
            this.txtMedName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMedName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMedName.CustomButton.TabIndex = 1;
            this.txtMedName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMedName.CustomButton.UseSelectable = true;
            this.txtMedName.CustomButton.Visible = false;
            this.txtMedName.Lines = new string[0];
            this.txtMedName.Location = new System.Drawing.Point(178, 76);
            this.txtMedName.MaxLength = 32767;
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.PasswordChar = '\0';
            this.txtMedName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMedName.SelectedText = "";
            this.txtMedName.SelectionLength = 0;
            this.txtMedName.SelectionStart = 0;
            this.txtMedName.ShortcutsEnabled = true;
            this.txtMedName.Size = new System.Drawing.Size(211, 23);
            this.txtMedName.TabIndex = 3;
            this.txtMedName.UseSelectable = true;
            this.txtMedName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMedName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDrugNo
            // 
            // 
            // 
            // 
            this.txtDrugNo.CustomButton.Image = null;
            this.txtDrugNo.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtDrugNo.CustomButton.Name = "";
            this.txtDrugNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDrugNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDrugNo.CustomButton.TabIndex = 1;
            this.txtDrugNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDrugNo.CustomButton.UseSelectable = true;
            this.txtDrugNo.CustomButton.Visible = false;
            this.txtDrugNo.Lines = new string[0];
            this.txtDrugNo.Location = new System.Drawing.Point(178, 24);
            this.txtDrugNo.MaxLength = 32767;
            this.txtDrugNo.Name = "txtDrugNo";
            this.txtDrugNo.PasswordChar = '\0';
            this.txtDrugNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDrugNo.SelectedText = "";
            this.txtDrugNo.SelectionLength = 0;
            this.txtDrugNo.SelectionStart = 0;
            this.txtDrugNo.ShortcutsEnabled = true;
            this.txtDrugNo.Size = new System.Drawing.Size(95, 23);
            this.txtDrugNo.TabIndex = 3;
            this.txtDrugNo.UseSelectable = true;
            this.txtDrugNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDrugNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDrugNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtDrugNo_Validating);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(28, 219);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(125, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Therapeutic Group: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 173);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "MRP: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Unit Size: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Name of the Product: ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Drug No: ";
            // 
            // picBack
            // 
            this.picBack.Image = global::MDAMS.Properties.Resources.back3;
            this.picBack.Location = new System.Drawing.Point(23, 24);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(39, 36);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 5;
            this.picBack.TabStop = false;
            this.toolTip1.SetToolTip(this.picBack, "Back");
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            this.picBack.MouseEnter += new System.EventHandler(this.picBack_MouseEnter);
            this.picBack.MouseLeave += new System.EventHandler(this.picBack_MouseLeave);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            this.erp.Icon = ((System.Drawing.Icon)(resources.GetObject("erp.Icon")));
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(183, 333);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(114, 36);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Add Details";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // FrmMedicalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 408);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButton1);
            this.Name = "FrmMedicalDetails";
            this.Text = "      New Medical Details";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDrugNo;
        private MetroFramework.Controls.MetroTextBox txtMRP;
        private MetroFramework.Controls.MetroTextBox txtUnitSize;
        private MetroFramework.Controls.MetroTextBox txtGrp;
        private MetroFramework.Controls.MetroTextBox txtMedName;
        private MetroFramework.Controls.MetroButton btnAddDetails;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.PictureBox picClear;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}