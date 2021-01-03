using DAL;
using System.Data;
namespace BUS
{

    public class Register__BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable Users()
        {
            string sql = "SELECT * FROM Users";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void RegisterUser(string username, string password, string email, string phone, string address)
        {
            string sql = "INSERT INTO Users (UserName,Password,Email,Phone,Address,Role,UserState) VALUES('" + username + "','" + password + "','" + email + "','" + phone + "',N'" + address + "','" + "user" + "'," + 1 + ")";
            dal.ExecuteNonQuery(sql);
        }
    }
}
