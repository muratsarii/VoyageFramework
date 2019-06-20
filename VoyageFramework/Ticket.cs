using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    internal class Ticket
    {
        public BusExpedition Expedition { get; }        //sefer
        public SeatInformation SeatInformation { get; } //Koltuk Bilgisi
        public Person Passenger { get; }        // Yolcu
        public decimal PaidAmount { get; }      //Ödenen Tutar

        internal Ticket(BusExpedition expedition, SeatInformation seatInformation, Person passenger, decimal paidAmount)
        {
            Expedition = expedition;
            SeatInformation = seatInformation;
            Passenger = passenger;
            PaidAmount = paidAmount;
        }
    }
}
