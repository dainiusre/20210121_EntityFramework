using _20210120_Linq.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210121_EntityFramework.Database
{
    public class MokymaiContext: DbContext
    {
        public MokymaiContext(): base("Mokymai")
        {
        }

        public DbSet<Person> Persons { get; set; }

    }
}
