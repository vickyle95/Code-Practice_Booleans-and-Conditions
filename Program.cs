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
        }
        public static void ShowingMenu()
        {


        } // ShowingMenu
        
        public static void DisplayTemperatureMessage()
        {
            try
            {
                Console.Write("Enter the temperature degree (F): ");
                int temperature = int.Parse(Console.ReadLine());

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
                Console.WriteLine("Invalid input. Please enter a valid temperature.");
            }
            
            

        } // main
    } // class
} // namespace
