using System;
using System.Collections.Generic;
using System.Text;

namespace SDT621_SA_SectionC
{
    internal class Mobile
    {
        public string Code { get; set; }
        public string Make { get; set; }
        public string Quantity { get; set; }

        public Mobile() { }

        public Mobile(string code, string make, string quantity) {
            Code = code;
            Make = make;
            Quantity = quantity;
        }

    }
}
