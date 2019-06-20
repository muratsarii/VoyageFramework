using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework.DAL.Entities
{
    public class Bus
    {
        [Key]
        public int BusId { get; set; }
        [ForeignKey("LuxuryBus")]
        public int LuxuryBusId { get; set; }
        [ForeignKey("StandardBus")]
        public int StandardBusId { get; set; }
        public string Make { get; set; }
        public string Plate { get; set; }
        public LuxuryBus LuxuryBus { get; set; }
        public StandardBus StandardBus { get; set; }
        //public abstract SeatInformation GetSeatInformation(int seatNumber);
    }
}
