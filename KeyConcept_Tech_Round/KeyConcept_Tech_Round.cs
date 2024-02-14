//class KeyConcept_Tech_Round
//{
//    static int sum(int n)
//    {
//        if (n != 0)
//        {
//            return n + sum(n - 1);
//        }
//        else
//        {
//            return n;
//        }
//    }

//    static void Main()
//    {
//        int number = 4;
//        int result = sum(number);

//        Console.WriteLine("sum = {0}", result);
//    }
//}
//output = 10

//----------------------------------

//Q. How to remove duplicate characters from a string?
//AAABCCSSDDD


//Linq Used in this 

//using System;
//using System.Linq;

//namespace LogicalPrograms
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter a String: ");
//            string inputString = "AAABCCSSDDD";//= Console.ReadLine();

//            var uniqueCharArray = inputString.ToCharArray().Distinct().ToArray();
//            string resultString = new string(uniqueCharArray);

//            Console.WriteLine("After Removing Duplicates: " + resultString);
//            Console.ReadKey();
//        }
//    }
//}
//output: ABCSD

//-----------------------------
//HashSet used

//using System;
//using System.Collections.Generic;

namespace LogicalPrograms
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a String: ");
            string inputString = "AAABCCSSDDD"; //= Console.ReadLine();
            string resultString = string.Empty;

            var unique = new HashSet<char>(inputString);

            foreach (char c in unique)
            {
                resultString += c;
            }

            Console.WriteLine("After Removing Duplicates: " + resultString);
            Console.ReadKey();

        }
    }
}


//---------------------------------
//Simple Implementation:

//namespace LogicalPrograms
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter a String: ");
//            string inputString = "AAABCCSSDDD";//= Console.ReadLine();
//            string resultString = string.Empty;

//            for (int i = 0; i < inputString.Length; i++)
//            {
//                if (!resultString.Contains(inputString[i]))
//                {
//                    resultString += inputString[i];
//                }
//            }

//            Console.WriteLine("After Removing Duplicates: " + resultString);
//            Console.ReadKey();
//        }
//    }
//}

