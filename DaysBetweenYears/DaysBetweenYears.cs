using System.Security.Cryptography.X509Certificates;

namespace DaysBetweenYEars
{

    internal class Days
    {


        static void Main()
        {
            Console.WriteLine("Enter Starting Year:");
            int startYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ending Year:");
            int endYear = int.Parse(Console.ReadLine());
            int totalDays = 0;
            for (int year = startYear; year <= endYear; year++)
            {
                if (LeapYear(year))
                {
                    totalDays = totalDays + 366;
                }
                else
                {
                    totalDays = totalDays + 365;
                }
            }
            Console.WriteLine("Totatl Days Between " + startYear + "-" + endYear + "=" + totalDays);
        }

        static bool LeapYear(int Year)
        {
            if (Year % 4 != 0)
                return false;

            if (Year % 100 != 0)
                return true;

            if (Year % 400 != 0)
                return false;
            return true;
        }
        
    }
}