using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursologV2
{
    public class SQLQueryBuilder
    {
        public string createInsertQuery(string tableName, List<string> columnNames, List<string> values)
        {
            return "INSERT INTO " + tableName + " (" + String.Join(", ", columnNames) + ") VALUES(" + String.Join(", ", values.Select(value => "@" + value.ToUpper())) + ");";
        }
        public string createUpadetQuery(string tableName, List<string> columnNames, List<string> values, string condition)
        {
            string settingValues = "";
            for (int i = 0; i < columnNames.Count; i++)
            {
                settingValues += columnNames[i] + "=" + values[i] + (i != columnNames.Count - 1 ? ", " : "");
            }
            return "UPDATE " + tableName + " SET " + settingValues + " WHERE " + condition + ";";
        }
        public string createDeleteQuery(string tableName, string condition)
        {
            return "DELETE FROM " + tableName + " WHERE " + condition + ";";
        }
    }
}
