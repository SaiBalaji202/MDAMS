using MetroFramework.Controls;
using System;
using System.Drawing;
using System.Text;

namespace MDAMS
{
    public partial class FrmViewMedicine : MetroFramework.Forms.MetroForm
    {

        #region Declaration


        private bool _flagDrugNo, _flagProdName, _flagUnit, _flagMRP, _flagGrp;
        private DatabaseHelper _dbHelper;


        #endregion

        public FrmViewMedicine()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper();
        }

        private void FrmViewMedicine_Load(object sender, System.EventArgs e)
        {
            InitDefaultText();
            InitEventHandlersForTextBoxes();
            InitGridView();
        }

        private void InitDefaultText()
        {
            txtDrugNo.Text = AppGlobalDatas.StrDrgNo; SetForeColorGray(txtDrugNo);
            txtMedName.Text = AppGlobalDatas.StrProdName; SetForeColorGray(txtMedName);
            txtUnitSize.Text = AppGlobalDatas.StrUnit; SetForeColorGray(txtUnitSize);
            txtMRP.Text = AppGlobalDatas.StrMrp; SetForeColorGray(txtMRP);
            txtGrp.Text = AppGlobalDatas.StrGrp; SetForeColorGray(txtGrp);

            _flagDrugNo = _flagMRP = _flagGrp = _flagProdName = _flagUnit = _flagGrp = false;
        }

        private void InitEventHandlersForTextBoxes()
        {
            txtDrugNo.GotFocus += RemovePlaceHolderDrg;
            txtDrugNo.LostFocus += AddPlaceHolderDrg;

            txtMedName.GotFocus += RemovePlaceHolderProd;
            txtMedName.LostFocus += AddPlaceHolderProd;

            txtMRP.GotFocus += RemovePlaceHolderMRP;
            txtMRP.LostFocus += AddPlaceHolderMRP;

            txtUnitSize.GotFocus += RemovePlaceHolderUnit;
            txtUnitSize.LostFocus += AddPlaceHolderUnit;

            txtGrp.GotFocus += RemovePlaceHolderGRP;
            txtGrp.LostFocus += AddPlaceHolderGRP;
        }


        #region Got and Lost Event Handlers

        private void AddPlaceHolderDrg(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDrugNo.Text))
            {
                SetForeColorGray(txtDrugNo);
                txtDrugNo.Text = AppGlobalDatas.StrDrgNo;
                _flagDrugNo = false;
            }
            else
            {
                _flagDrugNo = true;
            }
        }

        private void RemovePlaceHolderDrg(object sender, EventArgs e)
        {
            if (!_flagDrugNo)
            {
                SetForeColorBlack(txtDrugNo);
                txtDrugNo.Text = String.Empty;
            }
        }

        private void AddPlaceHolderProd(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedName.Text))
            {
                SetForeColorGray(txtMedName);
                txtMedName.Text = AppGlobalDatas.StrDrgNo;
                _flagProdName = false;
            }
            else
            {
                _flagProdName = true;
            }
        }

        private void RemovePlaceHolderProd(object sender, EventArgs e)
        {
            if (!_flagProdName)
            {
                SetForeColorBlack(txtMedName);
                txtMedName.Text = String.Empty;
            }
        }

        private void AddPlaceHolderUnit(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitSize.Text))
            {
                SetForeColorGray(txtUnitSize);
                txtUnitSize.Text = AppGlobalDatas.StrDrgNo;
                _flagUnit = false;
            }
            else
            {
                _flagUnit = true;
            }
        }

        private void RemovePlaceHolderUnit(object sender, EventArgs e)
        {
            if (!_flagUnit)
            {
                SetForeColorBlack(txtUnitSize);
                txtUnitSize.Text = String.Empty;
            }
        }

        private void AddPlaceHolderMRP(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMRP.Text))
            {
                SetForeColorGray(txtMRP);
                txtMRP.Text = AppGlobalDatas.StrDrgNo;
                _flagMRP = false;
            }
            else
            {
                _flagMRP = true;
            }
        }

        private void RemovePlaceHolderMRP(object sender, EventArgs e)
        {
            if (!_flagMRP)
            {
                SetForeColorBlack(txtMRP);
                txtMRP.Text = String.Empty;
            }
        }

        private void AddPlaceHolderGRP(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrp.Text))
            {
                SetForeColorGray(txtGrp);
                txtGrp.Text = AppGlobalDatas.StrDrgNo;
                _flagGrp = false;
            }
            else
            {
                _flagGrp = true;
            }
        }

        private void RemovePlaceHolderGRP(object sender, EventArgs e)
        {
            if (!_flagGrp)
            {
                SetForeColorBlack(txtGrp);
                txtGrp.Text = String.Empty;
            }
        }

        #endregion

        private void txtDrugNo_TextChanged(object sender, EventArgs e)
        {
            if (gridData.DataSource == null)
                InitGridView();

            bool flgAnd = false;
            StringBuilder strBQuery = new StringBuilder("");
            if (txtDrugNo != null && ((!txtDrugNo.Text.Equals(AppGlobalDatas.StrDrgNo)) && !txtDrugNo.Text.Equals("") && !txtDrugNo.Text.Equals(String.Empty)))
            {
                if (!flgAnd)
                {
                    strBQuery.Append(string.Format("Drug_No = {0}", txtDrugNo.Text));
                }
                flgAnd = true;
            }
            if (txtMedName != null && ((!txtMedName.Text.Equals(AppGlobalDatas.StrProdName)) && !txtMedName.Text.Equals("") && !txtMedName.Text.Equals(String.Empty)))
            {
                if (!flgAnd)
                {
                    strBQuery.Append(string.Format("Medicine_Name LIKE '{0}%'", txtMedName.Text));
                    flgAnd = true;
                }
                else
                {
                    strBQuery.Append(string.Format(" And Medicine_Name LIKE '{0}%'", txtMedName.Text));
                }
            }
            if (txtUnitSize != null && ((!txtUnitSize.Text.Equals(AppGlobalDatas.StrUnit)) && !txtUnitSize.Text.Equals("") && !txtUnitSize.Text.Equals(String.Empty)))
            {
                if (!flgAnd)
                {
                    strBQuery.Append(string.Format("Unit_Size LIKE '{0}%'", txtUnitSize.Text));
                    flgAnd = true;
                }
                else
                {
                    strBQuery.Append(string.Format(" And Unit_Size LIKE '{0}%'", txtUnitSize.Text));
                }

            }
            if (txtMRP != null && ((!txtMRP.Text.Equals(AppGlobalDatas.StrMrp)) && !txtMRP.Text.Equals("") && !txtMRP.Text.Equals(String.Empty)))
            {
                if (!flgAnd)
                {
                    strBQuery.Append(string.Format("MRP = {0}", txtMRP.Text));
                    flgAnd = true;
                }
                else
                {
                    strBQuery.Append(string.Format(" And MRP = {0}", txtMRP.Text));
                }
            }
            if (txtGrp != null && ((!txtGrp.Text.Equals(AppGlobalDatas.StrGrp)) && !txtGrp.Text.Equals("") && !txtGrp.Text.Equals(String.Empty)))
            {
                if (!flgAnd)
                {
                    strBQuery.Append(string.Format("Group_Name LIKE '{0}%'", txtGrp.Text));
                }
                else
                {
                    strBQuery.Append(string.Format(" And Group_Name LIKE '{0}%'", txtGrp.Text));
                }
            }
            string strFilterQuery = strBQuery.ToString();
            if (!strFilterQuery.Equals(""))
                (gridData.DataSource as System.Data.DataTable).DefaultView.RowFilter = strFilterQuery.ToString();
        }

        private void SetForeColorGray(MetroTextBox txt)
        {
            if (!txt.UseCustomForeColor)
                txt.UseCustomForeColor = true;
            txt.ForeColor = Color.DarkGray;
        }

        private void SetForeColorBlack(MetroTextBox txt)
        {
            if (!txt.UseCustomForeColor)
                txt.UseCustomForeColor = true;
            txt.ForeColor = Color.Black;
        }

        private void InitGridView()
        {
            gridData.DataSource = InitDataTable();
        }

        private System.Data.DataTable InitDataTable()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            string strQuery = "SELECT cDrugNo AS Drug_No, cProduct AS Medicine_Name, cUnitSize AS Unit_Size, cMRP AS MRP, cTG AS Group_Name FROM TblMedicines;";
            _dbHelper.RetriveQuery(strQuery, dt);
            return dt;
        }
    }
}
