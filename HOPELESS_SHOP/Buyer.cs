using System;
using System.Collections.Generic;
using System.Text;

namespace HOPELESS_SHOP
{
    class Buyer
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public uint PhoneNumber { get; set; }
        public DateTime Birth { get; set; }
        public DateTime DateOfReigistr { get; set; }
        public string ListOforder { get; set; }
        public string ShoppinhCartId { get; set; }

        public Buyer()
            {

            }


    }


}
