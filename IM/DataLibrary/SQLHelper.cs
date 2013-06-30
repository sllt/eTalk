using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    public class SQLHelper
    {
        static private string connectionString = @"Data Source=LONG-PC;Initial Catalog=ETalk;Integrated Security=True";

        static public SqlConnection conn = new SqlConnection(connectionString);

        static private SqlCommand PrepareCommand(SqlConnection conn, string commandText, CommandType commandType)
        {
            return PrepareCommand(conn, commandText, commandType, null);
        }
        static private SqlCommand PrepareCommand(SqlConnection conn, string commandText, CommandType commandType, params SqlParameter[] param)
        {
            SqlCommand comm = new SqlCommand(commandText, conn);
            comm.CommandType = commandType;
            if (param != null)
            {
                foreach (SqlParameter p in param)
                {
                    comm.Parameters.Add(p);
                }
            }

            return comm;
        }


        public static DataSet GetPasswordFormUserNumber(string userNumber,string userPass)
        {
            conn.Open();
            SqlParameter[] param ={
                                     new SqlParameter("@userNumber",userNumber),
                                     new SqlParameter("@userPass",userPass)
                                 };
            SqlCommand comm = PrepareCommand(conn, "GetPasswordFormUserNumber", CommandType.StoredProcedure, param);

            DataSet ds = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter(comm))
            {
                da.Fill(ds, "User");
            }
            conn.Close();
            return ds;

        }

        public static DataSet GetUserByNumber(string userNumber)
        {
            conn.Open();
            SqlParameter[] param ={
                                     new SqlParameter("@userNumber",userNumber),
                                     
                                 };
            SqlCommand comm = PrepareCommand(conn, "GetUserByNumber", CommandType.StoredProcedure, param);

            DataSet ds = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter(comm))
            {
                da.Fill(ds, "User");
            }
            conn.Close();
            return ds;

        }

        public static DataSet GetFriendsByNumber(string userNumber)
        {
            conn.Open();
            SqlParameter[] param ={
                                     new SqlParameter("@userNumber",userNumber),
                                     
                                 };
            SqlCommand comm = PrepareCommand(conn, "GetFriendsByNumber", CommandType.StoredProcedure, param);

            DataSet ds = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter(comm))
            {
                da.Fill(ds, "User");
            }
            conn.Close();
            return ds;

        }

        public static DataSet GetUserById(string id)
        {
            conn.Open();
            SqlParameter[] param ={
                                     new SqlParameter("@id",id),
                                     
                                 };
            SqlCommand comm = PrepareCommand(conn, "GetUserById", CommandType.StoredProcedure, param);

            DataSet ds = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter(comm))
            {
                da.Fill(ds, "User");
            }
            conn.Close();
            return ds;

        }
    }
}
