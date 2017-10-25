using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;

namespace MDAMS
{
    public partial class FrmPrintBill : MetroFramework.Forms.MetroForm
    {
        private List<Receipt> _list;
        private string _shopName, _total, _cash, _change, _date;

        public FrmPrintBill()
        {
            InitializeComponent();
        }

        public FrmPrintBill(List<Receipt> list, string shopName, string total, string cash, string change, string date)
        {
            InitializeComponent();

            _list = list;
            _shopName = shopName;
            _total = total;
            _cash = cash;
            _change = change;
            _date = date;
        }

        private void FrmPrintBill_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", _list);

            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal", _total),
                new Microsoft.Reporting.WinForms.ReportParameter("pCash", _cash),
                new Microsoft.Reporting.WinForms.ReportParameter("pChange", _change),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pShopName", _shopName)
            };

            this.reportBill.LocalReport.DataSources.Clear();
            this.reportBill.LocalReport.DataSources.Add(reportDataSource);
            this.reportBill.LocalReport.SetParameters(parameters);
            this.reportBill.LocalReport.Refresh();

            this.reportBill.RefreshReport();

        }
    }
}
