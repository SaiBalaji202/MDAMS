using MetroFramework.Controls;
using System;
using System.Collections.Generic;

namespace MDAMS
{
    public partial class FrmReport : MetroFramework.Forms.MetroForm
    {
        private int _order;
        private double _total;

        public FrmReport()
        {
            InitializeComponent();
            _order = 1;
            _total = 0;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var receipt = new Receipt()
            {
                Id = _order++,
                ProductName = txtMedName.Text,
                Gst = Convert.ToDouble(txtGST.Text),
                Price = Convert.ToDouble(txtPrice.Text),
                Quantity = Convert.ToInt32(txtQuantity.Text)
            };
            double amtWithTax = receipt.Price + ((receipt.Price * receipt.Gst) / 100);
            _total += amtWithTax * receipt.Quantity;
            receiptBindingSource.Add(receipt);
            receiptBindingSource.MoveLast();

            Clear(txtTotal);
        }

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

        private void FrmReport_Load(object sender, EventArgs e)
        {
            receiptBindingSource.DataSource = new List<Receipt>();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Receipt receipt = (Receipt)receiptBindingSource.Current;
            if (receipt != null)
            {
                _total -= receipt.Price - receipt.Quantity;
                txtTotal.Text = _total.ToString();
            }
            receiptBindingSource.RemoveCurrent();
        }
    }
}
