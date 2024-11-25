
using System.Collections;

namespace Playground;

public class ParamsCollections
{
    // Old way - only array available
    public static void MyMethod(params int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    
    // can now use any collection
    public static void MyMethod2(params List<string> names)
    {
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
    
    // including custom collections that implement IEnumerable and have an .Add() method
    public static void MyMethod3(params MyEnumerable<string> enumerable)
    {
        foreach (var item in enumerable)
        {
            Console.WriteLine(item);
        }
    }

    // and even IEnumerable ... a backing collection is created automatically
    public static void MyMethod4(params IEnumerable<double> enumerable)
    {
        foreach (var item in enumerable)
        {
            Console.WriteLine(item);
        }
    }

    
    public class MyEnumerable<T> : IEnumerable<T>
    {
        private List<T> mylist = new List<T>();
        
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return mylist.GetEnumerator();
        }

        // Add() is not part of the interface, but is required to be used with params
        public void Add(T item)
        {
            mylist.Add(item);
        }
        
        public IEnumerator GetEnumerator()
        {
            return mylist.GetEnumerator();
        }
    }
}