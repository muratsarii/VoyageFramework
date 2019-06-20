using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.DAL
{
    public class StandardBusRepo : RepoBase<StandardBus>, IRepo<StandardBus>
    {
        public StandardBusRepo(DbContext busCtx) : base(busCtx)
        {

        }
    }
}
