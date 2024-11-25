using System.Runtime.CompilerServices;

namespace Playground;

public interface IMyOverloadInterface
{
    int GetNumber();
}
public interface IMySecondOverloadInterface
{
    string GetString();
}

public class ImplementEverything : IMyOverloadInterface, IMySecondOverloadInterface
{
    public int GetNumber()
    {
        return 7; // random number
    }

    public string GetString()
    {
        return "My name is Inigo Montoya. You killed my father. Prepare to die";
    }
}

public class OverloadResolutionPriority2
{
    public string DoStringify(IMyOverloadInterface myThing)
    {
        return myThing.GetNumber().ToString();
    }
    
    [OverloadResolutionPriority(1)]
    public string DoStringify(IMySecondOverloadInterface myThing)
    {
        return myThing.GetString();
    }
}