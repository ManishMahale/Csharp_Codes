/*
 The out is a keyword in C# which is used for the passing the arguments to methods as a reference type. It is generally used when a method returns multiple values. The out parameter does not pass the property. It is not necessary to initialize parameters before it passes to out. The declaring of parameter throughout parameter is useful when a method returns multiple values.
 */


// concept of out parameter 
using System;

class GFG
{

    // Main method 
    static public void Main()
    {

        // Creating variable 
        // without assigning value 
        int num;

        // Pass variable num to the method 
        // using out keyword 
        AddNum(out num);

        // Display the value of num 
        Console.WriteLine("The sum of" + " the value is: {0}", num);

    }

    // Method in which out parameter is passed 
    // and this method returns the value of 
    // the passed parameter 
    public static void AddNum(out int num)
    {
        num = 40;
        num += num;
    }
}
/*
Output:

The sum of the value is: 80
    */