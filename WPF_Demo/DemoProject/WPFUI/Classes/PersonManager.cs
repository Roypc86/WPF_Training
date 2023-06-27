using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Classes
{
    class PersonManager
    {
        public List<Person> GetPeople()
        {
            List<Person> person_list = new List<Person>();
            person_list.Add(new Person { FirstName = "Adam", LastName = "Figeres" });
            person_list.Add(new Person { FirstName = "Tom", LastName = "Pas" });
            person_list.Add(new Person { FirstName = "Charles", LastName = "Hemsworth" });
            return person_list;
        }
    }
}
