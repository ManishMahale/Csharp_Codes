using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*  Write a program and create class name as student with roll, name and percentage with proper data type. Add 5 students’ records into ArrayList and sort this array list by 1) by roll number 2) by name and 3) by percentage   */
namespace ICom
{
    internal class Sort_Student_Records
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public float Percentage { get; set; }

        public Sort_Student_Records()
        {
            Roll = 0;
            Name = string.Empty;
            Percentage = 0;
        }

        public Sort_Student_Records(int roll, string name, float percentage)
        {
            Roll = roll;
            Name = name;
            Percentage = percentage;
        }

        public void show()
        {
            Console.WriteLine("Roll = " + Roll + " Name = " + Name + " Percentage = " + Percentage);
        }
    }

    internal class ByRoll : Sort_Student_Records, IComparer
    {
        public int Compare(object? x, object? y)
        {
            //    Sort_Student_Records xx = (Sort_Student_Records)x;
            //    Sort_Student_Records yy = (Sort_Student_Records)y;

            //    if (xx.Roll > yy.Roll)
            //    {
            //        return 1;
            //    }
            //    else if (xx.Roll < yy.Roll)
            //    {
            //        return -1;
            //    }
            //    else
            //    {
            //        return 0;
            //    }


            //---------------OR-----------------

            var xx = (Sort_Student_Records)x; // we inherited the Sort_Student_Records so dont need to declare object of class
            var yy = (Sort_Student_Records)y;
            if (xx.Roll > yy.Roll)
            {
                return 1;
            }
            else if (xx.Roll < yy.Roll)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    internal class ByName: IComparer
    {
        public int Compare(object x, object y )
        {
            var n1 = (Sort_Student_Records)x;
            var n2 = (Sort_Student_Records)y;

            return string.Compare(n1.Name, n2.Name);
        }
    }

    internal class ByPercentage : IComparer
    {
        public int Compare(object? x, object? y)
        {
            var p1 = (Sort_Student_Records)x;
            var p2 = (Sort_Student_Records)y;

            if (p1.Percentage > p2.Percentage)
            {
                return 1;
            }
            else if (p1.Percentage < p2.Percentage)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    internal class First
    {
        public static void Main()
        {
            Sort_Student_Records s1 = new Sort_Student_Records(1, "Viraj", 58.8f);
            Sort_Student_Records s2 = new Sort_Student_Records(3, "Aanjay", 90.4f);
            Sort_Student_Records s3 = new Sort_Student_Records(2, "Mahesh", 75.5f);

            ArrayList arr = new ArrayList();
            arr.Add(s1);
            arr.Add(s2);
            arr.Add(s3);

            Console.WriteLine("\n-----Before Sorting-----");
            
            foreach (var i in arr)
            {
                Sort_Student_Records s = (Sort_Student_Records)i;
                s.show();
            }

            //------------------------------------
            Console.WriteLine("\n-----Sort By Roll-----");
            arr.Sort(new ByRoll());
            foreach (var i in arr)
            {
                Sort_Student_Records s = (Sort_Student_Records)i;
                s.show();
            }

            //------------------------------------
            Console.WriteLine("\n-----Sort By Name-----");
            arr.Sort(new ByName());
            foreach (var i in arr)
            {
                Sort_Student_Records s = (Sort_Student_Records)i;
                s.show();
            }

            //-------------------------------------

            Console.WriteLine("\n-----Sort By Percentage-----");
            arr.Sort(new ByPercentage());
            foreach (var i in arr)
            {
                Sort_Student_Records s = (Sort_Student_Records)i;
                s.show();
            }
        }
    }
}

