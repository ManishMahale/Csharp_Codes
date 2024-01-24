using System;
using System.Collections;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;


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
        return this.empid.CompareTo(temp.empid); //in one line
        //if (this.empid > temp.empid) //with logic
        //{
        //    return 1;
        //}
        //else if (this.empid < temp.empid)
        //{
        //    return -1;
        //}
        //else
        //{
        //    return 0;
        //}

        //return string.Compare(this.name, temp.name);
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

internal class IComparable_Collectoins
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
        Console.WriteLine("before sorting:");
        foreach (var item in empList)
        {
            employee e = (employee)item;
            e.show();
        }

        Console.WriteLine("After sorting:");
        empList.Sort();
        foreach (var item in empList)
        {
            employee e = (employee)item;
            e.show();
        }
    }
}