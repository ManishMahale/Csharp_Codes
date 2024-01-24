/*      class StingConvert , function in it = GetString,  CovertToUpper, CoverToLower, Covert_UpperToLower_LowerToUpper      */

class StringConvert
{
    char[] name;

    public void GetString(char []name)
    {
        this.name = name;
    }
    public void ConvertToUpper()
    {
        for(int i = 0; i < name.Length; i++)
        {
            if (name[i] >= 97 && name[i] <= 126 )
            {
                //name[i] = (Char)(name[i] - 32);
                Console.Write((Char)(name[i] - 32));
            }
            else
            {
                Console.Write(name[i]);
            }
        }
        
    }

    public void ConvertToLower()
    {
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] >= 'A' && name[i] <= 'Z')
            {
                Console.Write((Char)(name[i] + 32));
            }
            else
            {
                Console.Write(name[i]);
            }
        }
        
    }
        public void ConverUpperLowerLoertUpper()
    {
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] >= 'a' && name[i] <= 'z')
            {
                Console.Write((Char)(name[i] - 32));
            }
            else
            {
                Console.Write((Char)(name[i] + 32));
            }
        }
        
    }
}
class Convert
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        char[] inputString = name.ToCharArray();//conver String To Character

        StringConvert stringConvert = new StringConvert();
        stringConvert.GetString(inputString);
        Console.WriteLine();
        stringConvert.ConvertToUpper();
        Console.WriteLine();
        stringConvert.ConvertToLower();
        Console.WriteLine();
        stringConvert.ConverUpperLowerLoertUpper();
    }
}