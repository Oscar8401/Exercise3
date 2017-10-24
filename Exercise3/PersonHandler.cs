using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class PersonHandler
    {
        public void SetAge (Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson (int age, string fname, string lname, double height, double weight)
        {


            Person hello = new Person();
            hello.Age = age;
            hello.FName = fname;
            hello.LName = lname;
            hello.Weight = weight;
            hello.Height = height;
            return hello;
        }
    }
}
