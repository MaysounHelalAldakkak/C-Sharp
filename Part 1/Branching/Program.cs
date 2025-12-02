using System;

class PackageExpress
{
    static void Main()
    {
        // Greet the user and prompt them to enter package details.
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask for package weight.
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the weight is greater than 50. If so, show an error and exit.
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program.
        }

        // Ask for package width.
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Ask for package height.
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Ask for package length.
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the total dimensions (width + height + length) is greater than 50.
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program.
        }

        // Calculate the shipping quote.
        double totalDimensions = width * height * length; // Multiply width, height, and length.
        double quote = (totalDimensions * weight) / 100;   // Multiply by weight and divide by 100.

        // Display the shipping quote.
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Thank the user.
        Console.WriteLine("Thank you!");
    }
}
