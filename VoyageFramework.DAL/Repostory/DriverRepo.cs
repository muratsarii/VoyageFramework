using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.DAL
{
    public class DriverRepo : RepoBase<Driver>, IRepo<Driver>
    {
        public DriverRepo(DbContext busCtx) : base(busCtx)
        {

        }
    }
}
