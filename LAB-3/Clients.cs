using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    public class Clients
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public Clients(string name, string email, string telephone)
        {
            Name = name;
            Email = email;
            Telephone = telephone;
        }
        public virtual double Total(double total)
        {
            total = total * 1;
            return total;
        }
    }
}
