using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.DAL
{
    public class BusAutomation : DbContext
    {
        public DbSet<Bus> buses { get; set; }
        public DbSet<BusExpedition> busExpeditions { get; set; }

        public DbSet<Driver> drivers { get; set; }

        public DbSet<Host> hosts { get; set; }
        public DbSet<LuxuryBus> luxuryBuses { get; set; }
        public DbSet<Person> people { get; set; }
        public DbSet<Route> routes { get; set; }
        public DbSet<SeatInformation> seatInformations { get; set; }
        public DbSet<StandardBus> standardBuses { get; set; }

        public DbSet<Ticket> tickets { get; set; }
    }
}
