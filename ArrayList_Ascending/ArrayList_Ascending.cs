/*  WAP to add 5 integer numbers into ArrayList and display it. Sort that ArrayList in Ascending order and display    */
using System.Collections;

class ArrListAsce
{

}
class First
{
    public static void Main(string[] args)
    {
        ArrayList arr = new ArrayList();

        for (int i = 0; i < 5; i++)
        {
            arr.Add(Console.ReadLine());
        }
        Console.WriteLine("\nAfter Sorting in Ascending Order with Method");
        arr.Sort();
        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("With Logic:");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 4; j > i; j--)
            {
                if (((IComparable)arr[j - 1]).CompareTo(arr[j]) > 0)
                {
                    object? temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}