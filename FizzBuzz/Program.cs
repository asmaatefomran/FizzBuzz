using System;

namespace FizzBuzz;

class Program
{
    static void Main()
    {
        string input = "Mary had a little lamb\n" +
                       "Little lamb, little lamb\n" +
                       "Mary had a little lamb\n" +
                       "It's fleece was white as snow";

        FizzBuzzDetector detector = new FizzBuzzDetector();

        var result = detector.getOverlappings(input);

        Console.WriteLine(result.Output);
        Console.WriteLine();
        Console.WriteLine($"count: {result.totalCount}");
    }
}