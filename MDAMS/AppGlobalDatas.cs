using System;

namespace MDAMS
{
    class AppGlobalDatas
    {
        public static string DBProvider = "Provider=Microsoft.ACE.OLEDB.12.0;";
        public static string DBName  = "Data Source=Data\\MEDICAL.accdb";
        public static string LogFileName = "Data\\Error.txt";
        public static string DBConnectionString = DBProvider + DBName;
        public static string CurrentError { get; set; }
        public static Exception CurrentErrorStackTrace { get; set; }
    }
}