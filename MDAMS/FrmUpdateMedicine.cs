using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDAMS
{
    public partial class FrmUpdateMedicine : MetroFramework.Forms.MetroForm
    {
        private DatabaseHelper _dbHelper;
        private bool _drugNo, _prodName, _unitSize, _mrp, _gp;

        public FrmUpdateMedicine()
        {
            InitializeComponent();
        }

        private void FrmUpdateMedicine_Load(object sender, EventArgs e)
        {
            Init();
        }

        #region Handlers

        private void picClear_Click(object sender, System.EventArgs e)
        {
            ClearAll();
        }

        private void picSearch_Click(object sender, System.EventArgs e)
        {

        }

        private void btnUpdateDetails_Click(object sender, System.EventArgs e)
        {

        }

        private void txtDrugNo_TextChanged(object sender, EventArgs e)
        {
            CheckNull();
        }

        #endregion

        #region User Defined Functions

        private void Init()
        {
            _dbHelper = new DatabaseHelper();
            _dbHelper.CreateAndSetupConnection();
            SetAutoCompleteSuggestion();
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

        private async void SetAutoCompleteSuggestion()
        {
            string _query = String.Format("SELECT cDrugNo, cProduct, cUnitSize, cMRP, cTG FROM TblMedicines;");
            System.Data.DataTable _table = new DataTable();
            _dbHelper.RetriveQuery(_query, _table);
            await AddAsync(_table);

        }

        private async Task AddAsync(System.Data.DataTable _table)
        {
            List<string> drgList = new List<string>();
            List<string> prodList = new List<string>();
            List<string> untList = new List<string>();
            List<string> mrpList = new List<string>();
            List<string> grpList = new List<string>();

            foreach (DataRow row in _table.Rows)
            {
                drgList.Add(row[0].ToString());
                prodList.Add(row[1].ToString());
                untList.Add(row[2].ToString());
                mrpList.Add(row[3].ToString());
                grpList.Add(row[4].ToString());
            }

            AutoCompleteStringCollection collection;

            collection = new AutoCompleteStringCollection();
            collection.AddRange(drgList.ToArray());
            txtDrugNo.AutoCompleteCustomSource = collection;

            collection = new AutoCompleteStringCollection();
            collection.AddRange(prodList.ToArray());
            txtMedName.AutoCompleteCustomSource = collection;

            collection = new AutoCompleteStringCollection();
            collection.AddRange(untList.ToArray());
            txtUnitSize.AutoCompleteCustomSource = collection;

            collection = new AutoCompleteStringCollection();
            collection.AddRange(mrpList.ToArray());
            txtMRP.AutoCompleteCustomSource = collection;

            collection = new AutoCompleteStringCollection();
            collection.AddRange(grpList.ToArray());
            txtGrp.AutoCompleteCustomSource = collection;
        }

        private void LoadData()
        {

        }

        private void CheckNull()
        {
            _drugNo = txtDrugNo.Text != "";

            _prodName = txtMedName.Text != "";

            _unitSize = txtUnitSize.Text != "";

            _mrp = txtMRP.Text != "";

            _gp = txtGrp.Text != "";
        }

        #endregion


    }
}
