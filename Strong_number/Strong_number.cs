internal class Strong_number
{
    class Strong
    {
        private int n, fact, sum;

        public void SetData(int n)
        {
            this.n = n;
        }
        public void FindStrong()
        {
            for (int f = 1; f <=n; f++)
            {
                sum = 0;
                int Temp = f;
                while (Temp != 0)
                {
                    fact = 1;
                    int rem = Temp % 10;
                    for (int i = 1; i <= rem; i++)
                    {
                        fact = fact * i;
                    }
                    sum = sum + fact;
                    Temp = Temp / 10;
                }

                if (sum == f)
                {
                    Console.WriteLine(f);
                }
                
            }
        }
    }
    private static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter Number");
        n = Convert.ToInt32(Console.ReadLine());
        Strong s = new Strong();
        s.SetData(n);
        Console.WriteLine();
        s.FindStrong();
    }
}

/*
 //Varahi technologies Technical ROund -2 

using System;
namespace AB
{
    class Strong
    {
        private int Num, fact, sum, temp, rem;
        public Strong()
        {
            temp = 0;
            Num = 0;
            fact = 0;
            sum = 0;
        }
        public void SetData(int Num)
        {
            this.Num = Num;
        }
        public void SumOfFact()
        {

            for (int i = 3; i <= Num; i++)
            {
                temp = i;
                sum = 0;
                while (temp != 0)
                {
                    fact = 1;
                    rem = temp % 10;
                    for (int j = 1; j <= rem; j++)
                    {
                        fact = fact * j;
                    }
                    sum = sum + fact;
                    temp = temp / 10;
                }
                if(sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class First
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Range:");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Strong s = new Strong();
                s.SetData(num);
                Console.WriteLine();
                s.SumOfFact();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

/*
    input: 
    500000

    output:
    145
    40585
*/
/*
    input: 
    500000

    output:
    145
    40585
*/
