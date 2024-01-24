using System;
/*
a
Ab
aBc
AbCd
aBcDe
*/
class Strong
{
    private int i, j, n1, n2;
    public void SetData()
    {

    }
    public void Find()
    {
        int ch;

        for (int i = 1; i <= 5; i++)
        {
            ch = 97;
            for (j = 1; j <= i; j++)
            {

                if ((i + j) % 2 == 0) //Small char
                {
                    Console.Write((char)ch);
                }
                else
                {
                    int a = ch - 32;
                    Console.Write((char)a);
                }
                ch++;
            }
            Console.WriteLine();
        }
    }

}
class M
{
    public static void Main(String[] arr)
    {


        Strong s = new Strong();
        //s.SetData(n1);
        Console.WriteLine();
        s.Find();

    }
}