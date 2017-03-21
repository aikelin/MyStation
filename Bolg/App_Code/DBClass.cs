using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

        public string GetMD5(string pwd)
        {
            MD5 md5pwd = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(pwd);
            byte[] md5data = md5pwd.ComputeHash(data);
            md5pwd.Clear();
            string str = "";
            for (int i = 0; i < md5data.Length - 1; i++)
            {
                str += md5data[i].ToString("x").PadLeft(2, '0');
            }
            return str;
        }

        public object getExecuteScalar(string sql)
        {
            if (connection == "mysql")
            {
                MySqlDBClass mysqldb = new MySqlDBClass();
                return mysqldb.MygetExecuteScalar(sql);
            }
            else
            {
                return null;
            }
        }

    }
}