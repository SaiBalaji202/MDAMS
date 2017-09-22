using System.Drawing;

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

        private void FrmUpdateHome_Load(object sender, System.EventArgs e)
        {
            hoverToolName.Text = "";
        }

        private void picUpdateFile_MouseEnter(object sender, System.EventArgs e)
        {
            picUpdateFile.BackColor = Color.LightGray;
            hoverToolName.Text = "Update Medicine Details";
        }

        private void picUpdateFile_MouseLeave(object sender, System.EventArgs e)
        {
            picUpdateFile.BackColor = Color.White;
            hoverToolName.Text = "";
        }

        private void picUpdateMedicineData_MouseEnter(object sender, System.EventArgs e)
        {
            picUpdateMedicineData.BackColor = Color.LightGray;
            hoverToolName.Text = "Update Medicine Details By Providing Updated Excel File";
        }

        private void picUpdateMedicineData_MouseLeave(object sender, System.EventArgs e)
        {
            picUpdateMedicineData.BackColor = Color.White;
            hoverToolName.Text = "";
        }
    }
}
