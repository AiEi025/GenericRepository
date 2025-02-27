using ClassLibrary2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Repository
{
    public interface IPersonRepository
    {
        List<Person> GetAllPerson();
        Person GetPersonById(int personId);
        void InsertPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
        void DeletePerson(int personId);
        void save();
        
    }
}
