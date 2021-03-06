﻿using SplashScreen;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MDAMS
{
    public partial class FrmHome : MetroFramework.Forms.MetroForm
    {
        public FrmHome()
        {
            Thread thread = new Thread(new ThreadStart(Splash));
            thread.Start();

            InitializeComponent();
            string str = String.Empty;
            for (int i = 0; i < 100000; i++)
            {
                str += i.ToString();
            }
            thread.Abort();
        }

        public void Splash()
        {
            SplashForm splashForm = new SplashForm();
            splashForm.AppName = AppGlobalDatas.StoreName;
            splashForm.Icon = Image.FromFile(AppGlobalDatas.LogoImage);
            Application.Run(splashForm);
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            hoverToolName.Text = "";
        }

        private void picAddMedicine_Click(object sender, EventArgs e)
        {
            picAddMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            (new FrmImportHome()).Show();
        }

        private void picUpdateMedicine_Click(object sender, EventArgs e)
        {
            picUpdateMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            (new FrmUpdateHome()).Show();
        }

        private void picViewMedicines_Click(object sender, EventArgs e)
        {
            picViewMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            (new FrmViewMedicine()).Show();
        }

        private void picDeleteMedicine_Click(object sender, EventArgs e)
        {
            picDeleteMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            (new FrmUpdateMedicine()).Show();
        }

        private void picPrepareBill_Click(object sender, EventArgs e)
        {
            picPrepareBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            (new FrmReport()).Show();
        }

        private void picGenerateReport_Click(object sender, EventArgs e)
        {
            picGenerateReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            (new FrmReport()).Show();
        }

        #region Hover Handlers

        private void picAddMedicine_MouseEnter(object sender, EventArgs e)
        {
            ClearHoverEffects();
            picAddMedicine.BackColor = Color.LightGray;
            //picAddMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            hoverToolName.Text = @"Insert New Medicine";
        }

        private void picAddMedicine_MouseLeave(object sender, EventArgs e)
        {
            picAddMedicine.BackColor = Color.White;
            picAddMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            hoverToolName.Text = "";
        }

        private void picUpdateMedicine_MouseEnter(object sender, EventArgs e)
        {
            ClearHoverEffects();
            picUpdateMedicine.BackColor = Color.LightGray;
            // picUpdateMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            hoverToolName.Text = @"Update Medicine Details";
        }

        private void picUpdateMedicine_MouseLeave(object sender, EventArgs e)
        {
            picUpdateMedicine.BackColor = Color.White;
            picUpdateMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            hoverToolName.Text = "";
        }

        private void picDeleteMedicine_MouseEnter(object sender, EventArgs e)
        {
            ClearHoverEffects();
            picDeleteMedicine.BackColor = Color.LightGray;
            //picDeleteMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            hoverToolName.Text = @"Delete Medicine";
        }

        private void picDeleteMedicine_MouseLeave(object sender, EventArgs e)
        {
            picDeleteMedicine.BackColor = Color.White;
            picDeleteMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            hoverToolName.Text = "";
        }

        private void picViewMedicines_MouseEnter(object sender, EventArgs e)
        {
            ClearHoverEffects();
            picViewMedicines.BackColor = Color.LightGray;
            //picViewMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            hoverToolName.Text = @"View Medicine";
        }

        private void picViewMedicines_MouseLeave(object sender, EventArgs e)
        {
            picViewMedicines.BackColor = Color.White;
            picViewMedicines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            hoverToolName.Text = "";
        }

        private void picPrepareBill_MouseEnter(object sender, EventArgs e)
        {
            ClearHoverEffects();
            picPrepareBill.BackColor = Color.LightGray;
            //picPrepareBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            hoverToolName.Text = @"Prepare Bill";
        }

        private void picPrepareBill_MouseLeave(object sender, EventArgs e)
        {
            picPrepareBill.BackColor = Color.White;
            picPrepareBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            hoverToolName.Text = "";
        }

        private void picGenerateReport_MouseEnter(object sender, EventArgs e)
        {
            ClearHoverEffects();
            picGenerateReport.BackColor = Color.LightGray;
            //picGenerateReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            hoverToolName.Text = @"Generate Monthly Report";
        }

        private void picGenerateReport_MouseLeave(object sender, EventArgs e)
        {
            picGenerateReport.BackColor = Color.White;
            picGenerateReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            hoverToolName.Text = "";
        }

        private void ClearHoverEffects()
        {
            picAddMedicine.BackColor = Color.White;
            picAddMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            picUpdateMedicine.BackColor = Color.White;
            picUpdateMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            picDeleteMedicine.BackColor = Color.White;
            picDeleteMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            picViewMedicines.BackColor = Color.White;
            picViewMedicines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            picPrepareBill.BackColor = Color.White;
            picPrepareBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            picGenerateReport.BackColor = Color.White;
            picGenerateReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            hoverToolName.Text = String.Empty;
        }


        #endregion

    }
}
