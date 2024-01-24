/*   WAP to accept two strings from user and check whether two Strings are anagram of 
each other or not
Anagram strings: - An anagram of a string is another string that contains the same characters, 
only the order of characters can be different. For example, “abcd” and “dabc” are an anagram of 
each other.   */

using System;
class Anagram
{

    public static void Main()
    {
        try
        {
            string str1, str2;
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();

            string cmp = string.Empty;
            string cmp2 = string.Empty;
            Console.WriteLine();

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("String is Not Anagram");
            }
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (ch1[i] == ch2[j])
                    {
                        cmp = ch2[i].ToString();
                        cmp2 = cmp2 + cmp;
                    }
                }
            }
            int n = cmp2.CompareTo(str1);
            if (n == 0)
            {
                Console.WriteLine("String is Anagram");
            }
            else
            {
                Console.WriteLine("String is not Anagram");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}