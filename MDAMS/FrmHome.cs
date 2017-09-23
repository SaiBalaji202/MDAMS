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

        private void FrmHome_Load(object sender, EventArgs e)
        {
            hoverToolName.Text = "";
        }

        private void picAddMedicine_Click(object sender, EventArgs e)
        {
            (new FrmImportHome()).Show();
        }

        private void picUpdateMedicine_Click(object sender, EventArgs e)
        {
            (new FrmUpdateHome()).Show();
        }

        private void picViewMedicines_Click(object sender, EventArgs e)
        {
            (new FrmUpdateMedicine()).Show();
        }

        #region Hover Handlers

        private void picAddMedicine_MouseEnter(object sender, EventArgs e)
        {
            picAddMedicine.BackColor = Color.LightGray;
            hoverToolName.Text = "Insert New Medicine";
        }

        private void picAddMedicine_MouseLeave(object sender, EventArgs e)
        {
            picAddMedicine.BackColor = Color.White;
            hoverToolName.Text = "";
        }

        private void picUpdateMedicine_MouseEnter(object sender, EventArgs e)
        {
            picUpdateMedicine.BackColor = Color.LightGray;
            hoverToolName.Text = "Update Medicine Details";
        }

        private void picUpdateMedicine_MouseLeave(object sender, EventArgs e)
        {
            picUpdateMedicine.BackColor = Color.White;
            hoverToolName.Text = "";
        }

        private void picDeleteMedicine_MouseEnter(object sender, EventArgs e)
        {
            picDeleteMedicine.BackColor = Color.LightGray;
            hoverToolName.Text = "Delete Medicine";
        }

        private void picDeleteMedicine_MouseLeave(object sender, EventArgs e)
        {
            picDeleteMedicine.BackColor = Color.White;
            hoverToolName.Text = "";
        }

        private void picViewMedicines_MouseEnter(object sender, EventArgs e)
        {
            picViewMedicines.BackColor = Color.LightGray;
            hoverToolName.Text = "View Medicine";
        }

        private void picViewMedicines_MouseLeave(object sender, EventArgs e)
        {
            picViewMedicines.BackColor = Color.White;
            hoverToolName.Text = "";
        }

        private void picPrepareBill_MouseEnter(object sender, EventArgs e)
        {
            picPrepareBill.BackColor = Color.LightGray;
            hoverToolName.Text = "Prepare Bill";
        }

        private void picPrepareBill_MouseLeave(object sender, EventArgs e)
        {
            picPrepareBill.BackColor = Color.White;
            hoverToolName.Text = "";
        }

        private void picGenerateReport_MouseEnter(object sender, EventArgs e)
        {
            picGenerateReport.BackColor = Color.LightGray;
            hoverToolName.Text = "Generate Monthly Report";
        }

        private void picGenerateReport_MouseLeave(object sender, EventArgs e)
        {
            picGenerateReport.BackColor = Color.White;
            hoverToolName.Text = "";
        }


        #endregion


    }
}
