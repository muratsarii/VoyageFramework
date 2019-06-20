using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework.DAL.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        [ForeignKey("BusExpedition")]
        public int BusExpeditionId { get; set; }
        [ForeignKey("SeatInformation")]
        public int SeatInformationId { get; set; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public decimal PaidAmount { get; set; }

        public BusExpedition BusExpedition { get; set; }
        public SeatInformation SeatInformation { get; set; }
        public Person Person { get; set; }
    }
}
