using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    class Host : Person
    {
        public Host(string FirstName, string LastName, DateTime DateofBirthost) : base(FirstName, LastName)
        {
            if (Age < 18) throw new Exception("18 Yaşından küçük Host elemanı olamaz !");
            else DateOfBirth = this.DateOfBirth;
        }
    }
}
