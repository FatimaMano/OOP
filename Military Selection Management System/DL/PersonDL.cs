using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;

namespace Military_Selection_Management_System.DL
{
    class PersonDL
    {
        List<Person> Persons = new List<Person>();
        public void AddPerson(Person p)
        {
            Persons.Add(p);
        }
        public void RemovePerson(Person p)
        {
            Persons.Remove(p);
        }
    }
}
