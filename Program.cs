using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSHARP_IN_ONE_DAY_CHAPTERS
{
    class Program
    {
        static void Main(string[] args)
        {

            ///HelloWorldAgain - A simple program that accepts user input with basic validation to display a custom message to the console
            string userName = "";
            int userAge = 0,
                currentYear = 0;

            //GET User Name
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            //GET User Age
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());

            //Respond accordingly based on age answer
            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid Age");
                Console.WriteLine("Age must be between 0 and 100");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Sorry, you are underage");
            }
            else if (userAge < 21)
            {
                Console.WriteLine("You need parental consent");
            }
            else
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You may sign up for this event!");
            }

            Console.Write("Please enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello World! My name is {0} and I am {1} years olds and I was born in {2}.", userName, userAge, currentYear - userAge);

            //For Every Exercise
            Console.Read();
        }
    }
}
