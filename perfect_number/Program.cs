internal class Perfect
{
    private static void Main(string[] args)
    {
        int i, j, sum, no;

        Console.WriteLine("Enter Range");
        no = int.Parse(Console.ReadLine());

        for (i = 1;i <= no; i++)
        
        {
            sum = 0;
            for(j=1; j<= (i/2); j++)
            {
                if(i % j == 0)
                {
                    sum = sum + j;
                }
            }
            if(sum==i)
            {
                Console.WriteLine(i);
            }
        }
    }
} 