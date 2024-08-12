using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class RegularCLient: Client
    {
        public int RegisteredCars { get; set; }

        public RegularCLient(string clientName, string clientEMail, string clientAdress, int registeredCars):base (clientName, clientEMail,clientAdress)
        {
            RegisteredCars = registeredCars;
        }
    }
}
