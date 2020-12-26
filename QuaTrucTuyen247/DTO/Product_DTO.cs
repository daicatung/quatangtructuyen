using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace DTO
{
    public class Product_DTO
    {
        int productID_, quantity_, productState_, categoryID_, detailProductID_, attributesID_;
        string productName_, photo_;
        decimal cost_;

        public int ProductID_ { get => productID_; set => productID_ = value; }
        public int Quantity_ { get => quantity_; set => quantity_ = value; }
        public int CategoryID_ { get => categoryID_; set => categoryID_ = value; }
        public string ProductName_ { get => productName_; set => productName_ = value; }
        public string Photo_ { get => photo_; set => photo_ = value; }
        public decimal Cost_ { get => cost_; set => cost_ = value; }
        public int ProductState_ { get => productState_; set => productState_ = value; }
        public int DetailProductID_ { get => detailProductID_; set => detailProductID_ = value; }
        public int AttributesID_ { get => attributesID_; set => attributesID_ = value; }
    }
}
