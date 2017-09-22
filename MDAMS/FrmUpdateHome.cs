namespace MDAMS
{
    public partial class FrmUpdateHome : MetroFramework.Forms.MetroForm
    {
        public FrmUpdateHome()
        {
            InitializeComponent();
        }

        private void picUpdateFile_Click(object sender, System.EventArgs e)
        {
            (new FrmUpdateMedicine()).Show();
        }
    }
}
