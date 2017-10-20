using MetroFramework;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDAMS
{
    partial class FrmUpdateExcel
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
            if (_backTask != null)
            {
                if (_backTask.Status == TaskStatus.Running)
                {
                    var res = MetroMessageBox.Show(this, @"Some Background Task is Running.  So, you can't able to close this Form right now.  It takes some seconds.  You still want to Force Close", @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.No)
                        return;
                }
            }
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
            this.toggleOnOff = new MetroFramework.Controls.MetroCheckBox();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.picExcel = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboAvailSheets = new MetroFramework.Controls.MetroComboBox();
            this.btnUpdateDB = new MetroFramework.Controls.MetroButton();
            this.picBrowseExcel = new System.Windows.Forms.PictureBox();
            this.lblLoadMsg = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowseExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleOnOff
            // 
            this.toggleOnOff.Appearance = System.Windows.Forms.Appearance.Button;
            this.toggleOnOff.AutoSize = true;
            this.toggleOnOff.Location = new System.Drawing.Point(387, 340);
            this.toggleOnOff.Name = "toggleOnOff";
            this.toggleOnOff.Size = new System.Drawing.Size(109, 15);
            this.toggleOnOff.TabIndex = 14;
            this.toggleOnOff.Text = "Auto Update On";
            this.toggleOnOff.UseSelectable = true;
            this.toggleOnOff.CheckedChanged += new System.EventHandler(this.toggleOnOff_CheckedChanged);
            // 
            // picLoad
            // 
            this.picLoad.Image = global::MDAMS.Properties.Resources._3;
            this.picLoad.Location = new System.Drawing.Point(387, 225);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(47, 47);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoad.TabIndex = 13;
            this.picLoad.TabStop = false;
            // 
            // picExcel
            // 
            this.picExcel.Image = global::MDAMS.Properties.Resources.excel_8;
            this.picExcel.Location = new System.Drawing.Point(167, 159);
            this.picExcel.Name = "picExcel";
            this.picExcel.Size = new System.Drawing.Size(56, 64);
            this.picExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExcel.TabIndex = 12;
            this.picExcel.TabStop = false;
            this.picExcel.Click += new System.EventHandler(this.picBrowseExcel_Click);
            this.picExcel.MouseEnter += new System.EventHandler(this.picExcel_MouseEnter);
            this.picExcel.MouseLeave += new System.EventHandler(this.picExcel_MouseLeave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 253);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Available Sheets";
            // 
            // comboAvailSheets
            // 
            this.comboAvailSheets.FormattingEnabled = true;
            this.comboAvailSheets.ItemHeight = 23;
            this.comboAvailSheets.Location = new System.Drawing.Point(153, 243);
            this.comboAvailSheets.Name = "comboAvailSheets";
            this.comboAvailSheets.Size = new System.Drawing.Size(217, 29);
            this.comboAvailSheets.TabIndex = 10;
            this.comboAvailSheets.UseSelectable = true;
            this.comboAvailSheets.SelectedIndexChanged += new System.EventHandler(this.comboAvailSheets_SelectedIndexChanged);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(185, 298);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(137, 33);
            this.btnUpdateDB.TabIndex = 9;
            this.btnUpdateDB.Text = "Update";
            this.btnUpdateDB.UseSelectable = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // picBrowseExcel
            // 
            this.picBrowseExcel.Image = global::MDAMS.Properties.Resources.Import2;
            this.picBrowseExcel.Location = new System.Drawing.Point(165, 89);
            this.picBrowseExcel.Name = "picBrowseExcel";
            this.picBrowseExcel.Size = new System.Drawing.Size(167, 136);
            this.picBrowseExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBrowseExcel.TabIndex = 8;
            this.picBrowseExcel.TabStop = false;
            this.picBrowseExcel.Click += new System.EventHandler(this.picBrowseExcel_Click);
            this.picBrowseExcel.MouseEnter += new System.EventHandler(this.picBrowseExcel_MouseEnter);
            this.picBrowseExcel.MouseLeave += new System.EventHandler(this.picBrowseExcel_MouseLeave);
            // 
            // lblLoadMsg
            // 
            this.lblLoadMsg.AutoSize = true;
            this.lblLoadMsg.Location = new System.Drawing.Point(351, 284);
            this.lblLoadMsg.Name = "lblLoadMsg";
            this.lblLoadMsg.Size = new System.Drawing.Size(0, 0);
            this.lblLoadMsg.TabIndex = 15;
            // 
            // FrmUpdateExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 420);
            this.Controls.Add(this.lblLoadMsg);
            this.Controls.Add(this.toggleOnOff);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.picExcel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboAvailSheets);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.picBrowseExcel);
            this.Name = "FrmUpdateExcel";
            this.Text = "Update Medicine Details Through Excel Data";
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowseExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox toggleOnOff;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.PictureBox picExcel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboAvailSheets;
        private MetroFramework.Controls.MetroButton btnUpdateDB;
        private System.Windows.Forms.PictureBox picBrowseExcel;
        private MetroFramework.Controls.MetroLabel lblLoadMsg;
    }
}