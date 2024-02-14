class Program
{
    static int sum(int n)
    {
        if (n != 0)
        {
            return n + sum(n - 1);
        }
        else
        {
            return n;
        }
    }

    static void Main()
    {
        int number = 4;
        int result = sum(number);

        Console.WriteLine("sum = {0}", result);
    }
}
