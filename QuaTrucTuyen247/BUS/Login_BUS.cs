﻿using DAL;
using System.Data;
namespace BUS
{
    public class Login_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable CheckLogin()
        {
            string sql = "SELECT * FROM Users WHERE Role='user' AND UserState=" + 1;
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        //dang nhap phai admin
        public DataTable CheckLoginAdmin()
        {
            string sql = "SELECT * FROM Users WHERE Role='admin' AND UserState=" + 1;
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
