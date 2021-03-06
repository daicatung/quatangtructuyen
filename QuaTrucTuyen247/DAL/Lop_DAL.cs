﻿using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Lop_DAL
    {
        public SqlConnection GetConnect()
        {
            //return new SqlConnection(@"Data Source=DESKTOP-HND0LC3\SQLEXPRESS;Initial Catalog=QuaTrucTuyen247;Integrated Security=True");
            return new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuaTrucTuyen247;Integrated Security=True");
        }

        public DataTable GetTable(string sql)
        {
            SqlConnection conn = GetConnect();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ExecuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}
