using System;

class Part1b
{
    static void Part1b()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = CalculateFormula(i + 1);
        }
        Console.WriteLine("Array elements:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        int largestElement = FindLargestElement(numbers);
        Console.WriteLine($"The largest element in the array is: {largestElement}");
    }
    static int CalculateFormula(int n)
    {
        return n * n;
    }
    static int FindLargestElement(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
