using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Code_Practice___Booleans_and_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Vicky Le
            // Class: Programming 120
            // Date: 4/20/24
            // Code Practice - Booleans and Conditions Assignments
            // DisplayTemperatureMessage();
            // CheckOddOrEvenNumber();
            // LeapYearChecker();
            ShowingMenu();
        }
        public static void ShowingMenu()
        {
            bool exitRequested = false;

            while (!exitRequested)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Display Temperature Message");
                Console.WriteLine("2. Check Odd Or Even Number");
                Console.WriteLine("3. Leap Year Checker");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter your choice (1-4): ");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    DisplayTemperatureMessage();
                }
                else if (userInput == "2")
                {
                    CheckOddOrEvenNumber();
                }
                else if (userInput == "3")
                {
                    LeapYearChecker();
                }
                else
                {
                    Console.WriteLine("Exiting program. Have a great day!");
                    Console.ReadKey();
                }

            }

        } // ShowingMenu

        public static void DisplayTemperatureMessage()
        {
            try
            {
                // User enter the temperature
                Console.Write("Enter the temperature degree (F): ");
                int temperature = int.Parse(Console.ReadLine());

                // Display a different message depending on the temperature
                if (temperature <= 32)
                {
                    Console.WriteLine("That's freezing, be careful out there.");
                }
                else if (temperature >= 33 && temperature <= 50)
                {
                    Console.WriteLine("It's really cold out, bring a jacket.");
                }
                else if (temperature >= 51 && temperature <= 68)
                {
                    Console.WriteLine("It's starting to get cold. A sweater should work.");
                }
                else if (temperature >= 69 && temperature <= 75)
                {
                    Console.WriteLine("It's comfortable out. A shirt and jeans will work.");
                }
                else if (temperature >= 76)
                {
                    Console.WriteLine("It's T-shirt and shorts time.");
                }

            }
            catch
            {
                // Print an error message if there's an exception
                Console.WriteLine("Invalid input. Please enter a valid temperature.");
            }
        } // DisplayTemperatureMessage
        public static void CheckOddOrEvenNumber()
        {
            try
            {
                // User enter an integer
                Console.Write("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } // CheckOddOrEvenNumber()
        public static void LeapYearChecker()
        {
            try
            {
                // User enter a year
                Console.Write("Enter a year: ");
                int year = int.Parse(Console.ReadLine());

                // Determine whether the year is a leap year using the following criteria:
                // A year is a leap year if it is divisible by 4, except for years that are divisible by 100.
                // However, years that are divisible by 400 are also leap years.

                bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 4 == 0);
                    if (isLeapYear)
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                    else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                } 
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }
        } // LeapYearChecker()
    } // class
} // namespace


 
   