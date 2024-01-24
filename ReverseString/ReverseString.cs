using System.ComponentModel;
class STR
{
    private char[]? ch;
    public char[] rev(string ch1)
    {
        ch = ch1.ToCharArray();

        int end = ch1.Length - 1;
        //var len = ch.Length;
        //var mid = len / 2;
        //int end = len - 1;


        for (int i = 0; i < end; i++)
        {
            char temp = ch[i];
            ch[i] = ch[end];
            ch[end--] = temp;

            //Console.Write("*"); //number of itteretion performed
        }

        return ch;
    }
}
class RevStr
{
    public static void Main(String[] args)
    {
        STR obj = new STR();

        string? s = Console.ReadLine();
        char[]? str = obj.rev(s);
        Console.WriteLine(str);


        //string s1 = "ABCDe";
        //char[] ch = s1.ToCharArray();
        //int end = ch.Length - 1;

        //for(int i = 0; i < end; i++)
        //{
        //    char temp= ch[i];
        //    ch[i] = ch[end];
        //    ch[end--] = temp;   
        //}
        //Console.WriteLine(ch);
    }
}