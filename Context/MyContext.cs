using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Context
{
    public class MyContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
