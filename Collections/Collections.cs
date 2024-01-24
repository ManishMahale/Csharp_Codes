//using System;
//using System.Collections;
//using System.Net.NetworkInformation;
//using System.Reflection;
//using System.Text;

//class student
//{
//    public int roll { get; set; }
//    public string name { get; set; }
//    public student()
//    {

//    }
//    public student(int r, string nm)
//    {
//        roll = r;
//        name = nm;
//    }
//    public void show()
//    {
//        Console.WriteLine(roll+"\t"+name);
//    }
//}

//internal class Program
//{
//    private static void Main(string[] args)
//    {

//        //hashtable
//        //Hashtable pincode = new Hashtable();

//        //pincode[13] = "solapur";
//        //pincode[14] = "nagar";
//        //Console.WriteLine(pincode[13]);
//        //Console.WriteLine(pincode.Count);
//        //Console.WriteLine("-------------------");
//        //foreach (var item2 in pincode.Keys)
//        //{
//        //    Console.WriteLine("values:" + pincode[item2]);
//        //}

//        //ArrayList cities1 = new ArrayList();
//        //string[] c1 = { "pune", "nagar", "nashik" };
//        //cities1.AddRange(c1);
//        //Console.WriteLine("c1 count" + c1.Count());
//        //Hashtable india = new Hashtable();
//        //india.Add("maha", cities1);

//        //var item = india["maha"];
//        //Console.WriteLine("###" + ((ArrayList)item).Count);
//        //ArrayList temp = (ArrayList)item;

//        //foreach (var it1 in temp)
//        //{
//        //    string s = (String)it1;
//        //    Console.WriteLine(s);
//        //}
//        //hashtable with Arraylist as value
//        Hashtable ht = new Hashtable();
//        ht.Add("maha", 4);
//        ht.Add("ka", 3);
//        Console.WriteLine(ht.Count);
//        student s1 = new student(1, "rajesh");
//        student s2 = new student(2, "mahesh");
//        student s3 = new student(3, "aaa");
//        student s4 = new student(4, "bbb");
//        student s5 = new student(5, "ccc");
//        student s6 = new student(6, "dddd");

//        ArrayList as1 = new ArrayList();
//        as1.Add(s1);
//        as1.Add(s2);
//        ht.Add("al1", as1);
//        ArrayList as2 = new ArrayList();
//        as2.Add(s3);
//        as2.Add(s4);
//        as2.Add(s5);
//        ht.Add("al2", as2);
//        ArrayList as3 = new ArrayList();
//        as3.Add(s6);
//        ht.Add("al3", as3);


//        foreach (var item1 in ht.Values)
//        {
//            ArrayList temp8 = (ArrayList)item1;
//            Console.WriteLine("===New Arraylist students===");
//            foreach (var ss in temp8)
//            {
//                student tt = (student)ss;
//                tt.show();
//            }
//            //Console.WriteLine(item);
//        }
//        //#region
//        //Hashtable h1 = new Hashtable();
//        //h1.Add(1, "one");
//        //h1.Add(2, "two");
//        //h1.Add(3, "three");
//        //h1.Remove(2);
//        //Console.WriteLine(h1.ContainsKey(2));




//        //Hashtable PostOffice = new Hashtable();
//        //PostOffice.Add(413001, "solapur");
//        //PostOffice.Add(4120058, "pune");
//        //PostOffice.Add(4000001, "mumbai");

//        //Console.WriteLine("count =" + PostOffice.Count);
//        //Console.WriteLine("contain 412001  =" + PostOffice.Contains(4120058));

//        //student s7 = new student(1, "rajesh");
//        //student s8 = new student(3, "pavan");
//        //student s9 = new student(2, "anand");
//        //ArrayList arl = new ArrayList();
//        //arl.Add(s7);
//        //arl.Add(s8);
//        //arl.Add(s9);


//        //student s10 = new student(1, "rajesh");
//        //student s11 = new student(2, "pavan");
//        //student s12 = new student(3, "anand");
//        //student s13 = new student(4, "mahesh");

//        //Hashtable ht1 = new Hashtable();
//        ////ht.Add(1, "one");
//        ////ht.Add(2, "two");
//        //ht.Add(3, "three");
//        //ht.Add(4, "four");
//        //ht.Add(5, "five");

//        //foreach (DictionaryEntry item3 in ht)
//        //{
//        //    Console.WriteLine("key= " + item3.Key + " value=" + item3.Value);
//        //}

//        //ht["ss1"] = s1;
//        //ht["ss2"] = s2;
//        //ht["ss3"] = s3;
//        //ht["ss4"] = s4;
//        //ht.Add("ss5", new student(55, "zzz"));
//        //foreach (DictionaryEntry item4 in ht)
//        //{
//        //    Console.Write("key= " + item4.Key);
//        //    student temp5 = (student)item4.Value;
//        //    temp5.show();
//        //}
//        //Console.WriteLine("count=" + ht.Count);
//        //Console.WriteLine("fixed size =" + ht.IsFixedSize);
//        #endregion
//    }
//}

//---------------------------------------------


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
internal class Programk
{
    private static void Main(string[] args)
    {
        // ArrayList ar = new ArrayList();
        #region 

        //  Console.WriteLine("capacity="+ar.Capacity+" count="+ar.Count);
        //  ar.Add(11);
        //  Console.WriteLine("capacity=" + ar.Capacity + " count=" + ar.Count);
        //  ar.Add("pravin");
        //  ar.Add(22);
        //  ar.Add(33);
        //  ar.Add(44);
        //  Console.WriteLine("capacity=" + ar.Capacity + " count=" + ar.Count);
        //  ar.Add(55);
        //  ar.Add(66);
        //  ar.Add(77);
        //  ar.Add(88);
        //  Console.WriteLine("capacity=" + ar.Capacity + " count=" + ar.Count);
        ////  ar.Remove(123);
        // // ar.Remove(111);
        //  GC.Collect();
        //  Console.WriteLine("capacity=" + ar.Capacity + " count=" + ar.Count);
        //  ar.Reverse();
        //  foreach (var item in ar)
        //  {
        //      Console.WriteLine( item );
        //  }
        //  Console.WriteLine(  "contain pravin ?"+ar.Contains("pravin"));
        #endregion

        #region
        //student s1 = new student(1, "rajesh");
        //student s2 = new student(3, "Mangesh");
        //student s3 = new student(2, "Pawan");
        //student s4 = new student(5, "Pawan");
        //ar.Add(s1);
        //ar.Add( s2);
        //ar.Add( s3);
        //Console.WriteLine("count="+ar.Count+" Capacity="+ar.Capacity);
        ////ar.Reverse();
        //foreach (var item in ar)
        //{
        //    student s = (student)item;
        //    s.show();
        //}
        //Console.WriteLine("s4 contain  ?" + ar.Contains(s4));
        //Console.WriteLine("index of s3  ?" + ar.IndexOf(s3));
        //ArrayList newstudents = new ArrayList();
        //newstudents.Add(new student(44, "aaa"));
        //newstudents.Add(new student(15, "bbb"));
        //newstudents.Add(new student(61, "cccc"));
        //ar.AddRange(newstudents);
        //Console.WriteLine(  "=========================");
        //ar.Insert(2, new student(999, "zzz"));

        //ar.Sort(new sortByroll());
        //foreach (var item in ar)
        //{
        //    student s = (student)item;
        //    s.show();
        //}
        #endregion

        #region hashtable
        //Hashtable pincode = new Hashtable();

        //pincode[13] = "solapur";
        //pincode[14] = "nagar";
        //Console.WriteLine(pincode[13]);
        //Console.WriteLine(pincode.Count);
        //Console.WriteLine("-------------------");
        //foreach (var item in pincode.Keys)
        //{
        //    Console.WriteLine("values:" + pincode[item]);
        //}
        #endregion
        #region
        //ArrayList cities1 = new ArrayList();
        //string[] c1 = { "pune", "nagar", "nashik" };
        //cities1.AddRange(c1);
        //Console.WriteLine("c1 count"+c1.Count());
        //Hashtable india = new Hashtable();
        //india.Add("maha", cities1);

        //var item = india["maha"];
        //Console.WriteLine("###"+((ArrayList) item).Count);
        //ArrayList temp= (ArrayList)item;

        //foreach (var it1 in temp)
        //{
        //    string s = (String)it1;
        //    Console.WriteLine(s);
        //}
        #endregion
        #region hashtable with Arraylist as value
        Hashtable ht = new Hashtable();
        ht.Add("maha", 4);
        ht.Add("ka", 3);
        Console.WriteLine(ht.Count);
        student s1 = new student(1, "rajesh");
        student s2 = new student(2, "mahesh");
        student s3 = new student(3, "aaa");
        student s4 = new student(4, "bbb");
        student s5 = new student(5, "ccc");
        student s6 = new student(6, "dddd");
        ArrayList as1 = new ArrayList();
        as1.Add(s1);
        as1.Add(s2);
        ht.Add("al1", as1);
        ArrayList as2 = new ArrayList();
        as2.Add(s3);
        as2.Add(s4);
        as2.Add(s5);
        ht.Add("al2", as2);
        ArrayList as3 = new ArrayList();
        as3.Add(s6);
        ht.Add("al3", as3);


        foreach (var item in ht.Values)
        {
            ArrayList temp = (ArrayList)item;
            Console.WriteLine("=======New Arraylist students==========");
            foreach (var ss in temp)
            {
                student tt = (student)ss;
                tt.show();
            }
            //Console.WriteLine(item);
        }

        //Hashtable h1 = new Hashtable();
        //h1.Add(1, "one");
        //h1.Add(2, "two");
        //h1.Add(3, "three");
        //h1.Remove(2);
        //Console.WriteLine(h1.ContainsKey(2));
        #endregion

        #region stack
        //Stack st = new Stack();
        //st.Push(100);
        //st.Push("pravin");
        //st.Push(3.14);
        //Console.WriteLine(st.Count);
        //Console.WriteLine(st.Pop());
        //Console.WriteLine(st.Count);
        //Console.WriteLine(st.Pop());
        //Console.WriteLine(st.Count);
        //Console.WriteLine(st.Pop());
        ////Console.WriteLine(st.Pop());
        //Console.WriteLine(st.Count);

        #endregion

        #region
        //ArrayList ALStudents = new ArrayList();
        //student s1 = new student(1, "rajesh");
        //student s2 = new student(6, "mahesh");
        //student s3 = new student(2, "aaa");
        //student s4 = new student(4, "ccc");
        //student s5 = new student(3, "bbb");
        //student s6 = new student(5, "dddd");
        //ALStudents.Add(s1);
        //ALStudents.Add(s2);
        //ALStudents.Add(s3);
        //ALStudents.Add(s4);
        //ALStudents.Add(s5);
        //ALStudents.Add(s6);
        //Console.WriteLine("=====before sort=======");
        //foreach (var item in ALStudents)
        //{
        //    student temp = (student)item;
        //    temp.show();
        //}
        ////ALStudents.Sort();
        //ALStudents.Sort(new sortByroll());
        //Console.WriteLine("=====after sort=======");
        //foreach (var item in ALStudents)
        //{
        //    student temp = (student)item;
        //    temp.show();
        //}

        //Hashtable PostOffice = new Hashtable();
        //PostOffice.Add(413001, "solapur");
        //PostOffice.Add(4120058, "pune");
        //PostOffice.Add(4000001, "mumbai");

        //Console.WriteLine("count ="+PostOffice.Count);
        //Console.WriteLine("contain 412001  =" + PostOffice.Contains(4120058));

        //student s1 = new student(1, "rajesh");
        //student s2 = new student(3, "pavan");
        //student s3 = new student(2, "anand");
        //ArrayList arl = new ArrayList();
        //arl.Add(s1);
        //arl.Add(s2);
        //arl.Add(s3);

        // arl.Sort();
        //foreach (var item in arl)
        //{
        //    ((student)item).show();
        // }

        // student s4 = new student(1, "rajesh");

        // Console.WriteLine("Arraylist contain s4=" +arl.Contains(s4));// not working with arraylist

        //student s1 = new student(1, "rajesh");
        //student s2 = new student(2, "pavan");
        //student s3 = new student(3, "anand");
        //student s4 = new student(4, "mahesh");
        //ArrayList ar1 = new ArrayList();
        //ar1.Add(s1);
        //ar1.Add(s2);

        //ArrayList ar2 = new ArrayList();
        //ar2.Add(new student(11, "aaa"));
        //ar2.Add(new student(22, "bb"));
        //ar2.Add(new student(33, "cc"));
        //ar2.Add(new student(44, "ddd"));

        //foreach (var item in ar2)
        //{
        //    student ss = (student)item;
        //    ss.show();
        //}
        //List<student> ls = new List<student>();
        //ls.Add(s1);
        //ls.Add(s2);
        //ls.Add(s3);
        //student s4 = new student(1, "rajesh");
        //// Console.WriteLine("list contain s4 =" + ls.Contains(s4));// result list contain s4 true
        //Queue qq = new Queue();
        //qq.Enqueue(100);
        //qq.Enqueue(200);
        //qq.Enqueue(300);
        //Console.WriteLine(qq.Dequeue());
        //Console.WriteLine(qq.Dequeue());
        //Console.WriteLine(qq.Dequeue());
        //Console.WriteLine(qq.Dequeue());
        #endregion
        #region
        //student s1 = new student(1, "rajesh");
        //student s2 = new student(2, "pavan");
        //student s3 = new student(3, "anand");
        //student s4 = new student(4, "mahesh");

        //Hashtable ht = new Hashtable();
        ////ht.Add(1, "one");
        ////ht.Add(2, "two");
        //ht.Add(3, "three");
        //ht.Add(4, "four");
        //ht.Add(5, "five");

        //foreach (DictionaryEntry item in ht)
        //{
        //    Console.WriteLine( "key= "+item.Key+" value="+item.Value );
        //}
        //ht["ss1"] = s1;
        //ht["ss2"] = s2;
        //ht["ss3"] = s3;
        //ht["ss4"] = s4;
        //ht.Add("ss5", new student(55, "zzz"));
        //foreach (DictionaryEntry item in ht)
        //{
        //    Console.Write("key= "+item.Key);
        //    student temp = (student)item.Value;
        //    temp.show();
        //}
        //Console.WriteLine("count="+ht.Count);
        //Console.WriteLine("fixed size =" + ht.IsFixedSize);
        #endregion

        #region
        Stack st = new Stack();

        //st.Push(11);
        //st.Push(22);
        //st.Push(33);
        //Console.WriteLine(  st.Peek());//33
        //Console.WriteLine(st.Peek());//33
        //Console.WriteLine("count="+st.Count);//3
        //Console.WriteLine(st.Peek());//33
        //st.Push(888);//
        //Console.WriteLine(st.Peek());//888
        //Console.WriteLine("count=" + st.Count);//4
        //Console.WriteLine("contain 123? "+st.Contains(123));
        //    #region
        //    student s1 = new student(1, "rajesh");
        //    student s2 = new student(2, "pavan");
        //    student s3 = new student(3, "anand");
        //    student s4 = new student(4, "mahesh");
        //    student s5 = new student(4, "mahesh");
        //    //st.Push(s1);
        //    //st.Push(s2);
        //    //st.Push(s3);
        //    //st.Push(s4);

        //    Queue q1 = new Queue();
        //        q1.Enqueue(s1);
        //        q1.Enqueue(s2);
        //        q1.Enqueue(s3);
        //        q1.Enqueue(s4);


        //    foreach (var item in q1)
        //    {

        //        student temp = (student)item;
        //        temp.show();
        //    }
        //    Stack st1 = new Stack();
        //    st1.Push(s1);
        //    st1.Push(s2);
        //    st1.Push(s3);
        //    st1.Push(s4);
        //    Console.WriteLine("========================");
        //    foreach (var item in st1)
        //    {

        //        student temp = (student)item;
        //        temp.show();
        //    }

        //    Console.WriteLine("s4 contain ?"+st.Contains(s4));
        //    Console.WriteLine("s5 contain ?" + st.Contains(s5));
        //    Console.WriteLine("s4== s4"+object.Equals(s4,s4));

        //    Console.WriteLine("s4== s5" + object.Equals(s4, s5));
        #endregion

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
        Console.WriteLine("-----------");
        //empList.Sort();
        compareByEmpId cbe = new compareByEmpId();
        //empList.Sort(cbe);
        empList.Sort(new compareByEmpId());
        foreach (var item in empList)
        {
            employee e = (employee)item;
            e.show();
        }
        Console.WriteLine("------------------");
        empList.Sort(new compareEmpByName());
        foreach (var item in empList)
        {
            employee e = (employee)item;
            e.show();
        }
    }
}
//-------------------------------