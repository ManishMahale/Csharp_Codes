/*
->Mathod parametres On C# 
    Named parameters // pass value by using veriable name  eg.  ot.show(name: "rajesh", y: 3.14f, x: 999);
    Value parameter  //normal passing values
    Reference parameter  //passing address id  veriable
    Out parameters  // to fatch the value ,, you can not pass value in it
    In parameters  // only pass the value can not fatch the value
    Parameter array (Params)
    Default parameter  //passing parameter as default value

*/
using System.Reflection;


class outerClass
{
    int x;
    public int y;
    public void refMethod(ref int aa)  //Reference parameter
    {
        Console.WriteLine("aa=" + aa);
        aa = 999;
    }
    public void show(int x, float y, string name)
    {
        Console.WriteLine(x + " " + y + " " + name);
    }
    private class innerClass
    {
        int z;
        outerClass? ob;
        public void display()
        {
            Console.WriteLine("display from iner class");
            ob = new outerClass();
            ob.x = 123;
            ob.y = 99;
            Console.WriteLine(ob.x + " " + ob.y);

        }
    }
}
partial class classAA
{
    private int x;
    public classAA()
    {
        Console.WriteLine("default constructor of AA");
    }
    public void show()
    {
        x = 11;
        Console.WriteLine("show from partial class AA");
    }
}
internal class MathodParameters
{
    private static void Main(string[] args)
    {
        int ab = 123;
        outerClass ot = new outerClass();
        ot.show(name: "rajesh", y: 3.14f, x: 999);//Calling show Mathod Using named parameters
        ot.refMethod(ref ab);  //calling Reference parameter
        Console.WriteLine(ab);


    }
}