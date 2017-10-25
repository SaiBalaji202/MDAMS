using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MDAMS
{
    public partial class FrmReport : MetroFramework.Forms.MetroForm
    {
        #region Declarations

        private int _order;
        private double _total;

        #endregion

        #region Constructor and Form Load Event Handlers

        public FrmReport()
        {
            InitializeComponent();
            _order = 1;
            _total = 0;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            receiptBindingSource.DataSource = new List<Receipt>();
            AddGSTHint();
            _dbHelper = new DatabaseHelper();
            SetAutoCompleteSuggestion();
        }

        #endregion

        #region Validators

        private void txtDrugNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LoadDatas();
        }

        #endregion

        #region Click Handlers

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (!IsNull())
            {
                var receipt = new Receipt()
                {
                    Id = _order++,
                    ProductName = txtMedName.Text,
                    Price = Convert.ToDouble(txtPrice.Text),
                    Gst = Convert.ToDouble(txtGST.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text)
                };
                double amtWithTax = receipt.Price + ((receipt.Price * receipt.Gst) / 100);
                _total += amtWithTax * receipt.Quantity;
                receiptBindingSource.Add(receipt);
                receiptBindingSource.MoveLast();

                Clear(txtTotal);
            }
            else
            {
                MetroMessageBox.Show(this, @"Some Details are Missing", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Receipt receipt = (Receipt)receiptBindingSource.Current;
            if (receipt != null)
            {
                _total -= (receipt.Price + ((receipt.Price * receipt.Gst)) / 100) * receipt.Quantity;
                txtTotal.Text = _total.ToString();
            }
            receiptBindingSource.RemoveCurrent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!IsNull(txtCash))
            {
                FrmPrintBill printBill = new FrmPrintBill((List<Receipt>)receiptBindingSource.DataSource,
                    AppGlobalDatas.StoreName, string.Format("Rs. {0}", txtTotal.Text),
                    string.Format("Rs. {0}", txtCash.Text),
                    string.Format("Rs. {0:##.000}", Convert.ToDouble(txtCash.Text) - _total),
                    DateTime.Now.ToString("yy-MM-dd"));
                printBill.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, @"Please Enter Cash given by the Customer", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        #endregion

        #region User Defined Functions

        private void Clear(MetroTextBox txt)
        {
            Clear();
            txt.Text = String.Format(@"{0}", _total);
        }

        private void Clear()
        {
            txtDrugNo.Text =
                txtMedName.Text =
                    txtGST.Text =
                        txtPrice.Text =
                            txtQuantity.Text =
                                txtTotal.Text = String.Empty;
        }

        private bool IsNull()
        {
            bool flgNull = string.IsNullOrWhiteSpace(txtMedName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) ||
                           string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtGST.Text);
            return flgNull;
        }

        private bool IsNull(MetroTextBox txt)
        {
            bool flgNull = string.IsNullOrWhiteSpace(txt.Text);
            return flgNull;
        }

        private void AddGSTHint()
        {
            txtGST.AutoCompleteCustomSource.Add("5");
            txtGST.AutoCompleteCustomSource.Add("12");
            txtGST.AutoCompleteCustomSource.Add("18");
        }

        private DatabaseHelper _dbHelper;

        List<string> _drgList;
        List<string> _prodList;
        List<string> _mrpList;


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
            _mrpList = new List<string>();

            foreach (DataRow row in table.Rows)
            {
                _drgList.Add(row[0].ToString());
                _prodList.Add(row[1].ToString());
                _mrpList.Add(row[3].ToString());
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
            collection.AddRange(_mrpList.ToArray());
            txtPrice.AutoCompleteCustomSource = collection;
        }

        private void LoadDatas()
        {
            if (!txtDrugNo.Text.Equals(""))
            {
                int index = _drgList.FindIndex(drgNo => drgNo.Equals(txtDrugNo.Text));
                txtMedName.Text = _prodList[index];
                txtPrice.Text = _mrpList[index];
            }
        }

        #endregion


    }

}
