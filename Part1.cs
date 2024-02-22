using System;

class Part1a
{
    static void Part1a()
    {
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = 0.5 * baseLength * height;

        Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");
        Console.ReadLine();
    }
}