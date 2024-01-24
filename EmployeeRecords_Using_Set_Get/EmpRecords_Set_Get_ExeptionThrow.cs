/*Write a class student with some instance variables link roll_no,sub[5],total_marks,per with appropriate data types. student clas is inherited from class person which have instance variables like name, adhar, PAN. */
using System.Threading.Channels;

class Person
{
    public string Name { get; set; }
    public string Adhar { get; set; }
    public string PAN { get; set; }

    public Person()
    {
        Name = string.Empty;
        Adhar = string.Empty;
        PAN = string.Empty;
    }
    public void SetPersonData(string name, string adhar, string pan)
    {
        Name = name;
        Adhar = adhar;
        PAN = pan;
    }
}

class Student : Person
{
    public int Roll_No { get; set; }
    public int Total_Marks { get; set; }
    public float Percentage { get; set; }
    private float[]? SubMarks { get; set; }

    public Student()
    {
        Roll_No = 0;
        Total_Marks = 0;
        Percentage = 0;
        SubMarks = null;
    }
    public void SetStudentData(int roll)
    {
        Roll_No = roll;
    }
    public void SubjectMarks(float[] marks)
    {
        SubMarks = marks;
    }
    public void CalculateTotalMarks()
    {
        for (int i = 0; i < SubMarks.Length; i++)
        {
            Total_Marks = Total_Marks + (int)SubMarks[i];
        }
    }
    public void CalculatePercentage()
    {
        Percentage = (float)Total_Marks / SubMarks.Length;
        
    }
    public void Show()
    {
        Console.WriteLine("\nStudent Information:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Adhar: " + Adhar);
        Console.WriteLine("PAN: " + PAN);
        Console.WriteLine("Roll No: " + Roll_No);
        Console.WriteLine("Total Marks: " + Total_Marks);
        Console.WriteLine("Percentage: " + Percentage);
    }
}
class Staring
{
    public static void Main()
    {

        Person p = new Person();
        ;
        int no;
        Console.WriteLine("Enter Number Of Students");

        float[] StudentSubMarks = new float[5];

        try
        {
            no = int.Parse(Console.ReadLine());
            if(no<1)
            {
                throw new Exception("Number of students shuld be more then ZERO");
            }
            Student[] student = new Student[no];
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter Name, Adhar, PAN, Roll Nomber For Student: " + (i + 1));
                string? name = Console.ReadLine();
                string? adhar = Console.ReadLine();
                string? pan = Console.ReadLine();
                int roll = int.Parse(Console.ReadLine());

                for (int j = 0; j < StudentSubMarks.Length; j++)
                {
                    Console.Write("Enter Subject Marks For: " + (j + 1) + "=");
                    StudentSubMarks[j] = float.Parse(Console.ReadLine());
                }
                student[i] = new Student();
                student[i].SetPersonData(name, adhar, pan);
                student[i].SetStudentData(roll);
                student[i].SubjectMarks(StudentSubMarks);
                student[i].CalculateTotalMarks();
                student[i].CalculatePercentage();
                student[i].Show();
            }


            //for (int i = 0; i < student.Length; i++) // if we want to show all information in one place
            //{
            //    Console.WriteLine("\n");
            //    student[i].Show();
            //}
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
    }
}

