using System.Diagnostics;
using System.Text;

internal class StringBuilder
{
    private static void Main(string[] args)
    {
        string s = "";

        Stopwatch sw1 = Stopwatch.StartNew(); //to know time to complete operation
        sw1.Start();

        for(int i=0;i<100000;i++)
        {
            s = s + i;
        }
        sw1.Stop();
        Console.WriteLine("String "+sw1.ElapsedMilliseconds); //sw1.ElapsedMilliseconds -> to print time in milisecond on console

        System.Text.StringBuilder sb = new System.Text.StringBuilder();  // we have to create object of SringBilder before using it

        Stopwatch sw2 = Stopwatch.StartNew(); //to know time to complete operation
        sw2.Start();
        for (int i=0;i< 100000;i++)
        {
            sb.Append(i); // mathod to extend string
        }
        sw2.Stop();
        Console.WriteLine("StringBuilder " + sw2.ElapsedMilliseconds); //sw2.ElapsedMilliseconds -> to print time in milisecond on console

        Console.ReadKey();
    }
}