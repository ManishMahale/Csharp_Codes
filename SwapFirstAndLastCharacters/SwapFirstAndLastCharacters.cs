/* Swap Every first and last character of sentence Character*/
using System;

class SwapCharacters
{
    public string SwapFirstAndLastCharacters(string sentence)
    {
        string[] str = sentence.Split(' ');

        for (int i = 0; i < str.Length; i++)
        {
            string word = str[i];
            if (word.Length > 1)
            {
                char[] charArray = word.ToCharArray();
                char Temp = charArray[0];
                charArray[0] = charArray[charArray.Length - 1];
                charArray[word.Length - 1] = Temp;

                // Reassign the word with the swapped characters
                str[i] = new string(charArray);
            }

        }
        // Join the words back into a sentence
        return string.Join(" ", str);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        SwapCharacters obj = new SwapCharacters();
        string result = obj.SwapFirstAndLastCharacters(sentence);

        Console.WriteLine("\nResult:");
        Console.WriteLine(result);
    }
}