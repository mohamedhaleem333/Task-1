using System;

class CarpetCleaningEstimate
{
    static void Main()
    {
        const double pricePerSmall = 25.0;
        const double pricePerLarge = 35.0;
        const double taxRate = 0.06;

        Console.WriteLine("Islam's Carpet Cleaning Service\n");

        int numSmall, numLarge;

        Console.Write("Enter number of small carpets: ");
        while (!int.TryParse(Console.ReadLine(), out numSmall) || numSmall < 0)
        {
            Console.Write("Invalid input. Please enter a valid positive number: ");
        }

        Console.Write("Enter number of large carpets: ");
        while (!int.TryParse(Console.ReadLine(), out numLarge) || numLarge < 0)
        {
            Console.Write("Invalid input. Please enter a valid positive number: ");
        }

        double cost = (numSmall * pricePerSmall) + (numLarge * pricePerLarge);
        double tax = cost * taxRate;
        double total = cost + tax;

        Console.WriteLine("\nEstimate for carpet cleaning service");
        Console.WriteLine($"Number of small carpets: {numSmall}");
        Console.WriteLine($"Number of large carpets: {numLarge}");
        Console.WriteLine($"Price per small carpet: ${pricePerSmall}");
        Console.WriteLine($"Price per large carpet: ${pricePerLarge}");
        Console.WriteLine($"Cost : ${cost:F2}");
        Console.WriteLine($"Tax: ${tax:F2}");
        Console.WriteLine("===============================");
        Console.WriteLine($"Total estimate: ${total:F2}");
        Console.WriteLine("This estimate is valid for 30 days");
    }
}
