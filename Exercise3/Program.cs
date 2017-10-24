using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            bool KeepGoing = true;
            while (KeepGoing)
            {
                Console.Clear();
                Console.WriteLine("Welcom to Details!");
                Console.WriteLine("1)Enter Details ");
                Console.WriteLine("2) Exit.....Bye! ");
                string input = Console.ReadLine();

                switch (input)
                {

                    case "1":
                        PersonInformation();
                        break;
                    case "2":
                        KeepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Bye....");
                        Console.ReadLine();
                        break;

                }
            }
        }
        public static void PersonInformation()
        {
            string input;
            string fName;
            string lName;
            double height;
            double weight;
            int age = 0;
            bool correctAge = true;
            string heightt;
            string weightt;
            do
            {
                if (!correctAge)
                {
                    Console.WriteLine("Please Try Again \n");
                }
                Console.Clear();
                Console.Write("Welcome! ");
                input = Console.ReadLine();
                correctAge = int.TryParse(input, out age);
            }
            while (correctAge);
            if (age >= 0)
            {
                Console.WriteLine("what is your age:");
                age = int.Parse(Console.ReadLine());
                Console.Write("What is your first name? ");
                fName = Console.ReadLine();
                Console.Write("What is your last name? ");
                lName = Console.ReadLine();
                Console.Write("What's your height?: ");
                heightt = Console.ReadLine();
                double.TryParse(heightt, out height);
                Console.Write("What's your weight? ");
                weightt = Console.ReadLine();
                double.TryParse(weightt, out weight);


                Console.WriteLine("Hello " + fName + " " + lName + " " + " yrou are: " + age + " years old " + " with " + height + " and " + weightt + " weight");
                Console.ReadLine();
            }

            else if (age < 0)
            {
                Console.WriteLine("Please try Again\n and Inseart a valid age... ");
                Console.ReadLine();
            }

        }
    }
}