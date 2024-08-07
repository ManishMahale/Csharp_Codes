using System;

/*tryQuestion 1

Revisat Later

How to Attempt?

Chocolate Jar

You are given an integer array of size M, representing jars of chocolates. Three students A B and C respectively, will pick chocolates one by one from each chocolate jar, till the jar is empty, and then repeat the same with the rest of the jars. Your task is to find and return an integer value representing the total number of chocolates that student A will have, after all the chocolates have been picked from all the jars.

Input Specification:

input1: An integer array, representing the quantity of chocolates in each jar.

input2: An integer value N, representing the number of jars.

Output Specification:

Return an integer value representing the total number of chocolates that student A will have, after all the chocolates are picked.

Example 1:

input1: (3,2,6)

input2:3

Output: 4
Explanation:

Here, we are given three jars of chocolates with quantities (3,2,6). In the cycle, each student A, B, and C respectively, will pick chocolates from each jar in the following manner:

1. From the first jar with 3 chocolates, A will pick 1 chocolate, B will pick 1 chocolate, and C will pick 1 chocolate. So, A has 1 more chocolate.

2. From the second jar with 2 chocolates, A will pick 1 chocolate and B will pick 1 chocolate. So, A has 1 more chocolate.

3. From the third jar with 6 chocolates, A will pick 1 chocolate, B will pick 1 chocolate, and C will pick 1 chocolate. Then again A will pick 1 chocolate followed by B and C. So, A has 2 more chocolates.

Hence, the total number of chocolates with A is 4 (1+1+2), therefore, 4 is returned as the output.

Example 2:

input1: (1,2,3,4)

input2: 4

Output: 5

Explanation:

Here, we are given four jars of chocolates with quantities (1,2,3,4). In the cycle, each student A, B, and C respectively will pick chocolates from each jar in the following manner:

1. From the first jar with 1 chocolate, A will pick 1 chocolate. So, A has 1 more*/
public class UserMainCode
{
    public int chocolatesOfA(int[] input1, int input2)
    {
        int totalChocolatesForA = 0;
        int totalChocolatesForC = 0;
        int totalChocolatesForB = 0;

        for (int i = 0; i < input2; i++)
        {
            for (int j = 0; j < input1[i]; j++)
            {
                // Student A picks chocolates on turns 0, 3, 6, 9, etc.
                if ((j % 3) == 0)
                {
                    totalChocolatesForA++;
                }
                // Student B picks chocolates on turns 1, 4, 7, 10, etc.
                if ((j % 3) == 1)
                {
                    totalChocolatesForB++;
                }
                // Student C picks chocolates on turns 2, 5, 8, 11, etc.
                if ((j % 3) == 2)
                {
                    totalChocolatesForC++;
                }
                /*Context
                    Students A, B, and C pick chocolates from the jars in a cyclic order: A, B, C, A, B, C, and so on.
                    This means student A picks chocolates on every 3rd turn starting from the 0th turn, student B on 
                    every 3rd turn starting from the 1st turn, and student C on every 3rd turn starting from the 2nd turn.*/
            }
        }

        return totalChocolatesForA;
    }

    static void Main(string[] args)
    {
        int[] input1 = { 3, 2, 6 }; // Example input1
        int input2 = 3; // Example input2

        UserMainCode obj = new UserMainCode();
        int result = obj.chocolatesOfA(input1, input2);
        Console.WriteLine(result); // Output: 4
    }
}