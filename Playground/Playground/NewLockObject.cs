namespace Playground;

public class NewLockObject
{
    private object oldLockObject = new object();
    private Lock newLockObject = new Lock();
    
    public void LockThingWithNewLockObject() {
        
        // Is there actually any way to tell the difference between these two?
        
        lock(oldLockObject)
        {
            Console.WriteLine("Locked the old way");
        }
        
        lock (newLockObject)
        {
            Console.WriteLine("Locked the new way");
        }
    }
}