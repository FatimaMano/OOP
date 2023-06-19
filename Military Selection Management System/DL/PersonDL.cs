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
        public static List<Person> PersonsList = new List<Person>();
        public void AddPerson(Person p)
        {
            PersonsList.Add(p);
        }
        public void RemovePerson(Person p)
        {
            PersonsList.Remove(p);
        }
    }
}
