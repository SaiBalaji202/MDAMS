namespace MDAMS
{
    partial class FrmHome
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
            this.panelGroupControls = new MetroFramework.Controls.MetroPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.hoverToolName = new System.Windows.Forms.ToolStripStatusLabel();
            this.picDeleteMedicine = new System.Windows.Forms.PictureBox();
            this.picPrepareBill = new System.Windows.Forms.PictureBox();
            this.picViewMedicines = new System.Windows.Forms.PictureBox();
            this.picUpdateMedicine = new System.Windows.Forms.PictureBox();
            this.picAddMedicine = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picGenerateReport = new System.Windows.Forms.PictureBox();
            this.panelGroupControls.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrepareBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGenerateReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroupControls
            // 
            this.panelGroupControls.Controls.Add(this.statusStrip1);
            this.panelGroupControls.Controls.Add(this.picDeleteMedicine);
            this.panelGroupControls.Controls.Add(this.picGenerateReport);
            this.panelGroupControls.Controls.Add(this.picPrepareBill);
            this.panelGroupControls.Controls.Add(this.picViewMedicines);
            this.panelGroupControls.Controls.Add(this.picUpdateMedicine);
            this.panelGroupControls.Controls.Add(this.picAddMedicine);
            this.panelGroupControls.HorizontalScrollbarBarColor = true;
            this.panelGroupControls.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGroupControls.HorizontalScrollbarSize = 10;
            this.panelGroupControls.Location = new System.Drawing.Point(24, 73);
            this.panelGroupControls.Name = "panelGroupControls";
            this.panelGroupControls.Size = new System.Drawing.Size(438, 320);
            this.panelGroupControls.TabIndex = 0;
            this.panelGroupControls.VerticalScrollbarBarColor = true;
            this.panelGroupControls.VerticalScrollbarHighlightOnWheel = false;
            this.panelGroupControls.VerticalScrollbarSize = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoverToolName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(438, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // hoverToolName
            // 
            this.hoverToolName.Name = "hoverToolName";
            this.hoverToolName.Size = new System.Drawing.Size(118, 17);
            this.hoverToolName.Text = "toolStripStatusLabel1";
            // 
            // picDeleteMedicine
            // 
            this.picDeleteMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDeleteMedicine.Image = global::MDAMS.Properties.Resources.Delete_Icon;
            this.picDeleteMedicine.Location = new System.Drawing.Point(338, 19);
            this.picDeleteMedicine.Name = "picDeleteMedicine";
            this.picDeleteMedicine.Size = new System.Drawing.Size(84, 89);
            this.picDeleteMedicine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeleteMedicine.TabIndex = 2;
            this.picDeleteMedicine.TabStop = false;
            this.picDeleteMedicine.Click += new System.EventHandler(this.picDeleteMedicine_Click);
            this.picDeleteMedicine.MouseEnter += new System.EventHandler(this.picDeleteMedicine_MouseEnter);
            this.picDeleteMedicine.MouseLeave += new System.EventHandler(this.picDeleteMedicine_MouseLeave);
            // 
            // picPrepareBill
            // 
            this.picPrepareBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPrepareBill.Image = global::MDAMS.Properties.Resources.bill;
            this.picPrepareBill.Location = new System.Drawing.Point(172, 172);
            this.picPrepareBill.Name = "picPrepareBill";
            this.picPrepareBill.Size = new System.Drawing.Size(84, 89);
            this.picPrepareBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrepareBill.TabIndex = 2;
            this.picPrepareBill.TabStop = false;
            this.picPrepareBill.Click += new System.EventHandler(this.picPrepareBill_Click);
            this.picPrepareBill.MouseEnter += new System.EventHandler(this.picPrepareBill_MouseEnter);
            this.picPrepareBill.MouseLeave += new System.EventHandler(this.picPrepareBill_MouseLeave);
            // 
            // picViewMedicines
            // 
            this.picViewMedicines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picViewMedicines.Image = global::MDAMS.Properties.Resources.view_512;
            this.picViewMedicines.Location = new System.Drawing.Point(18, 172);
            this.picViewMedicines.Name = "picViewMedicines";
            this.picViewMedicines.Size = new System.Drawing.Size(84, 89);
            this.picViewMedicines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picViewMedicines.TabIndex = 2;
            this.picViewMedicines.TabStop = false;
            this.picViewMedicines.Click += new System.EventHandler(this.picViewMedicines_Click);
            this.picViewMedicines.MouseEnter += new System.EventHandler(this.picViewMedicines_MouseEnter);
            this.picViewMedicines.MouseLeave += new System.EventHandler(this.picViewMedicines_MouseLeave);
            // 
            // picUpdateMedicine
            // 
            this.picUpdateMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUpdateMedicine.Image = global::MDAMS.Properties.Resources.website_update;
            this.picUpdateMedicine.Location = new System.Drawing.Point(172, 19);
            this.picUpdateMedicine.Name = "picUpdateMedicine";
            this.picUpdateMedicine.Size = new System.Drawing.Size(84, 89);
            this.picUpdateMedicine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdateMedicine.TabIndex = 2;
            this.picUpdateMedicine.TabStop = false;
            this.picUpdateMedicine.Click += new System.EventHandler(this.picUpdateMedicine_Click);
            this.picUpdateMedicine.MouseEnter += new System.EventHandler(this.picUpdateMedicine_MouseEnter);
            this.picUpdateMedicine.MouseLeave += new System.EventHandler(this.picUpdateMedicine_MouseLeave);
            // 
            // picAddMedicine
            // 
            this.picAddMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAddMedicine.Image = global::MDAMS.Properties.Resources.insert_table1600;
            this.picAddMedicine.Location = new System.Drawing.Point(18, 19);
            this.picAddMedicine.Name = "picAddMedicine";
            this.picAddMedicine.Size = new System.Drawing.Size(84, 89);
            this.picAddMedicine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddMedicine.TabIndex = 2;
            this.picAddMedicine.TabStop = false;
            this.picAddMedicine.Click += new System.EventHandler(this.picAddMedicine_Click);
            this.picAddMedicine.MouseEnter += new System.EventHandler(this.picAddMedicine_MouseEnter);
            this.picAddMedicine.MouseLeave += new System.EventHandler(this.picAddMedicine_MouseLeave);
            // 
            // picGenerateReport
            // 
            this.picGenerateReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGenerateReport.Image = global::MDAMS.Properties.Resources.report_icon_23;
            this.picGenerateReport.Location = new System.Drawing.Point(338, 172);
            this.picGenerateReport.Name = "picGenerateReport";
            this.picGenerateReport.Size = new System.Drawing.Size(84, 89);
            this.picGenerateReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGenerateReport.TabIndex = 2;
            this.picGenerateReport.TabStop = false;
            this.picGenerateReport.Click += new System.EventHandler(this.picGenerateReport_Click);
            this.picGenerateReport.MouseEnter += new System.EventHandler(this.picGenerateReport_MouseEnter);
            this.picGenerateReport.MouseLeave += new System.EventHandler(this.picGenerateReport_MouseLeave);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 416);
            this.Controls.Add(this.panelGroupControls);
            this.Name = "FrmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panelGroupControls.ResumeLayout(false);
            this.panelGroupControls.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrepareBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGenerateReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelGroupControls;
        private System.Windows.Forms.PictureBox picAddMedicine;
        private System.Windows.Forms.PictureBox picDeleteMedicine;
        private System.Windows.Forms.PictureBox picUpdateMedicine;
        private System.Windows.Forms.PictureBox picPrepareBill;
        private System.Windows.Forms.PictureBox picViewMedicines;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel hoverToolName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picGenerateReport;
    }
}