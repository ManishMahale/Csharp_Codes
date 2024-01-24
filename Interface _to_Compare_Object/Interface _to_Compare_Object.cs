using System;
using System.Collections;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;

class student : IEquatable<student>
{
    public int roll { get; set; }
    public string name { get; set; }

    public bool Equals(student? other)
    {
        return (this.roll == other.roll && this.name == other.name);
    }

    public student()
    {

    }
    public student(int r, string nm)
    {
        roll = r;
        name = nm;
    }
    public void show()
    {
        Console.WriteLine("Roll=" + roll + " Name=" + name);
    }

    public int CompareTo(object? obj)
    {
        student ss = (student)obj;
        if (this.roll > ss.roll)
        {
            return 1;
        }
        else if (this.roll < ss.roll)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
//-------------------------------------------------------------------

class sortByName : IComparer
{
    public int Compare(object ob1, object ob2)
    {
        student s1 = (student)ob1;
        student s2 = (student)ob2;

        return String.Compare(s1.name, s2.name);
    }
}
class SortByroll : student, IComparer
{
    public int Compare(object? x, object? y)
    {
        student temp1 = (student)x;
        student temp = (student)y;
        if (temp1.roll > temp.roll)
        {
            return 1;
        }
        else if (temp1.roll < temp.roll)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
//-----------------------------------------------------------

class employee : IComparable
{
    public int empid { get; set; }
    public string name { get; set; }

    public employee()
    {

    }
    public employee(int eid, string nm)
    {
        empid = eid;
        name = nm;
    }
    public void show()
    {
        Console.WriteLine("emp id = " + empid + " name =" + name);
    }

    public int CompareTo(object? obj)
    {
        employee temp = (employee)obj;
        //if(this.empid>temp.empid)
        // {
        //     return 1;
        // }
        //else if(this.empid < temp.empid)
        // {
        //    return -1;
        // }
        //else
        // {
        //     return 0;
        // }

        return string.Compare(this.name, temp.name);
        /*if (string.Compare(this.name,temp.name)>0)
        {
            return 1;
        }
        else if(string.Compare(this.name, temp.name) < 0)
        {
            return -1;
        }
        else
        {
            return 0;
        }
        */

    }
}
//---------------------------------------------------------
class compareByEmpId : IComparer
{

    public int Compare(object? x, object? y)
    {
        employee e1 = (employee)x;
        employee e2 = (employee)y;
        if (e1.empid > e2.empid)
        {
            return 1;
        }
        else if (e1.empid < e2.empid)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
class compareEmpByName : IComparer
{
    public int Compare(Object x, Object y)
    {
        employee ee1 = (employee)x;
        employee ee2 = (employee)y;
        return string.Compare(ee1.name, ee2.name);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        employee e1 = new employee(1, "rajesh");
        employee e2 = new employee(3, "anand");
        employee e3 = new employee(2, "pankaj");

        ArrayList empList = new ArrayList();
        empList.Add(e1);
        empList.Add(e2);
        empList.Add(e3);

        foreach (var item in empList)
        {
            employee e = (employee)item;
            e.show();
        }
        Console.WriteLine("After sorting");
        Console.WriteLine("\nIComparable by Name");
        empList.Sort();
        foreach (var item in empList)
        {
            employee e = (employee)item;
            e.show();
        }
        Console.WriteLine("-----------");

        //empList.Sort();
        compareByEmpId cbe = new compareByEmpId();
        //empList.Sort(cbe);

        empList.Sort(new compareByEmpId());
        Console.WriteLine("\nIComparer by EmpId");
        foreach (var item in empList)
        {
            employee e = (employee)item;
            e.show();
        }

        Console.WriteLine("------------------");

        empList.Sort(new compareEmpByName());
        Console.WriteLine("\nIComparer by Name");
        foreach (var item in empList)
        {
            employee e = (employee)item;
            e.show();
        }
    }
}