using System; // Allows us to use basic system functions like Console

namespace PackageExpress // Defines the namespace for this application
{
    class Program // Main class of the application
    {
        static void Main(string[] args) // Entry point of the console application
        {
            // Display a welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            
            // Read user input and convert it to a decimal value
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package exceeds the maximum allowed weight
            if (weight > 50)
            {
                // Inform the user that the package is too heavy and exit the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program early
            }

            // Ask the user to enter the package width
            Console.WriteLine("Please enter the package width:");
            
            // Read and convert width input
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Ask the user to enter the package height
            Console.WriteLine("Please enter the package height:");
            
            // Read and convert height input
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Ask the user to enter the package length
            Console.WriteLine("Please enter the package length:");
            
            // Read and convert length input
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if the total dimensions exceed the allowed size limit
            if (width + height + length > 50)
            {
                // Inform the user that the package is too large and exit the program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program early
            }

            // Calculate the shipping quote based on dimensions and weight
            // Formula: (width * height * length * weight) divided by 100
            decimal quote = (width * height * length * weight) / 100;

            // Display the calculated shipping cost formatted to two decimal places
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            
            // Display a closing message
            Console.WriteLine("Thank you!");
        }
    }
}
