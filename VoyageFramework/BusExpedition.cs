using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    class BusExpedition
    {
        public IEnumerable<Ticket> Tickets { get; set; } // 273. satır için bunu ekledik

        DriverCollection driverCollection = new DriverCollection();
        HostCollection hostCollection = new HostCollection();
        TicketCollection ticketCollection = new TicketCollection();

        public string Code
        {
            get
            {
                Random rnd = new Random();
                rnd.Next(1000, 9999);
                if (Bus.HasToilet == true)
                    return string.Format("{0}{1}-LX-{2}", Route.DepartureLocation.First(), DepartureTime.ToString("yyMMdd"), rnd.ToString());
                return string.Format("{0}{1}-ST-{2}", Route.DepartureLocation.First(), DepartureTime.ToString("yyMMdd"), rnd.ToString());
            }
        }

        private Bus _bus;
        public Bus Bus
        {
            get { return _bus; }
            set
            {
                for (int i = 0; i < driverCollection.Length; i++)
                {
                    if (value is LuxuryBus && driverCollection[i].LiCenceType != LicenseType.HighLicense) throw new Exception("Bu sürücü bu aracı kullanamaz.");
                    else if (value is StandardBus && driverCollection[i].LiCenceType == LicenseType.None) throw new Exception("Bu sürücü bu aracı kullanamaz.");
                    else value = _bus;
                }
            }
        }

        public Route Route { get; }
        public DateTime DepartureTime { get; }          // otobüs seferinin planlı kalkış zamanı

        private DateTime _estimatedDepartureTime;
        public DateTime EstimatedDepartureTime          //Tahmini Kalkış Saati
        {
            get
            {
                if (EstimatedDepartureTime < DepartureTime) return _estimatedDepartureTime = DepartureTime;
                else return _estimatedDepartureTime;
            }
            set { _estimatedDepartureTime = value; }
        }

        private DateTime _estimatedArrivalTime;
        public DateTime EstimatedArrivalTime             //Tahmini Varış Zamanı
        {
            get { return _estimatedArrivalTime = (EstimatedDepartureTime.AddMinutes(Route.Duration)); }
        }

        public bool HasDeley                            //Gecikme Var
        {
            get
            {
                if (EstimatedDepartureTime > DepartureTime) return true;
                else return false;
            }
        }
        public bool HasSnackService { get; set; }       //Atıştırmalık Servisi

        public void AddDriver(Driver driver)
        {
            if (driverCollection.Length < (this.Route.Distance + 399) / 400)
            {
                if (Bus != null)
                {
                    if (Bus is StandardBus && driver.LiCenceType != LicenseType.None) driverCollection.AddDriver(driver);
                    /*else throw new Exception("Bu koşullarda Standartbus'ı bu şoför kullanamaz ve eklenemez.");*/
                    else if (Bus is LuxuryBus && driver.LiCenceType == LicenseType.HighLicense) driverCollection.AddDriver(driver);
                    /*else throw new Exception("Bu koşullarda Luxurybus'ı bu şoför kullanamaz ve eklenemez.");*/
                    else throw new Exception("Bu koşullarda sürücü eklenemez.");
                }
                // else driverCollection.AddDriver(driver);
            }
        }
        /*
         public void AddDriver(Driver driver)
        {
            if (_drivers.Length < (this.Route.Distance + 399) / 400)
            {
                Array.Resize(ref _drivers, _drivers.Length + 1);
                _drivers[_drivers.Length - 1] = driver;
            }
        }*/

        public void RemoveDriver(Driver driver)
        {
            driverCollection.RemoveDriver(driver);
        }
        /*public void RemoveDriver(Driver driver)
        {
            int IndexDriver = -1;
            for (int i = 0; i < _drivers.Length; i++)
            {
                if (driver.IdentityNumber == _drivers[i].IdentityNumber)
                {
                    IndexDriver = i;
                    break;
                }
            }
            if (IndexDriver > 0)
            {
                for (int i = IndexDriver; i < _drivers.Length - 1; i++)
                {
                    _drivers[i] = _drivers[i + 1];
                }
                Array.Resize(ref _drivers, _drivers.Length - 1);
            }
        }*/

        public void AddHost(Host host)
        {
            if (hostCollection.Length < (this.Route.Distance + 599) / 600) hostCollection.AddHost(host);
            else throw new Exception("HATA!!! Host eklenemez");
        }

        public void RemoveHost(Host host)
        {
            hostCollection.RemoveHost(host);
        }
        /*
        public void RemoveHost(Host host)
        {
            int IndexHost = -1;
            for (int i = 0; i < _hosts.Length; i++)
            {
                if (host.IdentityNumber == _hosts[i].IdentityNumber)
                {
                    IndexHost = i;
                    break;
                }
            }
            if (IndexHost > 0)
            {
                for (int i = IndexHost; i < _hosts.Length - 1; i++)
                {
                    _hosts[i] = _hosts[i + 1];
                }
                Array.Resize(ref _hosts, _hosts.Length - 1);
            }
        }*/

        //========================================PART9========================================//

        Ticket ticket;

        public decimal GetPriceOf(int seatNumber)                               //Fiyat Alın
        {
            SeatInformation seatInf = new SeatInformation();
            if (Bus is LuxuryBus) return Route.BasePrice * 135 / 100;
            else
            {
                if (seatInf.Section == SeatSection.LeftSide) return Route.BasePrice * 125 / 100;
                else return Route.BasePrice * 120 / 100;
            }
        }

        public Ticket SellTicket(Person person, int seatNumber, decimal fee)    //Bilet Sat
        {
            if (IsSeatAvailableFor(seatNumber, person.Gender))      //if (IsSeatAvailableFor(seatNumber && IsSeatEmpty(seatNumber), person.gender))
            {
                if (person is Host || person is Driver)
                {
                    fee = Route.BasePrice;
                    ticket = new Ticket(this, Bus.GetSeatInformation(seatNumber), person, fee);
                    //AddTicketToTicketArray(ticket);
                    AddTicketToTicketCollection(ticket);
                }
                else if (fee < GetPriceOf(seatNumber) + Route.BasePrice * 5 / 100)
                    throw new Exception("HATA!!! Bilet satışı gerçekleştirilemez.");
                else
                {
                    ticket = new Ticket(this, Bus.GetSeatInformation(seatNumber), person, fee);
                    //AddTicketToTicketArray(ticket);
                    AddTicketToTicketCollection(ticket);
                }
            }
            return ticket;
        }
        /*
        public void AddHost(Host host)
        {
            if (hostCollection.Length < (this.Route.Distance + 599) / 600) 
            hostCollection.AddHost(host);
        }*/

        /*public void RemoveHost(Host host)
        {
            hostCollection.RemoveHost(host);
        }*/

        /*private void AddTicketToTicketArray(Ticket ticket)
        {
            if (ticketCollection == null)
            {
                ticketCollection = new Ticket[1];
                Tickets[0] = ticket;
            }
            else
            {
                var TicketTemps = ticketCollection;
                Array.Resize(ref TicketTemps, TicketTemps.Length + 1);
                Tickets = TicketTemps;
                Tickets[Tickets.Length] = ticket;
            }
        }*/
        private void AddTicketToTicketCollection(Ticket ticket)
        {
            ticketCollection.AddTicket(ticket);
        }

        public Ticket[] SellDoubleTickets(Person person01, Person person02, int seatNumber, decimal fee) //Çift Bilet Satmak
        {
            Ticket[] tickets = new Ticket[2];

            if (!IsSeatEmpty(seatNumber))
                return null;
            else
            {
                if (Bus is StandardBus) return null;

                if (Bus.GetSeatInformation(seatNumber).Section == SeatSection.LeftSide) return null;
                else if (Bus.GetSeatInformation(seatNumber).Category == SeatCategory.Corridor && !IsSeatEmpty(seatNumber + 1)) return null;
                else if (Bus.GetSeatInformation(seatNumber).Category == SeatCategory.Window && !IsSeatEmpty(seatNumber - 1)) return null;

                if (fee / 2 < GetPriceOf(seatNumber) * 105 / 120) return null;

                if (Bus.GetSeatInformation(seatNumber).Category == SeatCategory.Corridor)
                {
                    Ticket bilet0 = new Ticket(this, Bus.GetSeatInformation(seatNumber), person01, fee / 2);
                    tickets[0] = bilet0;
                    //AddTicketToTicketArray(bilet0);
                    AddTicketToTicketCollection(ticket);
                    Ticket bilet1 = new Ticket(this, Bus.GetSeatInformation(seatNumber), person01, fee / 2);
                    tickets[1] = bilet1;
                    //AddTicketToTicketArray(bilet1);
                    AddTicketToTicketCollection(ticket);
                }
                else
                {
                    Ticket bilet0 = new Ticket(this, Bus.GetSeatInformation(seatNumber), person01, fee / 2);
                    tickets[0] = bilet0;
                    //AddTicketToTicketArray(bilet0);
                    AddTicketToTicketCollection(ticket);
                    Ticket bilet1 = new Ticket(this, Bus.GetSeatInformation(seatNumber), person01, fee / 2);
                    tickets[1] = bilet1;
                    //AddTicketToTicketArray(bilet1);
                    AddTicketToTicketCollection(ticket);
                }
                return tickets;
            }
        }

        public void CancelTicket(Ticket ticket) //Bilet İptal
        {
            ticketCollection.RemoveTicket(ticket);
        }
        /*public void CancelTicket(Ticket ticket) //Bilet İptal
        {
            int x = 0;
            Ticket[] temp = Tickets;
            Tickets = new Ticket[Tickets.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Equals(ticket))
                {
                    x++;
                    continue;
                }
                else Tickets[i - x] = temp[i];
            }
        }*/

        public bool IsSeatEmpty(int seatNumber) //Koltuk Boş Mu
        {
            for (int i = 0; i < ticketCollection.Length; i++)
            {
                if (ticketCollection[i].SeatInformation.Number == seatNumber) return false;
            }
            return true;
        }

        public bool IsSeatAvailableFor(int seatNumber, Gender gender) //Koltuk İçin Kullanılabilir Mi
        {
            bool result = true;
            if (Bus is StandardBus)
            {
                if (Bus.GetSeatInformation(seatNumber).Section == SeatSection.LeftSide)
                    result = false;
                else
                {
                    int nearSeat = seatNumber % 3 == 2 ? seatNumber + 1 : seatNumber - 1;
                    foreach (Ticket item in Tickets)
                    {
                        if (item.SeatInformation.Number.Equals(nearSeat))
                        {
                            result = item.Passenger.Gender.Equals(gender);
                            break;
                        }
                    }
                }
                return result;
            }
            else return false;
            //return result;
        }

        /*public SeatInformation GetSeatInformation(int seatNumber) //Koltuk bilgileri alın
        {
            SeatCategory category = new SeatCategory();
            SeatSection section = new SeatSection();
            if (Bus is StandardBus)
            {
                if (seatNumber%3==1)
                {
                    section = SeatSection.LeftSide;
                    category = SeatCategory.Singular;
                }
                else if(seatNumber%3==2)
                {
                    section = SeatSection.RightSide;
                    category = SeatCategory.Corridor;
                }
                else if(seatNumber%3==0)
                {
                    section = SeatSection.RightSide;
                    category = SeatCategory.Window;
                }
            }
            else
            {
                if (seatNumber%2==1)
                    section = SeatSection.LeftSide;
                else
                    section = SeatSection.RightSide;
                category = SeatCategory.Singular;
                
            }
            SeatInformation seatInf = new SeatInformation(seatNumber, section, category);
            return seatInf;
        }*/
    }
}
