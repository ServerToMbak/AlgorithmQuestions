public class Program
{
    private static void Main(string[] args)
    {



        //MyStructure st = new MyStructure();
        //st.MyProperty =

        //MyStructure st = new MyStructure()
        //{
        //       MyProperty = 1
        //};


        //MyStructure st = new MyStructure()
        //{
        //    MyProperty = 1
        //};

        //st.a = 3;

        //Console.WriteLine(st.a);


        Console.Write(new Asd(2,3));
    }

   
}
struct Asd
{
    public Asd()
    {

    }
    int X;
    int Y;
    public Asd(int x, int y)
    {
        X = x;
        Y= y;
    }
    public override string ToString()
    {
        return $"{X} + {Y}";
    }
}
struct MyStructure
{
    //public int MyProperty { get; init; }
    //public MyStructure(int x)
    //{
    //    MyProperty = x;
    //}

    //public MyStructure(int s)
    //{
    //    MyProperty = s;
    //}

    public int MyProperty { get; set; }

  
    public int a { get; set; }
}
