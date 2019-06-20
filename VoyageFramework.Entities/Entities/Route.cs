using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework.DAL.Entities
{
    public class Route
    {
        [Key]
        public int RouteId { get; set; }
        public string Name { get; set; }
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        public int Distance { get; set; }
        public int BreakCount { get; set; }
        public decimal BasePrice { get; set; }
    }
}
