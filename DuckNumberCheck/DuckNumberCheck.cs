/*Write program to create class name as CheckDuck with parameterized constructor 
 CheckDuck(int no): this constructor can accept number as parameter
 Boolean isDuckNumber(): this function check if number is duck return true otherwise return false.
*/

class CheckDuck
{
    private int no;
    public CheckDuck(int no)
    {
        this.no = no;
    }

    public Boolean IsDuckNumber()
    {
        int rem;
        while (no != 0)
        {
            rem = no % 10;
            if (rem == 0)
            {
                return true;
            }
            no = no / 10;
        }
        return false;
    }
}

class Duck
{
    public static void Main(String[] args)
    {
        int no;
        Console.WriteLine("Enter Number:\n");
        no = int.Parse(Console.ReadLine());

        CheckDuck cd = new CheckDuck(no);
        bool a = cd.IsDuckNumber();
        Console.WriteLine(a);
        Console.ReadLine();
    }
}
