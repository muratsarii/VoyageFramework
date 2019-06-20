using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.Entities.Entities
{
    public class BusType
    {
        [Key]
        public int BusTypeId { get; set; }
        [ForeignKey("LuxuryBus")]
        public int LuxuryBusId { get; set; }
        [ForeignKey("StandardBus")]
        public int StandardBusId { get; set; }

        public LuxuryBus LuxuryBus { get; set; }
        public StandardBus StandardBus { get; set; }
    }
}
