using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class PersonHandler
    {
        private List<Person> list = new List<Person>();
        public void Add(Person person)
        {
            list.Add(person);



        }

        public void List()
        {
            foreach (var Person in list)
            {
                // Console.WriteLine("Age:" + Person.age);
                 Console.WriteLine("Name:" + Person.fName);
                   Console.WriteLine("Name:" + Person.lName);
                Console.WriteLine("height:" + Person.height);
                Console.WriteLine("weight:" + Person.weight);
                   Console.WriteLine(Person.ToString());
                Console.WriteLine(Person);
                Console.ReadLine();
            }

        }


    }
}
