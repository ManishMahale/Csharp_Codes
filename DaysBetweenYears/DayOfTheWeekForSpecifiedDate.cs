//Write a C# program to get the day of the week for a specified date

class Day
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Year-Month-Date:");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime inputDate))
        {
            DayOfWeek dayOfWeek = inputDate.DayOfWeek;
            Console.WriteLine($"{inputDate} + {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter a valid date in yyyy-mm-dd format.");
        }

    }
}
//wrong output