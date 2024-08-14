using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    public class Functions
    {
        public List<Clients> clientsList = new List<Clients>();
        public List<Reservation> reservationsList = new List<Reservation>();

        public virtual void AddRegularClient()
        {
            var (newName, newEmail, newPhoneNumber) = AddClient();
            Clients newCLient = new Clients(newName, newEmail, newPhoneNumber);
            clientsList.Add(newCLient);
        }
        public virtual (string, string, string) AddClient()
        {
            string newName = null;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del cliente:");
                newName = Console.ReadLine();
                Clients search = clientsList.Find(p => p.Name == newName);
                if (search != null)
                {
                    Console.WriteLine("El usuario ya está registrado");
                    Console.ReadKey();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Ingrese el correo electrónico del cliente:");
            string newEmail = Console.ReadLine();
            Console.WriteLine("Ingrese el número telefónico:");
            string newPhoneNumber = Console.ReadLine();
            return (newName, newEmail, newPhoneNumber);
        }
        public void AddReservation()
        {

        }
    }
}
