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
        public static List<Clients> clientsList = new List<Clients>();
        public static List<Reservation> reservationsList = new List<Reservation>();

        public virtual void AddRegularClient()
        {
            var (newName, newEmail, newPhoneNumber) = AddClient();
            Clients newCLient = new Clients(newName, newEmail, newPhoneNumber);
            clientsList.Add(newCLient);
        }
        public virtual void AddVIpClient()
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
            string newDAte = null; string newHour=null; string newFood=null; double newPrice = 0;
            Console.WriteLine("Ingrese el número de reservación:");
            int newReservationNumber=int.Parse(Console.ReadLine());
            Reservation searchReservation= reservationsList.Find(p=>p.ReservationNumber == newReservationNumber);
            if (searchReservation != null)
            {
                Console.WriteLine("La reservación ya existe...");
            }
            else 
            {
                Console.WriteLine("Ingrese la fecha de reservación:");
                 newDAte=Console.ReadLine();
                Console.WriteLine("Ingrese la hora de reservación:");
                 newHour=Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del plato a servir:");
                 newFood=Console.ReadLine();
                Console.WriteLine("Ingrese el costo de la comida:");
                 newPrice=double.Parse(Console.ReadLine());
            }
            Reservation newReservation = new Reservation(newReservationNumber,newDAte,newHour,newFood,newPrice);
            reservationsList.Add(newReservation);
        }
    }
}
