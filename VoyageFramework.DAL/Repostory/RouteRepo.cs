using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.DAL
{
    public class RouteRepo : RepoBase<Route>, IRepo<Route>
    {
        public RouteRepo(DbContext busCtx) : base(busCtx)
        {

        }
    }
}
