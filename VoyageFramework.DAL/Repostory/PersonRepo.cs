using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.DAL
{
    public class PersonRepo : RepoBase<Person>, IRepo<Person>
    {
        public PersonRepo(DbContext busCtx) : base(busCtx)
        {

        }
    }
}
