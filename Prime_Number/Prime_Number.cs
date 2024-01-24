//class findPrime
//{
//    public static void Main(string[] args)
//    {
//        int no, count, i, j, m = 0;
//        Console.WriteLine("Enter Range: ");
//        no = int.Parse(Console.ReadLine());

//        for (i = 1; i <= no; i++)
//        {
//            count = 0;
//            for (j = 1; j <= i; j++)
//            {
//                if (i % j == 0)
//                {
//                    count++;
//                }
//            }
//            if (count == 2)
//            {
//                Console.WriteLine(i);
//                m++;
//            }
//        }
//        Console.WriteLine("Count Of Prime  Numbers: " + m);

//    }
//}



class findPrime
{
    public static void Main(string[] args)
    {
        int count, i, j;

        for (i = 50; i >= 1; i--)
        {
            count = 0;
            for (j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}