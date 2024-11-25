namespace Playground;

public interface IMyInterface
{
    int GetNumber();
}

public ref struct RefStruct : IMyInterface
{
    public int MyNumber { get; set; }
    
    public int GetNumber()
    {
        return MyNumber;
    }
}

public class RefStructExample
{
    public static void DoStuff2<T>(T myThing) where T : IMyInterface, allows ref struct
    {
        Console.WriteLine(myThing.GetNumber());
    }
}