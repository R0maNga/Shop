using System;
using System.Collections.Generic;
using System.Text;

namespace HOPELESS_SHOP
{
    class Order
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string ListOfOrderItems { get; set; }

        public Order()
        {

        }



    }
}
