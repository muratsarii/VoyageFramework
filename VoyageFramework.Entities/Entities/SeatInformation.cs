using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework.DAL.Entities
{
    public class SeatInformation
    {        
        [Key]
        public int SeatNumber { get; set; }
        public SeatSection Section { get; set; }
        public SeatCategory Category { get; set; }
    }
}
