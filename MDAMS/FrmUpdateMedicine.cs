using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MDAMS
{
    public partial class FrmUpdateMedicine : MetroFramework.Forms.MetroForm
    {
        #region Declaration

        private DatabaseHelper _dbHelper;
        private bool _drugNo, _prodName, _unitSize, _mrp, _gp;
        List<string> _drgList, _sdrgList;
        List<string> _prodList, _sprodList;
        List<string> _untList, _suntList;
        List<string> _mrpList, _smrpList;
        List<string> _grpList, _sgrpList;
        private int _grdSelIndex;

        #endregion


        public FrmUpdateMedicine()
        {
            InitializeComponent();
        }

        #region Handlers

        private void FrmUpdateMedicine_Load(object sender, EventArgs e)
        {
            CtrlProgress(AppGlobalDatas.Progress.Visible);
            Init();
            CtrlProgress(AppGlobalDatas.Progress.InVisible);
        }

        private void picClear_Click(object sender, System.EventArgs e)
        {
            ClearAll();
        }

        private void picSearch_Click(object sender, System.EventArgs e)
        {
            CheckNull();
            LoadDataToDataTable();
        }

        private void btnUpdateDetails_Click(object sender, System.EventArgs e)
        {
            string strQuery = string.Format(@"UPDATE TBLMEDICINES SET CPRODUCT='{0}', CUNITSIZE='{1}', CMRP={2}, CTG='{3}' WHERE CDRUGNO={4};",
                txtMedName.Text, txtUnitSize.Text, Convert.ToInt32(txtMRP.Text), txtGrp.Text, Convert.ToInt32(txtDrugNo.Text));

            if (_dbHelper.UpdateQuery(strQuery) == 1)
            {
                MetroMessageBox.Show(this, "Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Update Auto-Complete Custom Source Collection
            UpdateValuesInAutoCollection();

            // Update Values in DataGridView
            UpdateValuesInGridView();
        }

        private void gridData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtDrugNo.Text = gridData.SelectedRows[0].Cells[1].Value.ToString();
                txtMedName.Text = gridData.SelectedRows[0].Cells[2].Value.ToString();
                txtUnitSize.Text = gridData.SelectedRows[0].Cells[3].Value.ToString();
                txtMRP.Text = gridData.SelectedRows[0].Cells[4].Value.ToString();
                txtGrp.Text = gridData.SelectedRows[0].Cells[5].Value.ToString();

                _grdSelIndex = gridData.SelectedRows[0].Index;
            }
            catch (Exception exception)
            {
                AppGlobalDatas.CurrentErrorStackTrace = exception;
                AppGlobalDatas.CurrentError = exception.Message;
            }
        }

        #endregion

        #region User Defined Functions

        private void Init()
        {
            _dbHelper = new DatabaseHelper();
            _dbHelper.CreateAndSetupConnection();
            SetAutoCompleteSuggestion();
        }

        private void SetAutoCompleteSuggestion()
        {
            string query = string.Format("SELECT cDrugNo, cProduct, cUnitSize, cMRP, cTG FROM TblMedicines;");
            System.Data.DataTable table = new DataTable();
            _dbHelper.RetriveQuery(query, table);
            Add(table);
        }

        private void Add(System.Data.DataTable table)
        {
            _drgList = new List<string>();
            _prodList = new List<string>();
            _untList = new List<string>();
            _mrpList = new List<string>();
            _grpList = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                _drgList.Add(row[0].ToString());
                _prodList.Add(row[1].ToString());
                _untList.Add(row[2].ToString());
                _mrpList.Add(row[3].ToString());
                _grpList.Add(row[4].ToString());
            }

            SetAutoCompleteSource();
        }

        private void SetAutoCompleteSource()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(_drgList.ToArray());
            txtDrugNo.AutoCompleteCustomSource = collection;

            collection = new AutoCompleteStringCollection();
            collection.AddRange(_prodList.ToArray());
            txtMedName.AutoCompleteCustomSource = collection;

            collection = new AutoCompleteStringCollection();
            collection.AddRange(_untList.ToArray());
            txtUnitSize.AutoCompleteCustomSource = collection;

            collection = new AutoCompleteStringCollection();
            collection.AddRange(_mrpList.ToArray());
            txtMRP.AutoCompleteCustomSource = collection;

            collection = new AutoCompleteStringCollection();
            collection.AddRange(_grpList.ToArray());
            txtGrp.AutoCompleteCustomSource = collection;
        }

        private void CtrlProgress(AppGlobalDatas.Progress state)
        {
            if (!Enum.IsDefined(typeof(AppGlobalDatas.Progress), state))
                throw new InvalidEnumArgumentException(nameof(state), (int)state, typeof(AppGlobalDatas.Progress));
            if (state == AppGlobalDatas.Progress.Visible)
                progLoad.Visible = true;
            else
                progLoad.Visible = false;
        }

        private void InitLists()
        {
            _drgList = new List<string>();
            _prodList = new List<string>();
            _untList = new List<string>();
            _mrpList = new List<string>();
            _grpList = new List<string>();
        }

        private void UpdateValuesInGridView()
        {
            gridData.Rows[_grdSelIndex].Cells[1].Value = txtDrugNo.Text;
            gridData.Rows[_grdSelIndex].Cells[2].Value = txtMedName.Text;
            gridData.Rows[_grdSelIndex].Cells[3].Value = txtUnitSize.Text;
            gridData.Rows[_grdSelIndex].Cells[4].Value = txtMRP.Text;
            gridData.Rows[_grdSelIndex].Cells[5].Value = txtGrp.Text;
        }

        private void UpdateValuesInAutoCollection()
        {
            txtDrugNo.AutoCompleteCustomSource.Remove(txtDrugNo.Text);
            txtDrugNo.AutoCompleteCustomSource.Add(txtDrugNo.Text);

            txtMedName.AutoCompleteCustomSource.Remove(txtMedName.Text);
            txtMedName.AutoCompleteCustomSource.Add(txtMedName.Text);

            txtUnitSize.AutoCompleteCustomSource.Remove(txtUnitSize.Text);
            txtUnitSize.AutoCompleteCustomSource.Add(txtUnitSize.Text);

            txtMRP.AutoCompleteCustomSource.Remove(txtMRP.Text);
            txtMRP.AutoCompleteCustomSource.Add(txtMRP.Text);

            txtGrp.AutoCompleteCustomSource.Remove(txtGrp.Text);
            txtGrp.AutoCompleteCustomSource.Add(txtGrp.Text);
        }

        private void picClear_MouseEnter(object sender, EventArgs e)
        {
            HoverOnClear();
        }

        private void picClear_MouseLeave(object sender, EventArgs e)
        {
            HoverOffClear();
        }

        private void picSearch_MouseEnter(object sender, EventArgs e)
        {
            HoverOnSearch();
        }

        private void picSearch_MouseLeave(object sender, EventArgs e)
        {
            HoverOffSearch();
        }

        private void HoverOnClear()
        {
            picClear.BackColor = Color.LightGray;
            picClear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void HoverOffClear()
        {
            picClear.BackColor = Color.White;
            picClear.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void HoverOnSearch()
        {
            picSearch.BackColor = Color.LightGray;
            picSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void txtDrugNo_Validating(object sender, CancelEventArgs e)
        {
            CheckNull();
            LoadDataToDataTable();
        }

        private void HoverOffSearch()
        {
            picSearch.BackColor = Color.White;
            picSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void metroPanel1_MouseHover(object sender, EventArgs e)
        {
            HoverOffClear();
            HoverOffSearch();
        }

        private void InitSearchLists()
        {
            _sdrgList = new List<string>();
            _sprodList = new List<string>();
            _suntList = new List<string>();
            _smrpList = new List<string>();
            _sgrpList = new List<string>();
        }

        private void ClearAll()
        {
            txtMedName.Text = "";
            txtDrugNo.Text = "";
            txtGrp.Text = "";
            txtMRP.Text = "";
            txtUnitSize.Text = "";
            gridData.DataSource = null;
        }



        private void LoadData()
        {
            if (_drugNo)
            {
                LoadDataToTextBox(_drgList.IndexOf(txtDrugNo.Text));
            }

        }

        private void LoadDataToTextBox(int index)
        {
            txtDrugNo.Text = _drgList[index];
            txtMedName.Text = _prodList[index];
            txtUnitSize.Text = _untList[index];
            txtMRP.Text = _mrpList[index];
            txtGrp.Text = _grpList[index];
        }

        private void LoadDataToDataTable()
        {
            DataTable _dataTable = new DataTable();

            //Adding Headers to DataTable
            _dataTable.Columns.Add("S.No. ");
            _dataTable.Columns.Add("Drug No. ");
            _dataTable.Columns.Add("Product Name ");
            _dataTable.Columns.Add("Unit Size ");
            _dataTable.Columns.Add("MRP");
            _dataTable.Columns.Add("GRP");

            List<string> drugListNew = new List<string>();
            List<string> prodListNew = new List<string>();
            List<string> untListNew = new List<string>();
            List<string> mrpListNew = new List<string>();
            List<string> grpListNew = new List<string>();

            InitSearchLists();
            if (_drugNo)
            {
                drugListNew = _drgList.FindAll(s => s.Equals(txtDrugNo.Text));
                int _firstIndex = -1;
                foreach (string drug in drugListNew)
                {
                    if (_firstIndex == -1)
                    {
                        _firstIndex = _drgList.FindIndex(item => item.Equals(txtDrugNo.Text));
                    }
                    else
                    {
                        _firstIndex = _drgList.FindIndex(_firstIndex, item => item.Equals(txtDrugNo.Text));
                    }
                    LoadValuesToAllLists(_firstIndex);
                }
            }
            else if (_prodName)
            {
                prodListNew = _prodList.FindAll(s => s.Equals(txtMedName.Text));
                int _firstIndex = -1;
                foreach (string s in prodListNew)
                {
                    if (_firstIndex == -1)
                    {
                        _firstIndex = _prodList.FindIndex(item => item.Equals(txtMedName.Text));
                    }
                    else
                    {
                        _firstIndex = _prodList.FindIndex(_firstIndex, item => item.Equals(txtMedName.Text));
                    }
                    LoadValuesToAllLists(_firstIndex);
                }
            }
            else if (_unitSize)
            {
                untListNew = _untList.FindAll(s => s.Equals(txtUnitSize.Text));
                int _firstIndex = -1;
                foreach (string s in untListNew)
                {
                    if (_firstIndex == -1)
                    {
                        _firstIndex = _untList.FindIndex(item => item.Equals(txtUnitSize.Text));
                    }
                    else
                    {
                        _firstIndex = _untList.FindIndex(_firstIndex + 1, item => item.Equals(txtUnitSize.Text));
                    }
                    LoadValuesToAllLists(_firstIndex);
                }
            }
            else if (_mrp)
            {
                mrpListNew = _mrpList.FindAll(s => s.Equals(txtMRP.Text));
                int _firstIndex = -1;
                foreach (string s in mrpListNew)
                {
                    if (_firstIndex == -1)
                    {
                        _firstIndex = _mrpList.FindIndex(item => item.Equals(txtMRP.Text));
                    }
                    else
                    {
                        _firstIndex = _mrpList.FindIndex(_firstIndex, item => item.Equals(txtMRP.Text));
                    }
                    LoadValuesToAllLists(_firstIndex);
                }
            }
            else if (_gp)
            {
                grpListNew = _grpList.FindAll(s => s.Equals(txtGrp.Text));
                int _firstIndex = -1;
                foreach (string s in grpListNew)
                {
                    if (_firstIndex == -1)
                    {
                        _firstIndex = _grpList.FindIndex(item => item.Equals(txtGrp.Text));
                    }
                    else
                    {
                        _firstIndex = _grpList.FindIndex(_firstIndex, item => item.Equals(txtGrp.Text));
                    }
                    LoadValuesToAllLists(_firstIndex);
                }
            }

            //Add Loaded Value to DataTable
            for (int i = 0; i < _sdrgList.Count; i++)
            {
                List<string> strTempValue = new List<string>();
                strTempValue.Add((i + 1).ToString());
                strTempValue.Add(_sdrgList[i]);
                strTempValue.Add(_sprodList[i]);
                strTempValue.Add(_suntList[i]);
                strTempValue.Add(_smrpList[i]);
                strTempValue.Add(_sgrpList[i]);

                _dataTable.Rows.Add(strTempValue.ToArray());
            }
            gridData.DataSource = _dataTable;
        }

        private void LoadValuesToAllLists(int _index)
        {
            _sdrgList.Add(_drgList[_index]);
            _sprodList.Add(_prodList[_index]);
            _suntList.Add(_untList[_index]);
            _smrpList.Add(_mrpList[_index]);
            _sgrpList.Add(_grpList[_index]);
        }

        private void CheckNull()
        {
            _drugNo = txtDrugNo.Text != "";
            if (_drugNo)
            {
                wrng.SetError(txtDrugNo, "You can't able to Update this Field.  It will not work!");
            }
            else
            {
                wrng.SetError(txtDrugNo, "");
            }

            _prodName = txtMedName.Text != "";

            _unitSize = txtUnitSize.Text != "";

            _mrp = txtMRP.Text != "";

            _gp = txtGrp.Text != "";
        }

        #endregion


    }
}
