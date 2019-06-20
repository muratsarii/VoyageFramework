using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.DAL
{
    public class LuxuryBusRepo : RepoBase<LuxuryBus>, IRepo<LuxuryBus>
    {
        public LuxuryBusRepo(DbContext busCtx) : base(busCtx)
        {

        }
        
    }
}
