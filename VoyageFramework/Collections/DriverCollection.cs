using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    class DriverCollection
    {
        public int Length { get { return _drivers.Length; } }

        private Driver[] _drivers;

        public Driver this[int index] { get { return _drivers[index]; } }

        public void AddDriver(Driver driver)
        {
            if (_drivers == null)
            {
                _drivers = new Driver[1];
                _drivers[0] = driver;
            }
            else
            {
                Array.Resize(ref _drivers, _drivers.Length + 1);
                _drivers[_drivers.Length - 1] = driver;
            }
        }

        public void RemoveDriver(Driver driver)
        {
            int indexOfDriver = -1;
            for (int i = 0; i < _drivers.Length; i++)
            {
                if (driver.IdentityNumber == _drivers[i].IdentityNumber) indexOfDriver = i;
            }
            if (indexOfDriver > 0)
            {
                for (int i = indexOfDriver; i < _drivers.Length - 1; i++)
                {
                    _drivers[i] = _drivers[i + 1];
                }
                Array.Resize(ref _drivers, _drivers.Length - 1);
            }
        }
        /*
        public void RemoveDriver(Driver driver)
        {
            RemoveDriverAt(IndefOfDriver(driver));
        }
        private int IndefOfDriver(Driver driver)
        {
            for (int i = 0; i < _drivers.Length; i++)
            {
                if (_drivers[i].IdentityNumber == driver.IdentityNumber) return i;   //benim indeksimi döndürüyor
            }
            return -1;
        }
        private void RemoveDriverAt(int indexofdriver)
        {
            if (indexofdriver>0)
            {
                for (int i = indexofdriver; i < _drivers.Length - 1; i++)
                {
                    _drivers[i] = _drivers[i + 1];
                }
                Array.Resize(ref _drivers, _drivers.Length - 1);
            }
        }*/
    }
}
