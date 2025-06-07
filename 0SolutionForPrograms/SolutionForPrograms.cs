
using System.Globalization;
using System.Transactions;

class str
{
    public int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }
}
class main
{
    public static void Main(String[] arg)
    {
        int[] a = { 1, 4, 6, 1, 2, 7 };

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array in Ascending Order:");
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < a[a.Length - 1])
            {

            }

        }

    }
}