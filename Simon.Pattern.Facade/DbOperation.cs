using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Simon.Pattern.Facade
{
    public class DbOperation : IDisposable
    {
        private string mSqlConnStr;
        private SqlConnection mSqlConn;
        private SqlCommand mSqlCmd;

        public DbOperation(string connectionString)
        {
            this.mSqlConnStr = connectionString;
            Initialize();
        }

        void Initialize()
        {
            mSqlConn = new SqlConnection(this.mSqlConnStr);
            mSqlConn.Open();
        }

        public int ExcuteSql(string commandText)
        {
            if (null == this.mSqlCmd)
            {
                this.mSqlCmd = new SqlCommand();
                this.mSqlCmd.Connection = this.mSqlConn;
            }
            this.mSqlCmd.CommandText = commandText;
            return this.mSqlCmd.ExecuteNonQuery();
        }

        public void Dispose()
        {
            if(null != this.mSqlConn)
                this.mSqlConn.Dispose();
        }
    }
}
