internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Size Of byte "+sizeof(byte));
        Console.WriteLine($"byte range: { byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine();

        Console.WriteLine("Size Of short "+sizeof(short));
        Console.WriteLine($"short range: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine();

        Console.WriteLine("Size Of unsort "+sizeof(ushort));
        Console.WriteLine($"ushort range: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine();

        Console.WriteLine("Size Of int "+sizeof(int));
        Console.WriteLine($"int range: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine();

        Console.WriteLine("Size Of unit "+sizeof(uint));
        Console.WriteLine($"unit range: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine();

        Console.WriteLine("Size Of long "+sizeof(long));
        Console.WriteLine($"long range: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine();

        Console.WriteLine("Size Of ulong"+sizeof(ulong));
        Console.WriteLine($"ulong range: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine();

        Console.WriteLine("Size Of float "+sizeof(float));
        Console.WriteLine($"float range: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine();

        Console.WriteLine("Size Of duble "+sizeof(double));
        Console.WriteLine($"duble range: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine();

        Console.WriteLine("Size Of decimal "+sizeof(decimal));
        Console.WriteLine($"decimal range: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine();

        Console.ReadLine();
    }
}