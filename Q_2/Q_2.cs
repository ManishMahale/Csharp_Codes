/*  WAP in C#. create a a abstract class Vehicle which having abstract method 
engineCapacity(). extend class Vehicle in class Car and override method 
engineCapacity() and show message 1000 CC. extend class Vehicle in class Bike and 
override method engineCapacity() and show message 125 CC Engine. WAP to display 
engine capacity using late binding/ runtime polymorphism.   */

abstract class Vahical
{
    abstract public void EngineCapacity();
}
class Car : Vahical
{
    override public void EngineCapacity()
    {
        Console.WriteLine("Car Engine Capacity 1000 CC");
    }
}

class Bike : Vahical
{
    override public void EngineCapacity()
    {
        Console.WriteLine("Bike Engine Capacity 125 CC");
    }
}

class First
{
    public static void Main()
    {
        Vahical v = new Car();
        v.EngineCapacity();
        
        Vahical v2 = new Bike();
        v2.EngineCapacity();
    }
}