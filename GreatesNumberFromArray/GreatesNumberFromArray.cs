using System;
class Greatest
{
    public static void Main(string[] arg)
    {
        int a, b;

        Console.WriteLine("Enter Two Nunbers:");

        //to ways to type cast string into any dada type
        a = int.Parse(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());


        if (b > a || b > a)
        {
            Console.WriteLine("b is greatest");
        }
        else
        {
            Console.WriteLine("a is greatest");
        }
    }
}