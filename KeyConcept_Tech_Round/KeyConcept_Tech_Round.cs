//class KeyConcept_Tech_Round
//{
//    static int Sum(int n)
//    {
//        if (n != 0)
//        {
//            return n + Sum(n - 1);
//        }
//        else
//        {
//            return n;
//        }
//    }

//    static void Main()
//    {
//        int number = 4;
//        int result = Sum(number);

//        Console.WriteLine("Sum = {0}", result);
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

//namespace LogicalPrograms
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Enter a String: ");
//            string inputString = "AAABCCSSDDD"; //= Console.ReadLine();
//            string resultString = string.Empty;

//            var unique = new HashSet<char>(inputString);

//            foreach (char c in unique)
//            {
//                resultString += c;
//            }


//            HashSet<char> ihs= new HashSet<char>();
//            ihs.Add('A');
//            ihs.Add('B');
//            ihs.Add('A');
//            foreach (var item in ihs)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine("After Removing Duplicates: " + resultString);
//            Console.ReadKey();

//        }
//    }
//}


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









//--------------------------------------
// Remove duplicate elements from array
//namespace LogicalPrograms
//{
//    class Program
//    {
//        static void Main()
//        {
//            int[] arr = { 1, 1, 2, 3, 4 };
//            string resultString = string.Empty;
//            var unique = new HashSet<int>(arr);
//            Console.WriteLine("After Removing Duplicates: " + resultString);
//            foreach (int c in unique)
//            {
//                Console.WriteLine(c + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}






//---------------------------------------


class KeyConcept
{
    static int Sum(int n)//4//3//2//1//0
    {
        if (n != 0)//t//t//1
        {
            return n + Sum(n - 1);  //4+3+2+1+0===10   10
        }
        else
        {
            return n;
        }
    }

    static void Main()
    {
        int number = 4;
        int result = Sum(number);//10

        Console.WriteLine("Sum = {0}", result);//10
    }
}