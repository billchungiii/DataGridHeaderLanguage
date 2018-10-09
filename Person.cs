using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridHeaderLanguage
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class MainViewModel
    {
        public List<Person> People { get; set; }

        public MainViewModel()
        {
            People = new List<Person>
            {
                new Person {Name = "Bill" , Age = 25},
                new Person {Name = "David" , Age = 27}
            };
        }
    }
}
