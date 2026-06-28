public static class ProgramsSolutions
{
    public static void FindOccurrenceByDictionary(int[] arr)
    {
        Dictionary<int, int> occurrenceMap = new Dictionary<int, int>();

        foreach (int item in arr)
        {
            if (occurrenceMap.ContainsKey(item))
            {
                occurrenceMap[item]++;
            }
            else
            {
                occurrenceMap[item] = 1;
            }
        }
        Console.WriteLine($"FindOccurrenceByDictionary:");

        foreach (var item in occurrenceMap)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }

    public static void FindOccurrenceWithoutInbuilt(int[] arr)
    {
        int size = arr.Length;

        // Array to mark counted elements
        bool[] visited = new bool[size];

        Console.WriteLine($"\nFindOccurrenceWithoutInbuilt:");

        for (int i = 0; i < size; i++)
        {
            // Skip if this element is already counted
            if (visited[i])
                continue;

            int count = 1;

            // Compare with remaining elements
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j] = true; // Mark as counted
                }
            }

            Console.WriteLine(arr[i] + " : " + count);
        }
    }

    public static void FindOccurrenceByLinq(int[] arr)
    {

        var result = arr.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() });
        Console.WriteLine($"\nFindOccurrenceByLinq:");
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Value} : {item.Count}");
        }
    }
    public static void RemoveDuplicatesWithoutInbuilt()
    {
        int[] arr = { 1, 2, 3, 2, 1, 4, 44, 44 };
        int n = arr.Length;

        // Temporary array to store unique elements
        int[] temp = new int[n];
        int uniqueCount = 0;

        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < uniqueCount; j++)
            {
                if (arr[i] == temp[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                temp[uniqueCount] = arr[i];
                uniqueCount++;
            }
        }

        Console.WriteLine($"\nRemoveDuplicatesWithoutInbuilt:");
        // Print unique elements
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.Write(temp[i] + " ");
        }

    }

    public static void FindDuplicatesWithoutInbuilt()
    {
        int[] arr = { 1, 2, 3, 2, 1, 4 };

        for (int i = 0; i < arr.Length; i++)
        {
            bool alreadyPrinted = false;

            // Check if already printed
            for (int k = 0; k < i; k++)
            {
                if (arr[i] == arr[k])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            if (alreadyPrinted)
                continue;

            // Check duplicates
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }
        }
    }

    public static void ReverseString()
    {
        //string str = "dotnet";

        //char[] chars = new char[str.Length];
        //int index = 0;

        //for (int i = str.Length - 1; i >= 0; i--)
        //{
        //    chars[index] = str[i];
        //    index++;
        //}

        //string reversed = "";
        //for (int i = 0; i < chars.Length; i++)
        //{
        //    reversed += chars[i];
        //}

        //Console.WriteLine(reversed);

        string str = "dotnet";
        string reversed = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed = reversed + str[i];
        }

        Console.WriteLine(reversed);
    }

    public static void GroupAnagramsUsingDictionary() // HealthLevel Interview Question
    {
        string[] words = { "cat", "atc", "eat", "ate", "abc" };

        Dictionary<string, int> anagramGroups = new Dictionary<string, int>();

        foreach (string word in words)
        {
            // Convert the word to a character array
            char[] chars = word.ToCharArray();

            // Sort the characters
            Array.Sort(chars);

            // Create the dictionary key
            string key = new string(chars);

            // Update dictionary count
            if (anagramGroups.ContainsKey(key))
            {
                anagramGroups[key]++;
            }
            else
            {
                anagramGroups.Add(key, 1);
            }
        }

        // Print the result
        foreach (KeyValuePair<string, int> item in anagramGroups)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}




public class MainClass
{
    public static void Main(string[] args)
    {
        //int[] arr = { 2, 1, 1, 2, 3, 3, 3, 3, 3 };
        //ProgramsSolutions.FindOccurrenceByDictionary(arr);
        //ProgramsSolutions.FindOccurrenceWithoutInbuilt(arr);
        //ProgramsSolutions.FindOccurrenceByLinq(arr);
        //ProgramsSolutions.RemoveDuplicatesWithoutInbuilt();
        //ProgramsSolutions.FindDuplicatesWithoutInbuilt();
        //ProgramsSolutions.ReverseString();
        ProgramsSolutions.GroupAnagramsUsingDictionary();
    }
}