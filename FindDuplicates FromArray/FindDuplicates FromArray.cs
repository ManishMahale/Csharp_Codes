using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] myNumbers = { 5, 1, 8, 9, 3, 10, 13, 2, 9, 5, 1 };

        Console.WriteLine("\nDuplicates:");
        for (int i = 0; i < myNumbers.Length; i++)
        {
            bool alreadyPrinted = false;

            // Check if we've already printed this number before
            for (int k = 0; k < i; k++)
            {
                if (myNumbers[k] == myNumbers[i])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            // Count occurrences if not printed yet
            if (!alreadyPrinted)
            {
                int count = 0;
                for (int j = 0; j < myNumbers.Length; j++)
                {
                    if (myNumbers[i] == myNumbers[j])
                    {
                        count++;
                    }
                }

                if (count > 1)
                {
                    Console.WriteLine(myNumbers[i]);
                }
            }
        }
    }
}

/* output:
 
Duplicates:
5
1
9

*/