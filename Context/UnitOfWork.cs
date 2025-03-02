using ClassLibrary2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Context
{
    public class UnitOfWork : IDisposable
    {
        MyContext db = new MyContext();
        private MyGenericRepository<Person> personrepository;
        public MyGenericRepository<Person> personRepository
        {
            get
            {
                if (personRepository == null)
                {
                    personRepository = new MyGenericRepository<Person>(db);
                }
                return personRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
