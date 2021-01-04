using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class DetailsProduct_BUS
    {
        Lop_DAL da = new Lop_DAL();
        Product_DTO product = new Product_DTO();
        DetailsProduct_DTO detail = new DetailsProduct_DTO();
        public DataTable ShowProductWithID(string id)
        {
            string sql = "SELECT * FROM   Product WHERE ProductID='" + id + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable ShowDetailsProduct(string id)
        {
            string sql = "SELECT * FROM   DetailProduct WHERE ProductID='" + id + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertDetailProduct(string Title, string Desciption, string Photo, string Tit1, string Des1, string Photo1, string Tit2, string Des2, string Photo2, string Tit3, string Des3, string Photo3, string Tit4, string Des4, string Photo4, string Tit5, string Des5, string Photo5)
        {
            string sql = "Insert DetailProduct values(N'" + Title + "',N'" + Desciption + "',N'~/images/products/" + Photo + "',N'" + Tit1 + "',N'" + Des1 + "',N'~/images/products/" + Photo1 + "',N'" + Tit2 + "',N'" + Des2 + "',N'~/images/products/" + Photo2 + "',N'" + Tit3 + "',N'" + Des3 + "',N'~/images/products/" + Photo3 + "',N'" + Tit4 + "',N'" + Des4 + "',N'~/images/products/" + Photo4 + "',N'" + Tit5 + "',N'" + Des5 + "',N'~/images/products/" + Photo5 + "')";
            da.ExecuteNonQuery(sql);
        }

        public void UpdateDetailProduct(string ProductID, string Title, string Desciption, string Photo, string Tit1, string Des1, string Photo1, string Tit2, string Des2, string Photo2, string Tit3, string Des3, string Photo3, string Tit4, string Des4, string Photo4, string Tit5, string Des5, string Photo5)
        {
            string sql = "update DetailProduct set Title=N'" + Title + "', Desciption=N'" + Desciption + "', Photo=N'" + Photo + "'~/images/products/, Tit1=N'" + Tit1 + "', Des1=N'" + Des1 + "', Photo1=N'~/images/products/" + Photo1+ "', Tit2=N'" + Tit2 + "', Des2=N'" + Des2 + "', Photo2=N'~/images/products/" + Photo2 + "', Tit3=N'" + Tit3 + "', Des3=N'" + Des3 + "', Photo3=N'~/images/products/" + Photo3 + "', Tit4=N'" + Tit4 + "', Des4=N'" + Des4 + "', Photo4=N'~/images/products/" + Photo4 + "', Tit5=N'" + Tit5 + "', Des5=N'" + Des5 + "', Photo5=N'~/images/products/" + Photo5 + "' where ProductID =N'" + ProductID + "'";
            da.ExecuteNonQuery(sql);
        }

        public void DeleteDetailProduct(string ProductID)
        {
            string sql = "Delete DetailProduct where ProductID=N'" + ProductID + "'";
            da.ExecuteNonQuery(sql);
        }
    }
}
