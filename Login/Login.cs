internal class Login
{
    private static void Main(string[] args)
    {
        string username = "asd";
        string pwd = "123";
        if (username.Equals("asd") && pwd.Equals("123"))
        {
            Console.WriteLine("Login Success full");
        }
        else
        {
            Console.WriteLine("Login Denaid");
        }

    }
}