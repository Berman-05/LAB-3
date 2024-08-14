using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    public class Reservation
    {
        public int ReservationNumber {  get; set; }
        public string ReservationDate { get; set; }
        public string ReservationHour { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }

        public Reservation(int reservationNumber, string reservationDate, string reservationHour, string foodName, double foodPrice)
        {
            ReservationNumber = reservationNumber;
            ReservationDate = reservationDate;
            ReservationHour = reservationHour;
            FoodName = foodName;
            FoodPrice = foodPrice;
        }
        
    }
}
