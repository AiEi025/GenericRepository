using ClassLibrary2.Context;
using ClassLibrary2.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Services
{
    public class PersonRepsitory : IPersonRepository
    {
        private MyContext db;
        
        public PersonRepsitory(MyContext context)
        { 
            db=context;
        }
        public void DeletePerson(Person person)
        {
            db.Entry(person).State = EntityState.Deleted;
        }

        public void DeletePerson(int personId)
        {
            var person = GetPersonById(personId);
            DeletePerson(person);
        }

        public List<Person> GetAllPerson()
        {
            return db.Persons.ToList();
        }

        public Person GetPersonById(int personId)
        {
            return db.Persons.Find(personId);
        }

        public void InsertPerson(Person person)
        {
            db.Persons.Add(person);
        }

        public void save()
        {
            db.SaveChanges();
        }

        public void UpdatePerson(Person person)
        {
            
            db.Entry(person).State = EntityState.Modified;
        }
        



    }
}
