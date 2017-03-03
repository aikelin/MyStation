using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Bolg.App_Code
{
    public class SqlDBClass
    {
        SqlConnection myConn;
        SqlCommand myComm;
        public SqlConnection GetSqlConnection()
        {
            string myStr = ConfigurationManager.AppSettings["ConnectionString"].ToString();
            myConn = new SqlConnection(myStr);
            return myConn;
        }

        public DataTable GetSqlDataSet(string sql, string TableName)
        {
            try
            {
                myConn = GetSqlConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, myConn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, TableName);
                return dataSet.Tables[TableName];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                myConn.Close();
                myConn.Dispose();
            }
        }

        public int SqlUpdate(string sql)
        {
            int Exe = 0;
            try
            {
                myConn = GetSqlConnection();
                myConn.Open();
                myComm = new SqlCommand();
                myComm.CommandText = sql;
                myComm.Connection = myConn;
                Exe = myComm.ExecuteNonQuery();
                return Exe;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                myConn.Close();
                myComm.Dispose();
            }

        }

        public string SqlInsert(string sql)
        {
            int Exe = 0;
            string lastInsertId = null;
            try
            {
                myConn = GetSqlConnection();
                myConn.Open();
                myComm = new SqlCommand();
                myComm.CommandText = sql;
                myComm.Connection = myConn;
                Exe = myComm.ExecuteNonQuery();                
                if (Exe > 0)
                {
                    myComm.CommandText = "SELECT @@IDENTITY";
                    lastInsertId = myComm.ExecuteScalar().ToString();
                }
                return lastInsertId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                myConn.Close();
                myComm.Dispose();
            }
        }
    }
}