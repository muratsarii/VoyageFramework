using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.DAL
{
    public class DALUnitOfWork : IDisposable
    {
        private BusAutomation ctx;
        public IRepo<Bus> bus { get; set; }
        public IRepo<BusExpedition> busExpedition { get; set; }
        public IRepo<Driver> driver { get; set; }

        public IRepo<Host> host { get; set; }

        public IRepo<LuxuryBus> luxuryBus { get; set; }
        public IRepo<Person> person { get; set; }
        public IRepo<Route> route { get; set; }
        public IRepo<SeatInformation> seatInformation { get; set; }
        public IRepo<StandardBus> standardBus { get; set; }
        public IRepo<Ticket> ticket { get; set; }


        public DALUnitOfWork()
        {
            ctx = new BusAutomation();
            bus = new BusRepo(ctx);
            busExpedition = new BusExpeditionRepo(ctx);
            driver = new DriverRepo(ctx);

            host = new HostRepo(ctx);

            luxuryBus = new LuxuryBusRepo(ctx);
            person = new PersonRepo(ctx);
            route = new RouteRepo(ctx);
            seatInformation = new SeatInformationRepo(ctx);
            standardBus = new StandardBusRepo(ctx);
            ticket = new TicketRepo(ctx);

        }
        public void SaveChanges()
        {
            ctx.SaveChanges();
        }
        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
