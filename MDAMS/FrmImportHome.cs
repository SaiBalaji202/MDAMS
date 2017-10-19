using System;
using System.Drawing;

namespace MDAMS
{
    public partial class FrmImportHome : MetroFramework.Forms.MetroForm
    {
        private string pbImportExcelTip = @"Import Excel Data";
        private string pbImportMedicalTip = @"Add New Medicine Data";

        public FrmImportHome()
        {
            InitializeComponent();
            InitControls();
        }

        #region MyFunctions

        void InitControls()
        {
            hoverToolName.Text = "";
        }

        #endregion

        #region Handlers

        #region ImportExcel

        private void picImportFile_Click(object sender, EventArgs e)
        {
            (new FrmImportExcel()).Show();
        }


        private void picImportFile_MouseEnter(object sender, EventArgs e)
        {
            picImportFile.BackColor = Color.LightGray;
            picImportFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            hoverToolName.Text = pbImportExcelTip;
        }

        private void picImportFile_MouseLeave(object sender, EventArgs e)
        {
            picImportFile.BackColor = Color.White;
            picImportFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            hoverToolName.Text = "";
        }


        #endregion

        #region MedicalData

        private void picImportMedicineData_MouseEnter(object sender, EventArgs e)
        {
            picImportMedicineData.BackColor = Color.LightGray;
            picImportMedicineData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            hoverToolName.Text = pbImportMedicalTip;
        }

        private void picImportMedicineData_MouseLeave(object sender, EventArgs e)
        {
            picImportMedicineData.BackColor = Color.White;
            picImportMedicineData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            hoverToolName.Text = "";
        }

        private void picImportMedicineData_Click(object sender, EventArgs e)
        {
            (new FrmMedicalDetails()).Show();
        }
        #endregion

        #endregion

        #region UnUsedHandlers

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void picImportFile_MouseHover(object sender, EventArgs e)
        {

        }



        #endregion

    }
}
