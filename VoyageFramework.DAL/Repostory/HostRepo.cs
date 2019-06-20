using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.DAL
{
    public class HostRepo : RepoBase<Host>, IRepo<Host>
    {
        public HostRepo(DbContext busCtx) : base(busCtx)
        {

        }
    }
}
