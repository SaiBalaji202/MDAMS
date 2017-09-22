using System.Threading.Tasks;

namespace MDAMS
{
    public partial class FrmSplashScreen : MetroFramework.Forms.MetroForm
    {
        public FrmSplashScreen()
        {
            InitializeComponent();

        }

        private void metroTile1_Click(object sender, System.EventArgs e)
        {

        }

        private async void FrmSplashScreen_Load(object sender, System.EventArgs e)
        {
            lblShopName.Text = AppGlobalDatas.StoreName;

            await Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Task.Delay(10);
                }
                FrmImportHome frm = new FrmImportHome();
                frm.Show();
            });
            this.Hide();
        }

    }
}
