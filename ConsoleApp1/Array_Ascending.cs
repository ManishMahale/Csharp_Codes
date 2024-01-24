/*
 Write a program to add 5 integer numbers into array and display it. Sort array in ascending order and display
*/
using System.Collections.Concurrent;

class Ascending
{
    public int[] Arr { get; set; }
    public Ascending(int[] a)
    {
        Arr = a;
    }
    public int[] Sort()
    {
        for(int i = 0; i < Arr.Length; i++)
        {
            for(int j = i+1;j< Arr.Length; j++)
            {
                if (Arr[i] > Arr[j])
                {
                    int temp = Arr[i];
                    Arr[i] = Arr[j];
                    Arr[j] = temp;
                }
            }
        }
        return Arr;
    }
}
class First
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter five Numbers:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Ascending ascending = new Ascending(arr);
        Console.WriteLine();
        int[] result = ascending.Sort();
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}