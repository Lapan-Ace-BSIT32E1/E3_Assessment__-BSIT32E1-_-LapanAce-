using System;

class Program
{
    static void Main()
    {
        // Prompt user for input
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle
        double area = 0.5 * baseLength * height;

        // Display the result
        Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");

        // Keep the console window open
        Console.ReadLine();
    }
}