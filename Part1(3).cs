using System;

class Part1c
{
    static void Part1c()
    {
        Console.WriteLine("Number\tSquare Root");
        Console.WriteLine("------------------");
        
        for (int i = 1; i <= 10; i++)
        {
            double squareRoot = Math.Sqrt(i);
            Console.WriteLine($"{i}\t{squareRoot}");
        }
    }
}