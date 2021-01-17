using EntityUppgift.Data;
using EntityUppgift.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Managers
{
    public class PersonManager
    {
        public Person GetPersonById(int id)
        {
            using (var db = new EntityUppgiftContext())
            {
                var person = db.Person.Find(id);
                return person;
            }
        }
        public void CreatePerson(Person person)
        {
            using (var db = new EntityUppgiftContext())
            {
                db.Person.Add(person);
                db.SaveChanges();
            }
        }

    }
}
