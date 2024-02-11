/*Write program to create interface name as CharOperator with method
void setCharArr(char []): this function is used for accept array as parameter
char [] getArrResult(): this is abstract function and return character array as result. You have 
to create two implementer class name as ConvertToUpper and ChangeAlterNateChar you 
have to implement the CharOperator interface in ConvertToUpper class and override both 
methods and convert lower case character to upper case and you have to implement the 
CharOperator in ChangeAlterNateChar and override both methods and convert even 
position character as Upper and odd position characters in lower.*/

interface ICharOperator
{
    public void SetArrChar(char[] Arr);
    public char[] GetArrResult();
}

class ConvertToUpper : ICharOperator
{
    private char[]? Arr;
    public void SetArrChar(char[] arr)
    {
        Arr = arr;

    }
    public char[] GetArrResult()
    {
        for (int i = 0; i < Arr.Length; i++)
        {
            if (Arr[i] >= 'a' && Arr[i] <= 'z')
            {
                Arr[i] = (char)(Arr[i] - 32);
            }
        }

        return Arr;
    }
}

class ChangeAlterNateChar : ICharOperator
{
    private char[]? Arr;
    public void SetArrChar(char[] arr)
    {
        Arr = arr;

    }
    public char[] GetArrResult()
    {
        bool flag = false;
        for (int i = 0; i < Arr.Length; i++)
        {

            if (flag == true)
            {
                if (Arr[i] >= 'a' && Arr[i] <= 'z')
                {
                    Arr[i] = (char)(Arr[i] - 32);
                }
                flag = false;
            }
            else
            {
                flag = true;
            }
        }

        return Arr;
    }
}

class First
{
    public static void Main()
    {
        Console.WriteLine("Enter Alphabet");
        string? st = Console.ReadLine();
        char[] arr1 = st.ToCharArray();
        char[] arr2 = st.ToCharArray();
        
        ConvertToUpper ctu = new ConvertToUpper();
        ctu.SetArrChar(arr1);
        Console.WriteLine("\nTo Upper:\n");
        char[] Result1 = ctu.GetArrResult();
        //for (int i = 0; i < Result1.Length; i++)
        //{
        //    Console.Write(Result1[i]);
        //}

        string str;
        string str2= string.Empty;
        for (int i = 0; i < Result1.Length; i++)
        {
            str = Result1[i].ToString();
            str2 = str2 + str;
        }
        Console.WriteLine(str2);


        Console.WriteLine("\n\nChange Alternate Char :\n ");
        ChangeAlterNateChar cac = new ChangeAlterNateChar();
        cac.SetArrChar(arr2);
        char[] Result2 = cac.GetArrResult();
        for (int i = 0; i < Result2.Length; i++)
        {
            Console.Write(Result2[i]);
        }
    }
}