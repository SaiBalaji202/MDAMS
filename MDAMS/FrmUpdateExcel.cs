using LinqToExcel;
using MetroFramework;
using MetroFramework.Forms;
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
    public partial class FrmUpdateExcel : MetroForm
    {

        #region VariableDeclaration
        private Excel.Application _excelApp;
        private Excel.Workbook _excelWorkbook;
        private Excel.Worksheet _excelWorksheet;
        private string _strFilePath;
        DatabaseHelper _dbHelper;
        private Task _backTask;
        private List<int> _failureRecords;
        #endregion

        public FrmUpdateExcel()
        {
            InitializeComponent();
            Init();
        }

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
                btnUpdateDB.PerformClick();
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
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
            string strFile = BrowseExcel();
            CtrlProgress(AppGlobalDatas.Progress.Visible);
            _backTask = new Task(() =>
            {
                lblLoadMsg.Text = @"Reading Sheets";
                OnBrowseExcelClick(strFile);
                lblLoadMsg.Text = @"Sheets Readed Successfully";
                CtrlProgress(AppGlobalDatas.Progress.InVisible);
            });
            _backTask.Start();
        }

        private void toggleOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleOnOff.Checked == false)
            {
                toggleOnOff.Text = @"Auto Update Off";
            }
            else
            {
                toggleOnOff.Text = @"Auto Update On";
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
            lblLoadMsg.Text = "Reading Excel Sheet...";
            InitExcelApp(_strFilePath);
            _excelWorksheet = (Excel.Worksheet)_excelWorkbook.Worksheets.Item[Convert.ToInt32(comboAvailSheets.SelectedIndex) + 1];

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
            lblLoadMsg.Text = "Updating Table....";
            if (!(UpdateExcelToDb(dt)))
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
            lblLoadMsg.Text = "Update Completed";
            MetroMessageBox.Show(this, "Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool UpdateExcelToDb(DataTable dt)
        {
            bool flg = false;
            string errDetails = null;
            int count = 0;

            _failureRecords = new List<int>();

            bool flag = true;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var strQuery = string.Format("UPDATE TBLMEDICINES SET CPRODUCT='{1}', CUNITSIZE='{2}', CMRP={3}, CTG='{4}' WHERE CDRUGNO={0};",
                    dt.Rows[i][1].ToString().Trim(), dt.Rows[i][2].ToString().Trim(),
                    dt.Rows[i][3].ToString().Trim(), dt.Rows[i][4].ToString().Trim(), dt.Rows[i][0].ToString().Trim());

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
                            errDetails = AppGlobalDatas.CurrentError;
                            flg = true;
                        }
                    }

                }
            }

            if (_failureRecords != null)
            {
                string affectedRecords = string.Join(", ", _failureRecords);
                MetroMessageBox.Show(this, "Unable to Update Records on the Row " + affectedRecords + "\n\tCheck the whether the corresponding records on your Excel Sheet.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (count > 0)
            {
                MetroMessageBox.Show(this, errDetails + "\n\nThe Above Error occurs " + count + "times during Updation of Records.  To Report this Error, Contact Admin through Contact Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _failureRecords = null;
            return flag;
        }

        #endregion

        private string BrowseExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = AppGlobalDatas.ExcelFilter
            };
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
            picLoad.Visible = state == AppGlobalDatas.Progress.Visible;
        }

        private void ClearAll()
        {
            _excelApp = null;
            _excelWorkbook = null;
            _excelWorksheet = null;

            comboAvailSheets.Items.Clear();
            picLoad.Visible = false;
        }


        #endregion

    }
}
