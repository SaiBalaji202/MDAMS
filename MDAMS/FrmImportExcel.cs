using LinqToExcel;
using MetroFramework;
using System;
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
        private Excel.Worksheet _excelWorksheet;
        private string _strFilePath, _strSheetName;
        DatabaseHelper _dbHelper;

        public FrmImportExcel()
        {
            InitializeComponent();
            Init();
        }

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

        private async void btnAnimateLine_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < this.Size.Width)
            {
                progLine.X2 = i++;
                await Task.Delay(10);
            }
        }



        private void picBrowseExcel_MouseEnter(object sender, EventArgs e)
        {
            picBrowseExcel.BackColor = Color.LightGray;
            picExcel.BackColor = Color.LightGray;
        }

        private void picBrowseExcel_MouseLeave(object sender, EventArgs e)
        {
            picBrowseExcel.BackColor = Color.White;
            picExcel.BackColor = Color.White;
        }

        private void comboAvailSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadExcel();
        }

        private void btnImportToDB_Click(object sender, EventArgs e)
        {
            ReadExcel();
        }

        private void ReadExcel()
        {
            _excelWorksheet = (Excel.Worksheet)_excelWorkbook.Worksheets.Item[Convert.ToInt32(comboAvailSheets.SelectedIndex) + 1];

            var excelFile = new ExcelQueryFactory(_strFilePath);
            var datasQueryable = from a in excelFile.Worksheet(comboAvailSheets.SelectedText) select a;

            // var columnNames = datasQueryable.ElementAt(1);

            DataTable dataTable = new DataTable();


            int cnt = 0;
            foreach (Row data in datasQueryable)
            {
                if (cnt > 1)
                {
                    int i = 0;

                    foreach (Cell cell in data)
                    {
                        string str = cell.Value.ToString();
                        if (str.Equals("") == false)
                        {
                            str = str.Replace("\"", string.Empty).Replace("'", string.Empty); i++;
                        }
                    }
                    object[] objects = new object[i];
                    i = 0;
                    foreach (Cell cell in data)
                    {
                        string str = cell.Value.ToString();
                        if (str.Equals("") == false)
                        {
                            str = str.Replace("\"", string.Empty).Replace("'", string.Empty);
                            objects[i++] = str;
                        }
                    }
                    if (i != 0)
                        dataTable.Rows.Add(objects);
                }
                else if (cnt == 0)
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
                            dataTable.Columns.Add(str);
                        }
                    }
                    cnt++;
                }
                else
                {
                    cnt++;
                }
            }
            _excelApp.Quit();

            dataGridView1.DataSource = dataTable;
            if (!(ImportExcelToDB(dataTable)))
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

        private bool ImportExcelToDB(DataTable dt)
        {
            bool flag = true;
            //string strQuery = String.Format("INSERT INTO TBLMEDICINES(CDRUGNO, CPRODUCT, CUNITSIZE, CMRP, CTG) VALUES");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string strQuery = String.Format("INSERT INTO TBLMEDICINES(CDRUGNO, CPRODUCT, CUNITSIZE, CMRP, CTG) VALUES");
                strQuery = strQuery + String.Format("({0}, '{1}', '{2}', {3}, '{4}');", dt.Rows[i][1].ToString().Trim(), dt.Rows[i][2].ToString().Trim(),
                               dt.Rows[i][3].ToString().Trim(), dt.Rows[i][4].ToString().Trim(), "");
                if (_dbHelper.UpdateQuery(strQuery) == -1)
                {
                    flag = !flag;
                }

            }
            //strQuery = strQuery.Remove(strQuery.Length - 2);
            //strQuery += ";";
            ////if (_dbHelper.UpdateQuery(strQuery) == -1)
            ////{
            ////    flag = !flag;
            ////}
            return flag;
        }

        private async void OnBrowseExcelClick()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files(*.xls, *.xlsx, *.csv) | *.xls; *.xlsx; *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _strFilePath = openFileDialog.FileName;
                InitExcelApp(_strFilePath);


                comboAvailSheets.Items.Clear();
                // ReSharper disable once ComplexConditionExpression
                string[] strWorksheetNames = await Task.Run((Func<string[]>)ReadAllRecordsFromExcel);

                foreach (var name in strWorksheetNames)
                {
                    comboAvailSheets.Items.Add(name);
                }


            }
        }

        private string[] ReadAllRecordsFromExcel()
        {

            string[] strNames = new string[_excelWorkbook.Worksheets.Count];
            int i = 0;
            foreach (Excel.Worksheet worksheet in _excelWorkbook.Worksheets)
                strNames[i++] = worksheet.Name;
            return strNames;
        }

        private async void picBrowseExcel_Click(object sender, EventArgs e)
        {
            picLoad.Visible = true;
            OnBrowseExcelClick();
            picLoad.Visible = false;

        }

        private void picExcel_Click(object sender, EventArgs e)
        {
            picLoad.Visible = true;
            OnBrowseExcelClick();
            picLoad.Visible = false;
        }

        private void ClearAll()
        {
            _excelApp = null;
            _excelWorkbook = null;
            _excelWorksheet = null;

            comboAvailSheets.Items.Clear();
            picLoad.Visible = false;
        }
    }
}
