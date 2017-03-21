using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Bolg.App_Code
{
    public class MySqlDBClass
    {

        MySqlConnection myConn;
        MySqlCommand myComm;

        public MySqlConnection GetMySqlConnection()
        {
            string dbConnectoinStr = ConfigurationManager.ConnectionStrings["mysqlconnection"].ConnectionString;
            myConn = new MySqlConnection(dbConnectoinStr);
            return myConn;
        }

        public DataTable GetMySqlDataTable(string sql, string TableName)
        {
            try
            {
                myConn = GetMySqlConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, myConn);
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

        public int MySqlUpdate(string sql)
        {
            int Exe = 0;
            try
            {
                myConn = GetMySqlConnection();
                myConn.Open();
                myComm = new MySqlCommand();
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

        public string MySqlInsert(string sql)
        {
            int Exe = 0;
            string lastInsertId = null;
            try
            {
                myConn = GetMySqlConnection();
                myConn.Open();
                myComm = new MySqlCommand();
                myComm.CommandText = sql;
                myComm.Connection = myConn;
                Exe = myComm.ExecuteNonQuery();
                if (Exe > 0)
                {
                    lastInsertId = myComm.LastInsertedId.ToString();
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

        public object MygetExecuteScalar(string sql)
        {
            try
            {
                myConn = GetMySqlConnection();
                myConn.Open();
                myComm = new MySqlCommand();
                myComm.Connection = myConn;
                myComm.CommandText = sql;
                return myComm.ExecuteScalar();
            }catch(Exception ex)
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