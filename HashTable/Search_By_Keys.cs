using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HashTable
{
    internal class Search_By_Keys
    {
        public void SearchByPin()
        {
            Hashtable ht2 = new Hashtable();
            ht2.Add(1001, "Pune");
            ht2.Add(1002, "Nashik");
            ht2.Add(1003, "Vapi");
            ht2.Add(1004, "Mumbai");
            
            Console.WriteLine("\nEnter Pincode:");
            int pin = int.Parse(Console.ReadLine());
            if (ht2.ContainsKey(pin))
            {
                var city = ht2[pin];
                Console.WriteLine((string)city); //no need to type cast Primitive datatype like int,float, string, double etc
                //but as good practice type cast it
            }
            else
            {
                Console.WriteLine("City not Found");
            }

            //-----------------OR-------------------------

            //Boolean flag = true;

            //foreach (var item in ht2.Keys)
            //{
            //    int tempKey = (int)item;
            //    if (tempKey == pin)
            //    {
            //        Console.WriteLine(ht2[pin]);
            //        flag = false;
            //        break;
            //    }
            //}
            //if (flag == true)
            //{
            //    Console.WriteLine("City not found");
            //}

            //------------------OR------------------

            //foreach(var key in ht2.Keys)
            //{
            //    int? p =(int)key;
            //    if(p == pin)
            //    {
            //        Console.WriteLine(ht2[pin]);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("City not found");
            //    }
            //}

        }
    }
}
