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
                Console.WriteLine("Welcome User you're at the Right Place" +
                    "Please Have a moment And Answer Our Questions. ");
                Console.WriteLine("1) Go ahead... ");
                Console.WriteLine("2) Exit Program... ");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        PersonInformation();
                        break;
                    case "0":
                        KeepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Incorect input \n Try Again");
                        Console.ReadKey();
                        break;
                    
                }
            }
        }
        public static void PersonInformation()
        {
            string input;
            int age = 0;
            bool correctAge = true;

            do
            {
                if (!correctAge)
                {
                    Console.WriteLine("Please Try Again \n");
                }
                Console.Clear();
                Console.Write("How old are you?: ");
                input = Console.ReadLine();
                correctAge = int.TryParse(input, out age);
            }
            while (!correctAge);
            if ( age >= 0)
            {
                Console.Write("What is your first name? ");
                input = Console.ReadLine();
                Console.Write("What is your last name? ");
                input = Console.ReadLine();
                Console.Write("How long are you?: ");
                input = Console.ReadLine();
                Console.Write("How much you weight? ");
                input = Console.ReadLine();
            }
            else if (age < 0)
            {
                Console.WriteLine("Please try Again\n and Inseart a valid age... ");
                Console.ReadLine();
            }
        }


        
    }
}

