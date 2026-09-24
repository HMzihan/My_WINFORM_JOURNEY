using System;

class Xe
{
    static void Main()
    {
        int a;
        Console.Write("Enter : ");
        a = Convert.ToInt32(Console.ReadLine());


        Console.Write(a + " " + a + " " + a + " " + a + "\n");
        Console.Write(a + "" + a + "" + a + "" + a + "\n");

        Console.WriteLine("{0} {0} {0} {0}" , a);
        Console.WriteLine("{0}{0}{0}{0}", a);
    }
}
