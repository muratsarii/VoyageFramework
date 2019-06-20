using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    class Route
    {
        public string Name
        {
            get
            {
                if (_distance < 200)
                {
                    string rota200 = string.Format("{0} - {1} / {2} KM'lik rota", DepartureLocation, ArrivalLocation, _distance);
                    return rota200;
                }
                else
                {
                    string rota = string.Format("{0} - {1} / {2} KM'lik {3} molalı rota", DepartureLocation, ArrivalLocation, _distance, _breakCount);
                    return rota;
                }
            }
        }

        public string DepartureLocation { get; private set; } // kalkış noktası
        public string ArrivalLocation { get; private set; } // varış noktası

        private int _distance;
        public int Distance { get { return _distance; } private set { _distance = value; } } // mesafe

        public Route(string departureLocation, string arrivalLocation, int distance)
        {

            DepartureLocation = departureLocation;
            ArrivalLocation = arrivalLocation;
            Distance = distance;
        }

        public int Duration => (int)Math.Ceiling((decimal)Distance * 45 / 60) + BreakCount * 30; // Süre

        private int _breakCount; // mola sayısı
        public int BreakCount
        {
            get
            {
                if (BreakCount > 0 && 200 <= BreakCount) return _breakCount = 0;
                else if (BreakCount > 200 && 400 < BreakCount) return _breakCount = 1;
                else return _breakCount = 2;
            }
            set { _breakCount = value; }
        }

        public decimal BasePrice //Baz Fiyatı
        {
            get
            {
                decimal roundTheNumbers, shortDistanceCharge = 5, longDistanceCharge = 4.25m, formula;
                int UnitLengthKM = 25, LessThanThreeHundred = 300, StrikingDistance = 12; //MoreThanThreeHundred

                roundTheNumbers = Math.Ceiling((decimal)Distance / UnitLengthKM);
                formula = (Distance > LessThanThreeHundred) ? StrikingDistance * shortDistanceCharge + ((roundTheNumbers - StrikingDistance) * longDistanceCharge) : (roundTheNumbers) * shortDistanceCharge;
                return formula;
            }
        }
    }
}
