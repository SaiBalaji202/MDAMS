namespace MDAMS
{
    partial class FrmViewMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtDrugNo = new MetroFramework.Controls.MetroTextBox();
            this.txtMRP = new MetroFramework.Controls.MetroTextBox();
            this.txtUnitSize = new MetroFramework.Controls.MetroTextBox();
            this.txtGrp = new MetroFramework.Controls.MetroTextBox();
            this.txtMedName = new MetroFramework.Controls.MetroTextBox();
            this.gridData = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtGrp);
            this.metroPanel1.Controls.Add(this.txtMRP);
            this.metroPanel1.Controls.Add(this.txtDrugNo);
            this.metroPanel1.Controls.Add(this.txtUnitSize);
            this.metroPanel1.Controls.Add(this.txtMedName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(539, 111);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.gridData);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(24, 203);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(539, 226);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // txtDrugNo
            // 
            this.txtDrugNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDrugNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.txtDrugNo.Location = new System.Drawing.Point(27, 25);
            this.txtDrugNo.MaxLength = 32767;
            this.txtDrugNo.Name = "txtDrugNo";
            this.txtDrugNo.PasswordChar = '\0';
            this.txtDrugNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDrugNo.SelectedText = "";
            this.txtDrugNo.SelectionLength = 0;
            this.txtDrugNo.SelectionStart = 0;
            this.txtDrugNo.ShortcutsEnabled = true;
            this.txtDrugNo.Size = new System.Drawing.Size(95, 23);
            this.txtDrugNo.TabIndex = 1;
            this.txtDrugNo.UseSelectable = true;
            this.txtDrugNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDrugNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDrugNo.TextChanged += new System.EventHandler(this.txtDrugNo_TextChanged);
            // 
            // txtMRP
            // 
            this.txtMRP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMRP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.txtMRP.Location = new System.Drawing.Point(89, 75);
            this.txtMRP.MaxLength = 32767;
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.PasswordChar = '\0';
            this.txtMRP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMRP.SelectedText = "";
            this.txtMRP.SelectionLength = 0;
            this.txtMRP.SelectionStart = 0;
            this.txtMRP.ShortcutsEnabled = true;
            this.txtMRP.Size = new System.Drawing.Size(95, 23);
            this.txtMRP.TabIndex = 4;
            this.txtMRP.UseSelectable = true;
            this.txtMRP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMRP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMRP.TextChanged += new System.EventHandler(this.txtDrugNo_TextChanged);
            // 
            // txtUnitSize
            // 
            this.txtUnitSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnitSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.txtUnitSize.Location = new System.Drawing.Point(408, 25);
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
            this.txtUnitSize.TextChanged += new System.EventHandler(this.txtDrugNo_TextChanged);
            // 
            // txtGrp
            // 
            this.txtGrp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGrp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.txtGrp.Location = new System.Drawing.Point(235, 75);
            this.txtGrp.MaxLength = 32767;
            this.txtGrp.Name = "txtGrp";
            this.txtGrp.PasswordChar = '\0';
            this.txtGrp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrp.SelectedText = "";
            this.txtGrp.SelectionLength = 0;
            this.txtGrp.SelectionStart = 0;
            this.txtGrp.ShortcutsEnabled = true;
            this.txtGrp.Size = new System.Drawing.Size(211, 23);
            this.txtGrp.TabIndex = 5;
            this.txtGrp.UseSelectable = true;
            this.txtGrp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGrp.TextChanged += new System.EventHandler(this.txtDrugNo_TextChanged);
            // 
            // txtMedName
            // 
            this.txtMedName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMedName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.txtMedName.Location = new System.Drawing.Point(164, 25);
            this.txtMedName.MaxLength = 32767;
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.PasswordChar = '\0';
            this.txtMedName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMedName.SelectedText = "";
            this.txtMedName.SelectionLength = 0;
            this.txtMedName.SelectionStart = 0;
            this.txtMedName.ShortcutsEnabled = true;
            this.txtMedName.Size = new System.Drawing.Size(211, 23);
            this.txtMedName.TabIndex = 2;
            this.txtMedName.UseSelectable = true;
            this.txtMedName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMedName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMedName.TextChanged += new System.EventHandler(this.txtDrugNo_TextChanged);
            // 
            // gridData
            // 
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.Location = new System.Drawing.Point(0, 0);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(539, 226);
            this.gridData.TabIndex = 2;
            // 
            // FrmViewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 461);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmViewMedicine";
            this.Text = "View Medicine Details";
            this.Load += new System.EventHandler(this.FrmViewMedicine_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtGrp;
        private MetroFramework.Controls.MetroTextBox txtMRP;
        private MetroFramework.Controls.MetroTextBox txtDrugNo;
        private MetroFramework.Controls.MetroTextBox txtUnitSize;
        private MetroFramework.Controls.MetroTextBox txtMedName;
        private MetroFramework.Controls.MetroGrid gridData;
    }
}