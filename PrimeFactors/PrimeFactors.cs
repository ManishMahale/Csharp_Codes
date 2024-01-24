using System;

class PF
{
    public int n { get; set; }

    public void SetData(int n)
    {
        this.n = n;
    }

    public void Primefact()
    {       
        for (int i = 2; i <= n / 2; i++)
        {
            
            bool flag = true;
            if (n % i == 0)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }                   
                }
                if (flag)
                {
                    Console.WriteLine(i);
                }

            }
            
        }
    }
}
class M
{
    public static void Main(string[] arr)
    {
        int n;
        PF pF = new PF();
        Console.WriteLine("Enter  Number ");
        n = Convert.ToInt32(Console.ReadLine());
        pF.SetData(n);
        Console.WriteLine();
        pF.Primefact();
    }
}