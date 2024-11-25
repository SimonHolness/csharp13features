namespace Playground;


public partial class PartialProperties
{
    // This works, but Rider really doesn't like it
    public partial string Name { get; set; }
} 

public partial class PartialProperties
{
    // implementation declaration:
    private string _name = "dummy";

    public partial string Name
    {
        get => _name;
        set => _name = value;
    }
}