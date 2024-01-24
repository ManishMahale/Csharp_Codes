/*
 As the name suggests optional parameters are not compulsory parameters, they are optional. It helps to exclude arguments for some parameters. Or we can say in optional parameters, it is not necessary to pass all the parameters in the method. each and every optional parameter contains a default value which is the part of its definition. If we do not pass any arguments to the optional parameters, then it takes its default value. The optional parameters are always defined at the end of the parameter list. Or in other words, the last parameter of the method, constructor, etc. is the optional parameter.
 */
// concept of optional parameters  
using System;

class GFG
{

    // This method contains two regular  
    // parameters, i.e. ename and eid 
    // And two optional parameters, i.e.  
    // bgrp and dept  
    static public void detail(string ename, int eid, 
                    string bgrp = "A+", string dept = "Review-Team" //Default Parameter
                                                                   )

    {
        Console.WriteLine("Employee name: {0}", ename);
        Console.WriteLine("Employee ID: {0}", eid);
        Console.WriteLine("Blood Group: {0}", bgrp);
        Console.WriteLine("Department: {0}", dept);
    }

    // Main Method  
    static public void Main()
    {

        // Calling the detail method  
        detail("XYZ", 123);
        Console.WriteLine("\n");

        detail("ABC", 456, "B-");
        Console.WriteLine("\n");
        
        detail("DEF", 789, "B+", "Software Developer");
    }
}
/*
Output:

Employee name: XYZ
Employee ID: 123
Blood Group: A+
Department: Review-Team


Employee name: ABC
Employee ID: 456
Blood Group: B-
Department: Review-Team


Employee name: DEF
Employee ID: 789
Blood Group: B+
Department: Software Developer
*/