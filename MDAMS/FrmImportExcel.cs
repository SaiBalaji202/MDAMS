﻿using LinqToExcel;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MDAMS
{
    public partial class FrmImportExcel : MetroFramework.Forms.MetroForm
    {
        private Excel.Application _excelApp;
        private Excel.Workbook _excelWorkbook;

        private string _strFilePath;
        DatabaseHelper _dbHelper;
        private Task _backTask;
        private List<int> _failureRecords;

        #region Constructors

        public FrmImportExcel()
        {
            InitializeComponent();
            Init();
        }

        #endregion

        #region Handlers

        #region Hover

        private void picBrowseExcel_MouseEnter(object sender, EventArgs e)
        {
            HoverOn();
        }

        private void picBrowseExcel_MouseLeave(object sender, EventArgs e)
        {
            HoverOff();
        }


        private void picExcel_MouseEnter(object sender, EventArgs e)
        {
            HoverOn();
        }

        private void picExcel_MouseLeave(object sender, EventArgs e)
        {
            HoverOff();
        }

        private void HoverOn()
        {
            picBrowseExcel.BackColor = Color.LightGray;
            picExcel.BackColor = Color.LightGray;
            picBrowseExcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            picExcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void HoverOff()
        {
            picBrowseExcel.BackColor = Color.White;
            picExcel.BackColor = Color.White;
            picBrowseExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            picExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        #endregion

        private void comboAvailSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toggleOnOff.Checked)
                btnImportToDB.PerformClick();
        }

        private void btnImportToDB_Click(object sender, EventArgs e)
        {
            CtrlProgress(AppGlobalDatas.Progress.Visible);
            _backTask = new Task(() =>
            {
                ReadExcel();
                CtrlProgress(AppGlobalDatas.Progress.InVisible);
            });
            _backTask.Start();
        }

        private void picBrowseExcel_Click(object sender, EventArgs e)
        {
            string _strFile = BrowseExcel();
            CtrlProgress(AppGlobalDatas.Progress.Visible);
            _backTask = new Task(() =>
            {
                lblLoadMsg.Text = @"Loading Sheets...";
                OnBrowseExcelClick(_strFilePath);
                CtrlProgress(AppGlobalDatas.Progress.InVisible);
                lblLoadMsg.Text = @"Sheets Loaded";
            });
            _backTask.Start();
        }

        private void toggleOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleOnOff.Checked == false)
            {
                toggleOnOff.Text = @"Auto Import Off";
            }
            else
            {
                toggleOnOff.Text = @"Auto Import On";
            }
        }

        #endregion

        #region UserDefinedFunctions

        private void Init()
        {
            ClearAll();
            _dbHelper = new DatabaseHelper();
        }

        private void InitExcelApp(string strExcelPath)
        {
            _excelApp = new Excel.Application();
            _excelWorkbook = _excelApp.Workbooks.Open(strExcelPath);
            //_excelWorksheet = (Excel.Worksheet) _excelWorkbook.Worksheets.Item[index + 1];
        }

        #region LongRunningTasks

        private void ReadExcel()
        {
            lblLoadMsg.Text = @"Reading Excel Sheet...";
            InitExcelApp(_strFilePath);

            var excelFile = new ExcelQueryFactory(_strFilePath);
            var datasQueryable = from a in excelFile.Worksheet(comboAvailSheets.SelectedText) select a;

            // var columnNames = datasQueryable.ElementAt(1);

            DataTable dt = new DataTable();

            int _rowCount = 0;
            foreach (Row data in datasQueryable)
            {
                if (_rowCount > 0)
                {

                    //Reading Processed Data From Excel
                    List<string> objects = new List<string>();
                    int _colCount = 0;
                    foreach (Cell cell in data)
                    {
                        string str = cell.Value.ToString();
                        if (str.Equals("") == false)
                        {
                            str = str.Replace("\"", string.Empty).Replace("'", string.Empty);
                            objects.Add(str);
                            ++_colCount;
                        }
                    }
                    //Adding Records to Table, if the row is not empty
                    if (_colCount > 0)
                        dt.Rows.Add(objects.ToArray());
                }
                //Adding Column Headers to DataTable
                else if (_rowCount == 0)
                {
                    foreach (var cell in data)
                    {
                        string str = cell.ToString();
                        if (!(str.Equals("")))
                        {
                            if (str.Contains("'"))
                            {
                                str = str.Replace("\"", string.Empty).Replace("'", string.Empty);
                            }
                            dt.Columns.Add(str);
                        }
                    }
                    _rowCount++;
                }
            }
            _excelWorkbook.Close();
            _excelApp.Quit();

            if (!(ImportExcelToDb(dt)))
            {
                var res = MetroMessageBox.Show(this, AppGlobalDatas.CurrentError + "\n\nDo you want to save the Error Message?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (res == DialogResult.Yes)
                {
                    if (!(Helper.WriteError(AppGlobalDatas.CurrentError,
                        AppGlobalDatas.CurrentErrorStackTrace.ToString())))
                    {
                        MetroMessageBox.Show(this, AppGlobalDatas.CurrentError + "\n\nTo Report this Error, Contact Admin through Contact Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            MetroMessageBox.Show(this, "Data Imported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ImportExcelToDb(DataTable dt)
        {
            lblLoadMsg.Text = @"Inserting Data into Table....";
            bool flg = false;
            int count = 0;
            string _errDetails = null;

            _failureRecords = new List<int>();
            bool flag = true;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string strQuery = String.Format("INSERT INTO TBLMEDICINES(CDRUGNO, CPRODUCT, CUNITSIZE, CMRP, CTG) VALUES");
                strQuery = strQuery + String.Format("({0}, '{1}', '{2}', {3}, '{4}');", dt.Rows[i][1].ToString().Trim(), dt.Rows[i][2].ToString().Trim(),
                               dt.Rows[i][3].ToString().Trim(), dt.Rows[i][4].ToString().Trim(), "");
                if (_dbHelper.UpdateQuery(strQuery) == -1)
                {
                    flag = !flag;

                    _failureRecords.Add(i);

                    if (!(Helper.WriteError(AppGlobalDatas.CurrentError,
                        AppGlobalDatas.CurrentErrorStackTrace.ToString())))
                    {

                        count++;
                        if (!flg)
                        {
                            flg = true;
                            _errDetails = AppGlobalDatas.CurrentError;
                        }
                    }
                }

            }

            if (_failureRecords != null)
            {
                string affectedRecords = string.Join(", ", _failureRecords);
                MetroMessageBox.Show(this, "Unable to Insert Records on the Row " + affectedRecords + "\n\tCheck the whether the corresponding records on your Excel Sheet.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (count > 0)
            {
                MetroMessageBox.Show(this, _errDetails + "\n\nThe Above Error occurs " + count + "times during Insertion.  To Report this Error, Contact Admin through Contact Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblLoadMsg.Text = @"Data Inserted Successfully.";
            _failureRecords = null;
            return flag;
        }

        #endregion

        private string BrowseExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = AppGlobalDatas.ExcelFilter;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _strFilePath = openFileDialog.FileName;
            }
            return _strFilePath;
        }

        private void OnBrowseExcelClick(string strFilePath)
        {
            //CtrlProgress(AppGlobalDatas.Progress.Visible);

            InitExcelApp(strFilePath);

            comboAvailSheets.Items.Clear();

            // ReSharper disable once ComplexConditionExpression
            string[] strWorksheetNames = ReadAllRecordsFromExcel();

            foreach (var name in strWorksheetNames)
            {
                comboAvailSheets.Items.Add(name);
            }

            //CtrlProgress(AppGlobalDatas.Progress.InVisible);
        }

        private string[] ReadAllRecordsFromExcel()
        {

            string[] strNames = new string[_excelWorkbook.Worksheets.Count];
            int i = 0;
            foreach (Excel.Worksheet worksheet in _excelWorkbook.Worksheets)
                strNames[i++] = worksheet.Name;
            return strNames;
        }

        private void CtrlProgress(AppGlobalDatas.Progress state)
        {
            if (!Enum.IsDefined(typeof(AppGlobalDatas.Progress), state))
                throw new InvalidEnumArgumentException(nameof(state), (int)state, typeof(AppGlobalDatas.Progress));
            if (state == AppGlobalDatas.Progress.Visible)
                picLoad.Visible = true;
            else
                picLoad.Visible = false;
        }

        private void ClearAll()
        {
            _excelApp = null;
            _excelWorkbook = null;

            comboAvailSheets.Items.Clear();
            picLoad.Visible = false;
        }

        #endregion


    }
}
