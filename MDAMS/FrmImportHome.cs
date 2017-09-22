using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDAMS
{
    public partial class FrmImportHome : MetroFramework.Forms.MetroForm
    {
        private string pbImportExcelTip = "Import Excel Data";
        private string pbImportMedicalTip = "Add New Medicine Data";

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
            hoverToolName.Text = pbImportExcelTip;
        }

        private void picImportFile_MouseLeave(object sender, EventArgs e)
        {
            picImportFile.BackColor = Color.White;
            hoverToolName.Text = "";
        }

        #endregion

        #region MedicalData

        private void picImportMedicineData_MouseEnter(object sender, EventArgs e)
        {
            picImportMedicineData.BackColor = Color.LightGray;
            hoverToolName.Text = pbImportMedicalTip;
        }

        private void picImportMedicineData_MouseLeave(object sender, EventArgs e)
        {
            picImportMedicineData.BackColor = Color.White;
            hoverToolName.Text = "";
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

        private void picImportMedicineData_Click(object sender, EventArgs e)
        {
            (new FrmMedicalDetails()).Show();
        }
    }
}
