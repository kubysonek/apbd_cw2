namespace apbd_cw2.inheritance;

public class A : IMyInterface
{
    
    //Właściwość / property / getter&setter
    public int Number { get; set; }
    
    public A(int number)
    {
        Number = number;
    }

    public virtual void DoSomething()
    {
        Console.WriteLine("A");
    }
}