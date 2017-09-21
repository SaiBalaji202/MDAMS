namespace MDAMS
{
    partial class FrmImportExcel
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
            this.btnImportToDB = new MetroFramework.Controls.MetroButton();
            this.comboAvailSheets = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.progLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.picExcel = new System.Windows.Forms.PictureBox();
            this.picBrowseExcel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowseExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportToDB
            // 
            this.btnImportToDB.Location = new System.Drawing.Point(249, 311);
            this.btnImportToDB.Name = "btnImportToDB";
            this.btnImportToDB.Size = new System.Drawing.Size(137, 33);
            this.btnImportToDB.TabIndex = 1;
            this.btnImportToDB.Text = "Import";
            this.btnImportToDB.UseSelectable = true;
            this.btnImportToDB.Click += new System.EventHandler(this.btnImportToDB_Click);
            // 
            // comboAvailSheets
            // 
            this.comboAvailSheets.FormattingEnabled = true;
            this.comboAvailSheets.ItemHeight = 23;
            this.comboAvailSheets.Location = new System.Drawing.Point(217, 256);
            this.comboAvailSheets.Name = "comboAvailSheets";
            this.comboAvailSheets.Size = new System.Drawing.Size(217, 29);
            this.comboAvailSheets.TabIndex = 2;
            this.comboAvailSheets.UseSelectable = true;
            this.comboAvailSheets.SelectedIndexChanged += new System.EventHandler(this.comboAvailSheets_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(99, 266);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Available Sheets";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.progLine});
            this.shapeContainer1.Size = new System.Drawing.Size(579, 354);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // progLine
            // 
            this.progLine.Name = "progLine";
            this.progLine.X1 = 4;
            this.progLine.X2 = 20;
            this.progLine.Y1 = 2;
            this.progLine.Y2 = 2;
            // 
            // picLoad
            // 
            this.picLoad.Image = global::MDAMS.Properties.Resources.giphy;
            this.picLoad.Location = new System.Drawing.Point(451, 247);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(47, 47);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoad.TabIndex = 6;
            this.picLoad.TabStop = false;
            // 
            // picExcel
            // 
            this.picExcel.Image = global::MDAMS.Properties.Resources.excel_8;
            this.picExcel.Location = new System.Drawing.Point(229, 174);
            this.picExcel.Name = "picExcel";
            this.picExcel.Size = new System.Drawing.Size(56, 64);
            this.picExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExcel.TabIndex = 4;
            this.picExcel.TabStop = false;
            this.picExcel.Click += new System.EventHandler(this.picExcel_Click);
            // 
            // picBrowseExcel
            // 
            this.picBrowseExcel.Image = global::MDAMS.Properties.Resources.Import2;
            this.picBrowseExcel.Location = new System.Drawing.Point(229, 102);
            this.picBrowseExcel.Name = "picBrowseExcel";
            this.picBrowseExcel.Size = new System.Drawing.Size(167, 136);
            this.picBrowseExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBrowseExcel.TabIndex = 0;
            this.picBrowseExcel.TabStop = false;
            this.picBrowseExcel.Click += new System.EventHandler(this.picBrowseExcel_Click);
            this.picBrowseExcel.MouseEnter += new System.EventHandler(this.picBrowseExcel_MouseEnter);
            this.picBrowseExcel.MouseLeave += new System.EventHandler(this.picBrowseExcel_MouseLeave);
            // 
            // FrmImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 434);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.picExcel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboAvailSheets);
            this.Controls.Add(this.btnImportToDB);
            this.Controls.Add(this.picBrowseExcel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FrmImportExcel";
            this.Text = "Import Excel Medical Data";
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowseExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBrowseExcel;
        private MetroFramework.Controls.MetroButton btnImportToDB;
        private MetroFramework.Controls.MetroComboBox comboAvailSheets;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox picExcel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape progLine;
        private System.Windows.Forms.PictureBox picLoad;
    }
}