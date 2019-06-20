using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework.DAL.Entities
{
    public class BusExpedition
    {
        [Key]
        public int BusExpeditionId { get; set; }   
        [ForeignKey("Bus")]
        public int BusId { get; set; }
        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        [ForeignKey("Host")]
        public int HostId { get; set; }
        public bool HasSnackService { get; set; }
        public bool HasDeley { get; set; }
        public DateTime EstimatedArrivalTime { get; set; }
        public DateTime? EstimatedDepartureTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Code { get; set; }

        public Bus Bus { get; set; }
        public Driver Driver { get; set; }
        public Host Host { get; set; }
    }
}
