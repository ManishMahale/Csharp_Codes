using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Direct_values_in_ArrayList
    {
        public void Arralist_Value()
        {
            Hashtable ht1 = new Hashtable();
            ArrayList cities1 = new ArrayList();
            cities1.Add("pune");
            cities1.Add("Mumbai");
            cities1.Add("Nagar");

            ArrayList cities2 = new ArrayList();
            cities2.Add("Panjim");

            ArrayList cities3 = new ArrayList();
            cities3.Add("Maysoor");
            cities3.Add("Banglore");
            ht1.Add("MH", cities1);
            ht1.Add("GA", cities2);
            ht1.Add("KA", cities3);

            foreach (var item in ht1.Keys)
            {
                string state = (string)item;

                Console.Write(" Cities in State :" + state);

                var x = ht1[state];

                ArrayList temp = (ArrayList)x;//unboxing

                foreach (var city in temp)
                {
                    Console.Write(" " + (string)city);
                }
                Console.WriteLine("");
            }
        }
    }
}
