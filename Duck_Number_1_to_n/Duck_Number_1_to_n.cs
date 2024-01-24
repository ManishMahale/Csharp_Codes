
class duck
{
    int n;
    public void setData(int n)
    {
        this.n = n;
    }

    public void Find()
    {
        int rem;
        int flag = 1;
        for (int i = 1; i <= n; i++)
        {           
            int x = i;
            while (x != 0)
            {
                rem = x % 10;
                if (rem == 0)
                {
                    flag = 0;
                    Console.WriteLine(i);
                    break;
                }
                x = x / 10;
            }
        }
        if (flag != 0)
        {
            Console.WriteLine("duck nuber not found");
        }
    }
}
class M
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Range:");
        int n;
        n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        duck d = new duck();
        
        d.setData(n);
        d.Find();

    }
}