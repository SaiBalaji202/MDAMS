using System;

namespace MDAMS
{

    class AppGlobalDatas
    {

        public enum Progress
        {
            Visible,
            InVisible
        }

        public static string StoreName = LoadStoreName();
        public static string LogoImage { get; } = @"icons\\Logo.png";

        public static string DbProvider { get; } = @"Provider=Microsoft.ACE.OLEDB.12.0;";
        public static string ExcelFilter { get; } = @"Excel Files(*.xls, *.xlsx, *.csv) | *.xls; *.xlsx; *.csv";
        public static string DbName { get; } = @"Data Source=Data\\MEDICAL.accdb";
        public static string LogFileName { get; } = @"Data\\Error.txt";
        public static string DbConnectionString { get; } = DbProvider + DbName;
        public static string CurrentError { get; set; }
        public static Exception CurrentErrorStackTrace { get; set; }

        #region LableValues
        public static string StrDrgNo = @"Drug No";
        public static string StrGrp = @"Group Name";
        public static string StrMrp = @"MRP";
        public static string StrProdName = @"Product Name";
        public static string StrUnit = @"Unit Size";
        #endregion

        private static string LoadStoreName()
        {
            return "Ji Medical Shop";
        }
    }
}