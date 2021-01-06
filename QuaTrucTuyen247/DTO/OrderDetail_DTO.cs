using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetail_DTO
    {
        int OrderID, UserID, ProductID, Amount, State;

        public int OrderID1 { get => OrderID; set => OrderID = value; }
        public int UserID1 { get => UserID; set => UserID = value; }
        public int ProductID1 { get => ProductID; set => ProductID = value; }
        public int Amount1 { get => Amount; set => Amount = value; }
        public int State1 { get => State; set => State = value; }
    }
}
