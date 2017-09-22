using SplashScreen;
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

        private void picAddMedicine_Click(object sender, EventArgs e)
        {
            (new FrmImportHome()).Show();
        }

        private void picUpdateMedicine_Click(object sender, EventArgs e)
        {
            (new FrmUpdateHome()).Show();
        }

        #region Hover Handlers

        private void picAddMedicine_MouseEnter(object sender, EventArgs e)
        {
            picAddMedicine.BackColor = Color.LightGray;
        }

        private void picAddMedicine_MouseLeave(object sender, EventArgs e)
        {
            picAddMedicine.BackColor = Color.White;
        }

        private void picUpdateMedicine_MouseEnter(object sender, EventArgs e)
        {
            picUpdateMedicine.BackColor = Color.LightGray;

        }

        private void picUpdateMedicine_MouseLeave(object sender, EventArgs e)
        {
            picUpdateMedicine.BackColor = Color.White;
        }

        private void picDeleteMedicine_MouseEnter(object sender, EventArgs e)
        {
            picDeleteMedicine.BackColor = Color.LightGray;
        }

        private void picDeleteMedicine_MouseLeave(object sender, EventArgs e)
        {
            picDeleteMedicine.BackColor = Color.White;
        }

        private void picViewMedicines_MouseEnter(object sender, EventArgs e)
        {
            picViewMedicines.BackColor = Color.LightGray;
        }

        private void picViewMedicines_MouseLeave(object sender, EventArgs e)
        {
            picViewMedicines.BackColor = Color.White;
        }

        private void picPrepareBill_MouseEnter(object sender, EventArgs e)
        {
            picPrepareBill.BackColor = Color.LightGray;
        }

        private void picPrepareBill_MouseLeave(object sender, EventArgs e)
        {
            picPrepareBill.BackColor = Color.White;
        }

        private void picGenerateReport_MouseEnter(object sender, EventArgs e)
        {
            picGenerateReport.BackColor = Color.LightGray;
        }

        private void picGenerateReport_MouseLeave(object sender, EventArgs e)
        {
            picGenerateReport.BackColor = Color.White;
        }


        #endregion
    }
}
