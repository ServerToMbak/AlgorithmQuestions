using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Program
{
    private static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("abcd");
        String str1 = "abcd";
        String str2 = null;
        Object o2 = null;

        //Console.WriteLine();
        //Console.WriteLine(" *  The value of String str1 is '{0}'.", str1);
        //Console.WriteLine(" *  The value of StringBuilder sb is '{0}'.", sb.ToString());
        Console.WriteLine(sb.Equals();
        Console.WriteLine(str1.Equals(sb));
        Console.WriteLine();
        Console.WriteLine("1a) String.Equals(Object). Object is a StringBuilder, not a String.");
        Console.WriteLine("    Is str1 equal to sb?: {0}", str1.Equals(sb));

        Console.WriteLine();
        Console.WriteLine("1b) String.Equals(Object). Object is a String.");
        str2 = sb.ToString();
        o2 = str2;
        Console.WriteLine(" *  The value of Object o2 is '{0}'.", o2);
        Console.WriteLine("    Is str1 equal to o2?: {0}", str1.Equals(o2));

        Console.WriteLine();
        Console.WriteLine(" 2) String.Equals(String)");
        Console.WriteLine(" *  The value of String str2 is '{0}'.", str2);
        Console.WriteLine("    Is str1 equal to str2?: {0}", str1.Equals(str2));

        Console.WriteLine();
        Console.WriteLine(" 3) String.Equals(String, String)");
        Console.WriteLine("    Is str1 equal to str2?: {0}", String.Equals(str1, str2));
    }
}