/* write a class person with proper attributes. class person is having show_info() 
function which will display information of person. 
write a class teacher which inherit all properties of person class and class 
teacher is having additional attribute like salary. 
Write a class student which inherit all properties of person class and class 
student is having additional attribute like total_marks.
Create array of objects of student class and teacher class. Accept all 
information of student and teacher.
Display all student information and Teacher*/
class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void ShowInfo()
    {
        Console.Write("Name: " + Name +", Age:" + Age);
    }
}

class Teacher : Person
{
    public double Salary { get; set; }

    public Teacher(string name, int age, double salary) : base(name, age)
    {
        Salary = salary;
    }
    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine(", Salary" + Salary);
    }
}
class Student : Person
{
    public double TotalMarks { get; set; }
    public Student(string name, int age, double totalMarks) : base(name, age)
    {
        TotalMarks = totalMarks;
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine(", Total Marks : " + TotalMarks);
    }
}

class Student_Teacher_Records
{
    public static void Main()
    {
        try
        {
            Student[] student = new Student[2];
            Teacher[] teacher = new Teacher[2];
            int age, total_marks;
            string name;
            double salary;
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter student age, total mark, name");
                age = int.Parse(Console.ReadLine());
                total_marks = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                student[i] = new Student(name, age, total_marks);
                
                Console.WriteLine();
            }
            
            for (int i = 0; i < teacher.Length; i++)
            {
                Console.WriteLine("Enter Teacher age, salary, name");
                age = int.Parse(Console.ReadLine());
                salary = double.Parse(Console.ReadLine());
                name = Console.ReadLine();
                teacher[i] = new Teacher(name, age, salary);
                
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Teacher Information:");
            for (int i = 0; i < teacher.Length; i++)
            {
                teacher[i].ShowInfo();
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Student Information:");
            for (int i = 0; i < student.Length; i++)
            {
                student[i].ShowInfo();
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
