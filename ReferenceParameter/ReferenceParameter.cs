/*
 ref keyword used for Reference parameter in C# which is used for passing the value types by reference. Or we can say that if any changes made in this argument in the method will reflect in that variable when the control return to the calling method. The ref parameter does not pass the property. In ref parameters, it is necessary that the parameters should initialize before it pass to ref. The passing of value through the ref parameter is useful when the called method also needs to change the value of the passed parameter.
 */


// C# program to illustrate the 
// concept of ref parameter 
using System;
using System.Text.RegularExpressions;

class GFG
{
    static void CompareValue(ref string val1)
    {
        // Compare the value 
        if (val1 == "Dog")
        {
            Console.WriteLine("Matched!");
        }

        // Assigning new value 
        val1 = "Cat";
    }

    // Main Method 
    public static void Main()
    {

        // Assigning value 
        string val = "Dog";

        // Pass as a reference parameter 
        CompareValue(ref val);  //calling mathod using reference

        // Display the given value 
        Console.WriteLine(val);
    }
}
/*
Output:

Matched!
Cat
*/