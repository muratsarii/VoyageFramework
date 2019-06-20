using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework.DAL.Entities
{
    public class Driver 
    {
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public LicenseType LiCenceType { get; set; }

        public Person Person { get; set; }
    }
}
