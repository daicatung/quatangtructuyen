using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetail_DTO
    {
        int UserID, ProductID, Amount;
        string State;

        public int UserID1 { get => UserID; set => UserID = value; }
        public int ProductID1 { get => ProductID; set => ProductID = value; }
        public int Amount1 { get => Amount; set => Amount = value; }
        public string State1 { get => State; set => State = value; }
    }
}
