using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework.DAL.Entities
{
    public class LuxuryBus 
    {      
        [ForeignKey("Bus")]
        public int BusId { get; set; }
        public int Capacity { get; set; }
        public bool HasToilet { get; set; }

        public Bus Bus { get; set; }
    }
}
