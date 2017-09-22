namespace MDAMS
{
    partial class FrmSplashScreen
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblMsg = new MetroFramework.Controls.MetroLabel();
            this.progLoad = new MetroFramework.Controls.MetroProgressBar();
            this.lblShopName = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::MDAMS.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(234, 48);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(170, 135);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(52, 322);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(71, 19);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "Loading.....";
            // 
            // progLoad
            // 
            this.progLoad.Location = new System.Drawing.Point(52, 278);
            this.progLoad.Name = "progLoad";
            this.progLoad.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progLoad.Size = new System.Drawing.Size(586, 23);
            this.progLoad.TabIndex = 3;
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopName.Location = new System.Drawing.Point(44, 194);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(90, 43);
            this.lblShopName.TabIndex = 4;
            this.lblShopName.Text = "label1";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(2, 6);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(656, 36);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 361);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.lblShopName);
            this.Controls.Add(this.progLoad);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.picLogo);
            this.Name = "FrmSplashScreen";
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroLabel lblMsg;
        private MetroFramework.Controls.MetroProgressBar progLoad;
        private System.Windows.Forms.Label lblShopName;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}