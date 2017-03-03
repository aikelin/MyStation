using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Bolg.App_Code
{
    public class DBClass
    {
        string connection = "mysql";//sql or mysql


        public DataTable GetDataSet(string sql, string TableName)
        {
            if (connection == "mysql")
            {
                MySqlDBClass mysqldb = new MySqlDBClass();
                return mysqldb.GetMySqlDataTable(sql, TableName);
            }
            else
            {
                SqlDBClass sqldb = new SqlDBClass();
                return sqldb.GetSqlDataSet(sql, TableName);
            }
        }

        public int Update(string sql)
        {
            if (connection == "mysql")
            {
                MySqlDBClass mysqldb = new MySqlDBClass();
                return mysqldb.MySqlUpdate(sql);
            }
            else
            {
                SqlDBClass sqldb = new SqlDBClass();
                return sqldb.SqlUpdate(sql);
            }

        }
        public string Insert(string sql)
        {
            if (connection == "mysql")
            {
                MySqlDBClass mysqldb = new MySqlDBClass();
                return mysqldb.MySqlInsert(sql);
            }
            else
            {
                SqlDBClass sqldb = new SqlDBClass();
                return sqldb.SqlInsert(sql);
            }
        }

    }
}