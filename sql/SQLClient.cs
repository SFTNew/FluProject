using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FluCreate.utils;

namespace HLHTUpLoad.common
{
    class SQLClient
    {
        private string source;
        private string catalog;
        private string user;
        private string password;
        private string connectString;
        public SQLClient()
        {
            this.source = OperateIniFile.read("DATABASE", "local", "127.0.0.11");
            this.user = OperateIniFile.read("DATABASE", "username", "sa");
            this.password = OperateIniFile.read("DATABASE", "password", "6");
            this.catalog = OperateIniFile.read("DATABASE", "catalog", "hisdata");
            this.connectString = "Data Source="+this.source+";Initial Catalog="+this.catalog+";User ID="+this.user+";Password="+this.password;
        }
        public  DataTable ExecuteQuery(string sqlStr, CommandType type)
        {
            SqlConnection con  = new SqlConnection(this.connectString);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = type;
                cmd.CommandText = sqlStr;
                SqlDataAdapter msda;
                msda = new SqlDataAdapter(cmd);
                msda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;

        }

        /**
         * 执行存储过程
         */
        public int ExecuteSP(string spName)
        {
            using (SqlConnection conn = new SqlConnection(this.connectString))
            {
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd.ExecuteNonQuery();
            }
        }

        public  int ExecuteUpdate(string sqlStr)      //用于增删改;
        {
            using (SqlConnection con = new SqlConnection(this.connectString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;
                int iud = 0;
                iud = cmd.ExecuteNonQuery();
                return iud;
            }

        }


    }
}
