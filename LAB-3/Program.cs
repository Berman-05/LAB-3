using LAB_3;


Functions newFunction= new Functions();

while (true)
{Console.Clear();
    try
    {
        Console.WriteLine("opcion");
        int opcionr = int.Parse(Console.ReadLine());
        switch (opcionr)
        {
            case 1:
                Console.Clear();
                newFunction.AddRegularClient();
                break;
                case 2:
                Console.Clear();
                newFunction.AddVIpClient();
                break;
                case 3:
                Console.Clear();
                newFunction.AddReservation();
                break;
            case 4:
                Console.Clear();
                foreach (var client in Functions.clientsList )
                {
                    Console.WriteLine("Nombre:"+client.Name);
                    Console.WriteLine("Correo electrónico:"+client.Email);
                    Console.WriteLine("Número telefónico:"+client.Telephone);
                }
                break;
                case 5:
                Console.Clear();
                foreach (var reservation in Functions.reservationsList)
                {
                    Console.WriteLine("Número de reservación:"+reservation.ReservationNumber);
                    Console.WriteLine("Fecha:"+reservation.ReservationDate);
                    Console.WriteLine("Hora:"+reservation.ReservationHour);
                    Console.WriteLine("Plato:"+reservation.FoodName);
                    Console.WriteLine("Precio:"+reservation.FoodPrice);
                }
                break;
                case 6:
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del cliente:");
                string newName = Console.ReadLine();
                Clients search = Functions.clientsList.Find(p => p.Name == newName);
                if (search != null)
                {
                    Console.WriteLine($"Cliente {search} fue encontrado.");
                    Console.ReadKey();
                }
                else { Console.WriteLine("No se pudo encontrar el cliente."); }
                break;
                case 7:
                Console.Clear();
                Console.WriteLine("Ingrese el número de reservación:");
                int newNumber = int.Parse(Console.ReadLine());
                Reservation searchReservation = Functions.reservationsList.Find(p => p.ReservationNumber == newNumber);
                if (searchReservation != null)
                {
                    Console.WriteLine($"Reservación con número {searchReservation} fue encontrada.");
                    Console.ReadKey();
                }
                else { Console.WriteLine("No se pudo encontrar la reservación."); }
                break;
                case 8:
                return;
            default:
                Console.WriteLine("Ingrese una opción válida.");
                break;
        }
        Console.ReadLine();
    }catch(Exception ex)
    {

    Console.WriteLine(ex.Message); }
   
}