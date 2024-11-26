using System.Runtime.CompilerServices;

namespace Playground;

public class OverloadResolutionPriority
{
    public static void MyMethod(params int[] numbers)
    {
        Console.WriteLine("Using the old way");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    
    [OverloadResolutionPriority(1)]
    public static void MyMethod(params IEnumerable<int> numbers)
    {
        Console.WriteLine("Using the new way");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    
}