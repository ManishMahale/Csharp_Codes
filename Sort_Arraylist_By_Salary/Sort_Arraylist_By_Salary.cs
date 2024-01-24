/*  Write a program to create class employee, store five employee records (Objects) in ArrayList and display it as well as sort ArrayList by Salary.  */
using System.Collections;

class Employee : IComparable
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public int EmpSalary { get; set; }
    public Employee()
    {
        EmpId = 0;
        EmpName = string.Empty;
        EmpSalary = 0;
    }
    public Employee(int empId, string empName, int empSalary)
    {
        EmpId = empId;
        EmpName = empName;
        EmpSalary = empSalary;
    }

    public void Show()
    {
        Console.WriteLine("EmpId = " + EmpId + "\tEmpName = " + EmpName + "\tEmpSalary = " + EmpSalary);
    }
    public int CompareTo(object? obj)
    {
        Employee temp = (Employee)obj;
       // return this.EmpSalary.CompareTo(temp.EmpSalary); // sort in one line
        if (this.EmpSalary > temp.EmpSalary) // sort with logic
        {
            return 1;
        }
        else if(this.EmpSalary< temp.EmpSalary)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}

class First
{
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee(1, "Rajesh", 10000);
        Employee emp2 = new Employee(3, "Mahesh", 18000);
        Employee emp3 = new Employee(4, "Sandip", 19000);
        Employee emp4 = new Employee(2, "Manish", 12000);
        Employee emp5 = new Employee(5, "Ramesh", 1000);
        ArrayList arrlist = new ArrayList();
        arrlist.Add(emp1);
        arrlist.Add(emp2);
        arrlist.Add(emp3);
        arrlist.Add(emp4);
        arrlist.Add(emp5);
        Console.WriteLine("\nBefore Sorting");
        foreach (var item in arrlist)
        {
            Employee emp = (Employee)item;
            emp.Show();
        }

        arrlist.Sort(); //call to 'CompareTo' Method
        Console.WriteLine("\nAfter Sorting by salary");
        foreach (var item in arrlist)
        {
            Employee emp = (Employee)item;
            emp.Show();
        }
    }
}