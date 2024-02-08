public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Car car = new Car();
      car.GoVoidMethod();
        car.BaseMethod();
    }


}

abstract class Vehicle
{
    protected int speed { get; set; } 


    void Go()
    {
        Console.WriteLine("THE vehicle abstract classes go method runs");
    }
    public void BaseMethod()
    {
        Console.WriteLine("Base method withput any implemantation");
    }
    public abstract void GoAbstarctMethod();

    public virtual void GoVoidMethod()
    {
        Console.WriteLine("The vehicle abstract class's GoVoidMethod runs");
    }
}

class Car : Vehicle
{

    public override void GoAbstarctMethod()
    {
        throw new NotImplementedException();
    }
    public override void GoVoidMethod()
    {
        base.GoVoidMethod();
    }
    
}