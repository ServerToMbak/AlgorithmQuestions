using Polymorphism;

public class Program
{
    private static void Main(string[] args)
    {

        BaseClass bc = new BaseClass();
        DerivedClass dc = new DerivedClass();
        BaseClass bcdc = new DerivedClass();

        
        //bc.Method2();
        
        //dc.Method2();
        //bcdc.Method2();
        

        //
        bc.Method1();
        dc.Method1();
        bcdc.Method1();
    }
}