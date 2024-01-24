/*WAR to create HashTable to store state name as key and ArrayList of 5 cities as value.   Display all cities by state(key). And search state by specific city name.
*/
using HashTable;
using System.Collections;

class StateCity
{
    public string state { get; set; }
    public string city { get; set; }
    public StateCity()
    {
        state = string.Empty;
        city = string.Empty;
    }
    public StateCity(string city)
    {
        this.state = string.Empty;
        this.city = city;
    }
    public void show()
    {
        Console.WriteLine(state + "\t" + city);
    }
}

class First
{
    public static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();

        StateCity sc1 = new StateCity("Surat");
        StateCity sc2 = new StateCity("Navsari");
        StateCity sc3 = new StateCity("Vapi");
        ArrayList arr1 = new ArrayList();
        arr1.Add(sc1);
        arr1.Add(sc2);
        arr1.Add(sc3);

        StateCity sc4 = new StateCity("Pune");
        StateCity sc5 = new StateCity("Nashik");
        ArrayList arr2 = new ArrayList();
        arr2.Add(sc4);
        arr2.Add(sc5);

        ht.Add("Gujrat", arr1); //(key, value)
        ht.Add("Maharashtra", arr2);
        Console.WriteLine("\n\n---------Class StateCity---------");
        foreach (var item1 in ht.Keys)
        {
            string state = (string)item1;

            Console.WriteLine("State: " + state);

            var x = ht[state]; // Gujrat, Maharashtra 
            //var x = ht[state]; ,, when we are access value of array we write arr[i] == value same as here 'state' is just like index
            // ht[state] is object type, therefore x is also object type 

            ArrayList ar = (ArrayList)x;

            Console.Write("Cities: ");
            foreach (var city in ar)
            {
                StateCity tempcity = (StateCity)city;
                //string a = tempcity.city;
                //Console.Write(a+" ");                
                Console.Write(tempcity.city + "  ");
            }
            Console.WriteLine("\n");
        }


        //--------------for another class Direct_values_in_ArrayList--------------------
        Console.WriteLine("\n\n---------Class Direct_values_in_ArrayList---------\n");
        Direct_values_in_ArrayList d = new Direct_values_in_ArrayList();
        d.Arralist_Value();

        //-----------for class Search_By_Keys----------------
        Console.WriteLine("\n\n---------Class Search_By_Keys---------");
        Search_By_Keys SKeys = new Search_By_Keys();
        SKeys.SearchByPin();
    }
}