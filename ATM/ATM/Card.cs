using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Card
    {
        public string pan { get; set; }
        public string pin { get; set; }
        public string cvc { get; set; }
        public string expireDate { get; set; }
        public decimal balans { get; set; }
    }
}
