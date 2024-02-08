public class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine(Question2());



        
        
    }


   
    public static long Question2()
    {
        Func<int, long> Foo(Func<int> f1, Func<int, int, long> f2)
        {
            return (int x) => f2(f1(),2) + x;
        }
        var result = Foo(() => 10, (int x, int y) => x * y).Invoke(3);

        return result; // returns --> 23 
    }





    #region LINQ Questions
    //--1
    //int[] array = { 1, 2, 3, 4, 5, 6, 7 };
    //int element = array.First(element => element > 5 && element < 6 );
    // if the sequence is empty then single, first methods will throw an error // system invalid operation exception  'sequence contains no matching element'
    // but firstOrDefault aND SingleOrDefault, count methods will return 0

    #endregion


    #region Abstract 
        // 1
        //abstract class MyClass
        //{
        //    public virtual int number { get => 0; } // we can override in sub class

        //    public abstract void Foo();

        //    public abstract int Number { get => 0; }*/ //ERORR => we can not declare a body because property signed as abstracy


        //    static readonly int number1 = 5; //the filed is not accessible(not public) and even if it were public would return 0

        //    public abstract void Foo1() { } // abstract methods can not have a body(abstract means is missing something so no bodyyy) 
        //}
        //class DeriveredClass : MyClass
        //{
        //    public override void Foo()
        //    {
        //        throw new NotImplementedException();
        //    }
    //}
    #endregion

}

class MyClass
{

    //Question : which properties can be initalized in the contstructor
    
    public int Value { get; } // Valid

    /*  public int Value => this.Value;*/  // Not valid readonly field(get method) because of the constructor --> we can not assign a read only field

   /* private int Value { get; set; }*/      // Valid

    /*public int Value { get => this.Value; }*/     // Not valid readonşy field(get method) because of the constructor --> we can not assign a read only field

/*    public int Value { get; set; }*/  //Valid 

    public MyClass()
    {
       this.Value = 1;
    }
}

//Qustion--1

//interface IFoo { int Foo(); }
//interface IBar : IFoo {new int Foo(); }
//interface IBaz : IBar { new int Foo(); }

//class Myclass : IFoo, IBar, IBaz
//{
//    public int Foo() => 1;
//    int IFoo.Foo() => 2;

//}

//MyClass obj = new Myclass();
//Console.WriteLine(obj.Foo());obj.Foo() --> returns 1. IFoo.Foo() => 


