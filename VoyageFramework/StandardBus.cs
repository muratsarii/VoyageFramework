using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    class StandardBus : Bus
    {
        public override int Capacity { get { return 30; } }
        public override bool HasToilet { get { return false; } }
        public override SeatInformation GetSeatInformation(int seatNumber)
        {
            SeatCategory category = new SeatCategory();
            SeatSection section = new SeatSection();
            if (seatNumber % 3 == 1)
            {
                section = SeatSection.LeftSide;
                category = SeatCategory.Singular;
            }
            else if (seatNumber % 3 == 2)
            {
                section = SeatSection.RightSide;
                category = SeatCategory.Corridor;
            }
            else if (seatNumber % 3 == 0)
            {
                section = SeatSection.RightSide;
                category = SeatCategory.Window;
            }
            SeatInformation seatInf = new SeatInformation(seatNumber, section, category);
            return seatInf;
        }
    }
}
