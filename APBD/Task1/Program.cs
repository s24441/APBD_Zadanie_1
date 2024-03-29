﻿namespace APBDTask1;

public class Program
{
    public static void Main(string[] args)
    {
        var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        foreach (var i in list)
            Console.WriteLine(i);

        Console.WriteLine($"Average: {list.Avg()}");
        Console.WriteLine($"Max: {list.MaxValue()}");

        Console.WriteLine("Program end");
    }
}

public static class MathExtensions
{
    public static double? Avg(this IEnumerable<int> ints)
    {
        if (!ints.Any()) return null;

        double sum = 0;
        foreach (var i in ints)
            sum += i;

        return sum/ints.Count();
    }

    public static int? MaxValue(this IEnumerable<int> ints) 
    {  
        if (!ints.Any()) return null;

        int max = ints.First();
        foreach(var i in ints.Skip(1))
        {
            if (i > max)
                max = 1;
        }

        return max;
    }
}