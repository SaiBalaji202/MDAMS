namespace MDAMS
{
    partial class Form1
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
            this.picImportMedicineData = new System.Windows.Forms.PictureBox();
            this.picImportFile = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.hoverToolName = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picImportMedicineData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImportFile)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImportMedicineData
            // 
            this.picImportMedicineData.Image = global::MDAMS.Properties.Resources.Import2;
            this.picImportMedicineData.Location = new System.Drawing.Point(285, 147);
            this.picImportMedicineData.Name = "picImportMedicineData";
            this.picImportMedicineData.Size = new System.Drawing.Size(118, 102);
            this.picImportMedicineData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImportMedicineData.TabIndex = 0;
            this.picImportMedicineData.TabStop = false;
            this.toolTip1.SetToolTip(this.picImportMedicineData, "Add New Medicine Data");
            this.picImportMedicineData.Click += new System.EventHandler(this.picImportMedicineData_Click);
            this.picImportMedicineData.MouseEnter += new System.EventHandler(this.picImportMedicineData_MouseEnter);
            this.picImportMedicineData.MouseLeave += new System.EventHandler(this.picImportMedicineData_MouseLeave);
            // 
            // picImportFile
            // 
            this.picImportFile.Image = global::MDAMS.Properties.Resources.import_folder;
            this.picImportFile.Location = new System.Drawing.Point(87, 147);
            this.picImportFile.Name = "picImportFile";
            this.picImportFile.Size = new System.Drawing.Size(118, 102);
            this.picImportFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImportFile.TabIndex = 0;
            this.picImportFile.TabStop = false;
            this.toolTip1.SetToolTip(this.picImportFile, "Import Excel Data");
            this.picImportFile.Click += new System.EventHandler(this.picImportFile_Click);
            this.picImportFile.MouseEnter += new System.EventHandler(this.picImportFile_MouseEnter);
            this.picImportFile.MouseLeave += new System.EventHandler(this.picImportFile_MouseLeave);
            this.picImportFile.MouseHover += new System.EventHandler(this.picImportFile_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoverToolName});
            this.statusStrip1.Location = new System.Drawing.Point(20, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(477, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // hoverToolName
            // 
            this.hoverToolName.Name = "hoverToolName";
            this.hoverToolName.Size = new System.Drawing.Size(118, 17);
            this.hoverToolName.Text = "toolStripStatusLabel1";
            this.hoverToolName.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 397);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picImportFile);
            this.Controls.Add(this.picImportMedicineData);
            this.Name = "Form1";
            this.Text = "Import New Medicine";
            ((System.ComponentModel.ISupportInitialize)(this.picImportMedicineData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImportFile)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImportMedicineData;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picImportFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel hoverToolName;
    }
}

