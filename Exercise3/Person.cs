using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Person
    {
        //private field inside the class Person.
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;


        //public properties with get and set that fetch each variable.
        //we use void with function that doesn't return anything.
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        //public properties with get and set that fetch each variable.
        //we use void with function that doesn't return anything.

        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        //public properties with get and set that fetch each variable.
        //we use void with function that doesn't return anything.

        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
        //public properties with get and set that fetch each variable.
        //we use void with function that doesn't return anything.

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        //public properties with get and set that fetch each variable.
        //we use void with function that doesn't return anything.

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
    }
}
