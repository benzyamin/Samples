using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace KK.Common
{
    public abstract class DataBaseAccess :IDisposable
    {
        private DbConnection connection;
        private DbDataAdapter adapter;
        private DbTransaction transaction;

        public DataBaseAccess()
        {
            InitConnectObject();

        }
        protected DbConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        protected DbDataAdapter Adapter
        {
            get { return adapter; }
            set { adapter = value; }
        }

        void IDisposable.Dispose()
        {
            connection.Dispose();
        }

        public System.Data.DataTable GetTable(string sql)
        {
            DataTable table = new DataTable();
            adapter.SelectCommand.CommandText = sql;
            Adapter.Fill(table);
            return table;
        }

        public int UpdateTable(System.Data.DataTable table)
        {
           return  adapter.Update(table);
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }
        public void CommitTransactin()
        {
            try
            {
                if (transaction != null)
                    transaction.Commit();
            }
            finally
            {
                transaction = null;
            }
        }
        public void RollbackTransaction()
        {
            try
            {
                if (transaction != null)
                    transaction.Rollback();
            }
            finally
            {
                transaction = null;
            }
        }

        protected abstract void InitConnectObject();
        public static DataBaseAccess GetInstance()
        {
            return new SqlDataAccess();
        }

    }
}
