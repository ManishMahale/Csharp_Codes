using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class ReverseEveryWordOfSentence
    {
        public class ReverseWords
        {
            public string ReverseEachWord(string sentence)
            {
                // Split the sentence into words
                string[] words = sentence.Split(' ');

                // Reverse each word and store in a new array
                for (int i = 0; i < words.Length; i++)
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }

                // Join the reversed words back into a sentence
                //Console.WriteLine("Reversed Words: {0}", string.Join(" ", words));
                return string.Join(" ", words);
            }

            public string ReverseWordWithoutInbuildFunction(string str)
            {
                string output = "";
                string tempString = "";

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    //Console.Write(str[i]);

                    if (str[i] == ' ')
                    {
                        output = tempString + " " + output;
                        tempString = "";
                    }
                    else
                    {
                        //tempString += str[i];
                        tempString = tempString + str[i];
                    }
                }

                output = tempString + " " + output;
                //Console.WriteLine();
                //Console.Write(output);
                return output.Trim(); // Trim to remove any leading or trailing spaces
            }
        }
    }
}
