using System;
using System.Diagnostics.Metrics;

class A
{
    private int[] Arr;
    private int Temp;
    public void SetArr(int[] arr)
    {
        Arr = arr;

    }
    public int[] RevArr()
    {
        int r = Arr.Length;
        r = r - 1;
        for (int i = 0; i < r; i++)
        {
            Temp = Arr[i];
            Arr[i] = Arr[r];
            Arr[r] = Temp;
            r--;
        }

        //for (int i = 0; i < Arr.Length; i++)
        //{
        //    Console.Write(Arr[i] + " ");
        //}
        return Arr;
    }

}

class M
{
    public static void Main(String[] arr)
    {

        Console.WriteLine("Enter 5 Array");
        int[] array = new int[5];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        A a = new A();
        a.SetArr(array);
        Console.WriteLine();
        int[] Rev = a.RevArr();
        for (int i = 0; i < Rev.Length; i++)
        {
            Console.Write(Rev[i] + " ");
        }
    }
}