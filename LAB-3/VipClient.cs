using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    public class VipClient : Clients
    {
        public VipClient(string name, string email, string telephone) : base(name, email, telephone)
        {
        }
        public override double Total(double total)
        {
            total = total * 0.8;
            return total;
        }
    }
}
