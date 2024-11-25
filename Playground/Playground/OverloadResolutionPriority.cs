namespace Playground;

public class OverloadResolutionPriority
{
    public static void MyMethod(params int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    
    public static void MyMethod(params IEnumerable<int> numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    
}