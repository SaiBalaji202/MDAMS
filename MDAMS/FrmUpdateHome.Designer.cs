namespace MDAMS
{
    partial class FrmUpdateHome
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
            this.picUpdateFile = new System.Windows.Forms.PictureBox();
            this.picUpdateMedicineData = new System.Windows.Forms.PictureBox();
            this.hoverToolName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateMedicineData)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picUpdateFile
            // 
            this.picUpdateFile.Image = global::MDAMS.Properties.Resources.import_folder;
            this.picUpdateFile.Location = new System.Drawing.Point(90, 126);
            this.picUpdateFile.Name = "picUpdateFile";
            this.picUpdateFile.Size = new System.Drawing.Size(118, 102);
            this.picUpdateFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdateFile.TabIndex = 2;
            this.picUpdateFile.TabStop = false;
            this.toolTip1.SetToolTip(this.picUpdateFile, "Update Through Excel Data");
            this.picUpdateFile.Click += new System.EventHandler(this.picUpdateFile_Click);
            this.picUpdateFile.MouseEnter += new System.EventHandler(this.picUpdateFile_MouseEnter);
            this.picUpdateFile.MouseLeave += new System.EventHandler(this.picUpdateFile_MouseLeave);
            // 
            // picUpdateMedicineData
            // 
            this.picUpdateMedicineData.Image = global::MDAMS.Properties.Resources.Import2;
            this.picUpdateMedicineData.Location = new System.Drawing.Point(288, 126);
            this.picUpdateMedicineData.Name = "picUpdateMedicineData";
            this.picUpdateMedicineData.Size = new System.Drawing.Size(118, 102);
            this.picUpdateMedicineData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdateMedicineData.TabIndex = 3;
            this.picUpdateMedicineData.TabStop = false;
            this.toolTip1.SetToolTip(this.picUpdateMedicineData, "Update Medicine Data");
            this.picUpdateMedicineData.Click += new System.EventHandler(this.picUpdateMedicineData_Click);
            this.picUpdateMedicineData.MouseEnter += new System.EventHandler(this.picUpdateMedicineData_MouseEnter);
            this.picUpdateMedicineData.MouseLeave += new System.EventHandler(this.picUpdateMedicineData_MouseLeave);
            // 
            // hoverToolName
            // 
            this.hoverToolName.Name = "hoverToolName";
            this.hoverToolName.Size = new System.Drawing.Size(118, 17);
            this.hoverToolName.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoverToolName});
            this.statusStrip1.Location = new System.Drawing.Point(20, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(445, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmUpdateHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 369);
            this.Controls.Add(this.picUpdateFile);
            this.Controls.Add(this.picUpdateMedicineData);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmUpdateHome";
            this.Text = "Update Medicine Details";
            this.Load += new System.EventHandler(this.FrmUpdateHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateMedicineData)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUpdateFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picUpdateMedicineData;
        private System.Windows.Forms.ToolStripStatusLabel hoverToolName;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}