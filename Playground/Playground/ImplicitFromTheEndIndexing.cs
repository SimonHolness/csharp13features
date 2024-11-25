namespace Playground;

public class ImplicitFromTheEndIndexing
{
    public static void PrintWords()
    {
        var words = new MyContainer()
        {
            Words =
            {
                [0] = "alpha",
                [1] = "bravo",
                [2] = "charlie",
                [^2] = "delta",
                [^1] = "echo"
            }
        };
        
        foreach (var word in words.Words)
        {
            Console.WriteLine(word);
        }
    }
    
    class MyContainer
    {
        public string[] Words = new string[5];
    }
    
}
