using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    public class RegularCLient : Clients
    {
        public RegularCLient(string name, string email, string telephone) : base(name, email, telephone)
        {
        }
        public override double Total(double total)
        {
            total = total * 1;
            return total;
        }
    }
}
