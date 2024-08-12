using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Client
    {
        public string ClientName {  get; set; }
        public string ClientEMail { get; set; }
        public string ClientAdress { get; set; }

        public Client(string clientName, string clientEMail, string clientAdress)
        {
            ClientName = clientName;
            ClientEMail = clientEMail;
            ClientAdress = clientAdress;
        }
    }
}
