using System;
using System.Data;
using System.Data.OleDb;

namespace MDAMS
{
    class DatabaseHelper
    {
        private OleDbConnection _conn;
        private OleDbCommand _cmd;

        public DatabaseHelper()
        {
            CreateAndSetupConnection();
        }

        public bool CreateAndSetupConnection()
        {
            bool flag = true;
            try
            {
                if (_conn == null)
                {
                    _conn = new OleDbConnection();
                    _conn.ConnectionString = AppGlobalDatas.DbConnectionString;

                }
                if (_cmd == null)
                {
                    _cmd = new OleDbCommand();
                    _cmd.Connection = _conn;
                }
            }
            catch (OleDbException oleDbException)
            {
                flag = !flag;
                AppGlobalDatas.CurrentError = oleDbException.Message;
                AppGlobalDatas.CurrentErrorStackTrace = oleDbException;
            }
            catch (Exception exception)
            {
                flag = !flag;
                AppGlobalDatas.CurrentError = exception.Message;
                AppGlobalDatas.CurrentErrorStackTrace = exception;
            }
            return flag;
        }

        public bool OpenConnection()
        {
            bool flag = true;
            try
            {
                if (!(_conn.State == ConnectionState.Open))
                {
                    _conn.Open();
                }
                return flag;
            }
            catch (OleDbException oleDbException)
            {
                flag = !flag;
                AppGlobalDatas.CurrentError = oleDbException.Message;
                AppGlobalDatas.CurrentErrorStackTrace = oleDbException;
            }
            catch (Exception exception)
            {
                flag = !flag;
                AppGlobalDatas.CurrentError = exception.Message;
                AppGlobalDatas.CurrentErrorStackTrace = exception;
            }
            return flag;
        }

        public bool CloseConnection()
        {
            bool flag = true;
            try
            {
                if (!(_conn.State == ConnectionState.Closed))
                {
                    _conn.Close();
                }
                return flag;
            }
            catch (OleDbException oleDbException)
            {
                flag = !flag;
                AppGlobalDatas.CurrentError = oleDbException.Message;
                AppGlobalDatas.CurrentErrorStackTrace = oleDbException;
            }
            catch (Exception exception)
            {
                flag = !flag;
                AppGlobalDatas.CurrentError = exception.Message;
                AppGlobalDatas.CurrentErrorStackTrace = exception;
            }
            return flag;
        }

        public int UpdateQuery(string strQuery)
        {
            int flag = 0;
            try
            {
                OpenConnection();
                _cmd.CommandText = strQuery;
                flag = _cmd.ExecuteNonQuery();
                CloseConnection();
                return flag;
            }
            catch (OleDbException oleDbException)
            {
                flag = -1;
                AppGlobalDatas.CurrentError = oleDbException.Message;
                AppGlobalDatas.CurrentErrorStackTrace = oleDbException;
            }
            catch (Exception exception)
            {
                flag = -1;
                AppGlobalDatas.CurrentError = exception.Message;
                AppGlobalDatas.CurrentErrorStackTrace = exception;
            }
            return flag;
        }

        public void RetriveQuery(string strQuery, DataTable _table)
        {
            try
            {
                OleDbDataAdapter _adapter;
                _adapter = new OleDbDataAdapter(strQuery, _conn);
                _adapter.Fill(_table);
            }
            catch (OleDbException exception)
            {
                _table = null;
                AppGlobalDatas.CurrentError = exception.Message;
                AppGlobalDatas.CurrentErrorStackTrace = exception;
            }
            catch (Exception exception)
            {
                _table = null;
                AppGlobalDatas.CurrentError = exception.Message;
                AppGlobalDatas.CurrentErrorStackTrace = exception;
            }

        }

    }
}