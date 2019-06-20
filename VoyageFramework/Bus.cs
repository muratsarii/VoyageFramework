using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    abstract class Bus
    {
        private string _make;
        public string Make { get { return _make; } }
        private string _plate;
        public string Plate { get { return _plate; } set { _plate = value; } }
        public abstract int Capacity { get; }
        public virtual bool HasToilet { get; set; } // virtual yazınca macking e gerek kalmadı

        public abstract SeatInformation GetSeatInformation(int seatNumber);
    }
}
