using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] myNumbers = { 5, 1, 8, 9, 3, 10, 13, 2, 9, 5, 1 };

        // Sort in descending order
        for (int i = 0; i < myNumbers.Length; i++)
        {
            for (int j = i + 1; j < myNumbers.Length; j++)
            {
                if (myNumbers[i] < myNumbers[j])
                {
                    int temp = myNumbers[i];
                    myNumbers[i] = myNumbers[j];
                    myNumbers[j] = temp;
                }
            }
        }

        Console.WriteLine("Unique values (Descending):");

        for (int i = 0; i < myNumbers.Length; i++)
        {
            bool isDuplicate = false;

            // Check if the value already appeared before
            for (int j = 0; j < i; j++)
            {
                if (myNumbers[i] == myNumbers[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                Console.WriteLine(myNumbers[i]);
            }
        }
    }
}
