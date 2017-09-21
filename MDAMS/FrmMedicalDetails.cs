using System;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace MDAMS
{
    public partial class FrmMedicalDetails : MetroFramework.Forms.MetroForm
    {
        private DatabaseHelper _dbHelper;

        public FrmMedicalDetails()
        {
            InitializeComponent();
            Clear();
            Init();
        }

        private void Init()
        {
            _dbHelper = new DatabaseHelper();
            if (((new DatabaseHelper()).CreateAndSetupConnection()) == false)
            {
                var res = MetroMessageBox.Show(this, AppGlobalDatas.CurrentError + "\n\nDo you want to save the Error Message?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (res == DialogResult.Yes)
                {
                    if (!(Helper.WriteError(AppGlobalDatas.CurrentError,
                        AppGlobalDatas.CurrentErrorStackTrace.ToString())))
                    {
                        MetroMessageBox.Show(this, AppGlobalDatas.CurrentError + "\n\nTo Report this Error, Contact Admin through Contact Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void picBack_MouseEnter(object sender, EventArgs e)
        {
            picBack.BackColor = Color.LightGray;
        }

        private void picBack_MouseLeave(object sender, EventArgs e)
        {
            picBack.BackColor = Color.White;
        }

        private void Clear()
        {
            txtDrugNo.Text = "";
            txtGrp.Text = "";
            txtMRP.Text = "";
            txtMedName.Text = "";
            txtUnitSize.Text = "";
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            if (!IsNull())
            {
                string strInsertQuery = String.Format("INSERT INTO TBLMEDICINES(CDRUGNO, CPRODUCT, CUNITSIZE, CMRP, CTG) VALUES({0}, '{1}', '{2}', {3}, '{4}')", 
                    Convert.ToInt32(txtDrugNo.Text), txtMedName.Text, txtUnitSize.Text, Convert.ToDecimal(txtMRP.Text), txtGrp.Text);
                if (_dbHelper.UpdateQuery(strInsertQuery) == 1)
                {
                    MetroMessageBox.Show(this, "Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    var res = MetroMessageBox.Show(this, AppGlobalDatas.CurrentError + "\n\nDo you want to save the Error Message?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (res == DialogResult.Yes)
                    {
                        if (!(Helper.WriteError(AppGlobalDatas.CurrentError,
                            AppGlobalDatas.CurrentErrorStackTrace.ToString())))
                        {
                            MetroMessageBox.Show(this, AppGlobalDatas.CurrentError + "\n\nTo Report this Error, Contact Admin through Contact Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool IsNull()
        {
            bool flag = false;
            if (txtMedName.Text == "")
            {
                flag = !flag;
                SetError(txtMedName, "Enter Product Name");
            }
            if (txtDrugNo.Text == "")
            {
                flag = !flag;
                SetError(txtDrugNo, "Enter Drug No");
            }
            if (txtGrp.Text == "")
            {
                flag = !flag;
                SetError(txtGrp, "Enter Therapeutic Group");
            }
            if (txtMRP.Text == "")
            {
                flag = !flag;
                SetError(txtMRP, "Enter MRP");
            }
            if (txtUnitSize.Text == "")
            {
                flag = !flag;
                SetError(txtUnitSize, "Enter Unit Size");
            }
            return flag;
        }

        private void SetError(MetroTextBox txtBox, string strError)
        {
            erp.SetError(txtBox, strError);
        }

        private void picClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void picClear_MouseEnter(object sender, EventArgs e)
        {
            picClear.BackColor = Color.LightGray;
        }

        private void picClear_MouseLeave(object sender, EventArgs e)
        {
            picClear.BackColor = Color.White;
        }
    }
}
