//Students Records

class Student
{
    private int[]? marks;
    private double? percentage;
    private string? grade;
    public void SetSubMarks(int[] marks)
    {
        //here we need to store the array in instance variable
        this.marks = marks;
    }
    public void CalculatePer()
    {
        //here we need to call the aggregate of six subjects marks through the array and calculate its per and store in instance variable.

        int totalMarks = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            totalMarks += marks[i];
        }
        percentage = (double)totalMarks / marks.Length;
    }
    public void CheckGrades()
    {
        //here we need to check grades means per>75 && per<=100 then student in distinction if per>60 && er <= 75 then in first division if per >= 50 && per <= 60 then second division and if per > 40 && pe0 <= 50 then in third division a0d if per < 40 then student failed
        if (percentage > 75)
            grade = "Distinction";
        else if (percentage > 60)
            grade = "First Division";
        else if (percentage > 50)
            grade = "Second Division";
        else if (percentage > 40)
            grade = "Third Division";
        else
            grade = "Fail";
    }
    public void DisplayStudentInfo()
    {
        Console.WriteLine("Percentage: " + percentage);
        Console.WriteLine("Grede: " + grade);
    }
}
class Records
{
    public static void Main()
    {
        //create the object of class
        //declare the array with 6 six of type integer and store input values in array as subject marks
        //create the object of Student class and call the setSubMarks() function and pass array in it
        //then call calculatePer() student function
        //then call checkGrades() function for checking the grading of students.

        int no;
        Console.WriteLine("Enter Number Of Students:");
        no = int.Parse(Console.ReadLine());
        Student[] student = new Student[no];
        int[] StudentMarks = new int[6];
        for (int i = 0; i < student.Length; i++)
        {
            Console.WriteLine("Enter Marks For Student: " + (i + 1));
            // int[] StudentMarks = new int[6];
            for (int j = 0; j < StudentMarks.Length; j++)
            {
                Console.Write("Enter Subject MArks For: " + (j + 1) + "= ");
                StudentMarks[j] = int.Parse(Console.ReadLine());
                //Convert.ToInt32(Console.ReadLine());
            }
            student[i] = new Student();
            student[i].SetSubMarks(StudentMarks);
            student[i].CalculatePer();
            student[i].CheckGrades();
            student[i].DisplayStudentInfo();
        }
    }
}