//Employee Records
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Employee
{
    private int id, basicSal, progress, increment, incSal;
    private string? name;
    public void SetPersonalInfo(String name, int id, int basicSal)
    {
        this.name = name;
        this.id = id;
        this.basicSal = basicSal;
        //in this function we need to store name ,id and basicSal in instance variable
    }
    public void SetProgressPer(int progress)
    {
        //if progress value is greater than 60 per then increase the basic salary of employee with 30 percentage
        this.progress = progress;

        if (progress > 60)
        {
            increment =(int) (basicSal * 0.3);
            incSal = increment + basicSal;
        }
        else
        {
            incSal = basicSal;
        }
    }
    public void Show()
    {
        //in this function we need to show the all details of employee like as
        //name id and basic salary as well as incremental salary and total salary of employee

        Console.WriteLine(name + "\t" + id + "\t" + basicSal + "\t" + progress + "\t" + incSal);

    }
}
class Person
{
    public static void Main(string[] args)
    {
        // here create the object of class and accept the name id and basic salary as well 
        //progress per  value not need to calculate it by using formual directly enter e.g 70 //means 70%
        //create the object of Employee class and call setPersonalInfo and pass name id and salary in it as well as setProgressPer() and pass progress value in it
        //call the show() method of Employee class.

        int id, basicSal, progress;
        string name;

        Employee[] employee = new Employee[3];

        for (int i = 0; i < employee.Length; i++)
        {
            Console.WriteLine("Enter name, id, basic salary, progress:");

            name = Console.ReadLine();
            id = int.Parse(Console.ReadLine());
            basicSal = int.Parse(Console.ReadLine());
            progress = int.Parse(Console.ReadLine());

            employee[i] = new Employee();
            employee[i].SetPersonalInfo(name, id, basicSal);
            employee[i].SetProgressPer(progress);
        }

        for (int i = 0; i < employee.Length; i++)
        {
            employee[i].Show();
        }
    }
}

/*OUTPUT:

    Enter name, id, basic salary, progress:
    a
    1
    100
    59
    Enter name, id, basic salary, progress:
    b
    2
    100
    60
    Enter name, id, basic salary, progress:
    c
    3
    100
    61
    a       1       100     59      100
    b       2       100     60      100
    c       3       100     61      130
 
 */