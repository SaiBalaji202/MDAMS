namespace MDAMS
{
    partial class FrmPrintBill
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.reportBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.reportBill);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(471, 309);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // reportBill
            // 
            this.reportBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBill.LocalReport.ReportEmbeddedResource = "MDAMS.rptReceipt.rdlc";
            this.reportBill.Location = new System.Drawing.Point(0, 0);
            this.reportBill.Name = "reportBill";
            this.reportBill.ServerReport.BearerToken = null;
            this.reportBill.Size = new System.Drawing.Size(471, 309);
            this.reportBill.TabIndex = 2;
            // 
            // FrmPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 389);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmPrintBill";
            this.Text = "Print Bill";
            this.Load += new System.EventHandler(this.FrmPrintBill_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportBill;
    }
}