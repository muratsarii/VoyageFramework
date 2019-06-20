using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    class Driver : Person
    {
        private LicenseType _licenseType;
        public LicenseType LiCenceType { get; set; }

        public Driver(string FirstName, string LastName, LicenseType licenceType, DateTime DateofBirthdriver) : base(FirstName, LastName)
        {
            if (Age < 25) throw new Exception("25 Yaşından küçük Driver elemanı olamaz !");
            else
            {
                _licenseType = licenceType;
                DateofBirthdriver = DateOfBirth;
            }
        }
    }
}
