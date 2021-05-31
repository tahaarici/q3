using System;
public class SwapExample
{
    public static void Main(string[] args)
    {
        int a = 3, b = 6;
        Console.WriteLine("Before swap a=" + a + "b=" + b);
        a = a*b; //a=18 (3*6)
        b = a/b;  //b=3 (18/6)
        a = a/b; //a=6 (18/3)
        Console.WriteLine("After swap a=" + a + "b=" + b);
    }

}
