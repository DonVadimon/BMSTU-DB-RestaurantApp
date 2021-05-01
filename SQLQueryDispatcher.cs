using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace kursologV2
{
    public class SQLQueryDispatcher
    {
        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\vadik\\source\\repos\\bd\\sueta.mdb";
        private readonly OleDbConnection connection;
        public SQLQueryDispatcher()
        {
            this.connection = new OleDbConnection(conString);
        }
        public bool Insert(string query)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = query;
            if (adapter.InsertCommand.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            connection.Close();
            return true;
        }
        public bool Update(string query)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = query;
            if (adapter.UpdateCommand.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            connection.Close();
            return true;
        }
        public bool Delete(string query)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = query;
            if (adapter.DeleteCommand.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            connection.Close();
            return true;
        }
    }
}
