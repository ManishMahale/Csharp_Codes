class FindExeption
{
    public static void Main()
    {
        int[] arr = new int[5] { 0, 1, 2, 3, 4 };

        try
        {
            int n = arr[5];
        }
        catch (IndexOutOfRangeException iex)
        {
            Console.WriteLine(iex.Message);
        }

        Console.WriteLine("Enter string");
        try
        {
            int num1 = int.Parse(Console.ReadLine()); // input: abc
        }
        catch (FormatException fex)
        {
            Console.WriteLine(fex.Message);
        }
    }
}