// WAP to Find Area Of ciecle And Rectangle
class Circle
{
    protected float redius;
    public void SetRedius(float redius)
    {
        this.redius = redius;
    }
   public void ShowCircleArea()
    {
        Console.WriteLine("Area OF Circle = "+2*3.14f*redius+"\n");
    }
}
class Rectangle
{
    protected float l, w;
   public void SetLW(float l, float w)
    {
        this.l = l;
        this.w = w;
    }

    public void ShowRectangleArea()
    {
        Console.Write("Area of Rectangle= " + l * w);
       
    }
}
class Area
{
    public static void Main(string[] args)
    {
        float redius, len, wid;

        Console.WriteLine("Enter Redius:");
        Circle c = new Circle();
        redius = float.Parse(Console.ReadLine());
        c.SetRedius(redius);
        c.ShowCircleArea();

        Console.WriteLine("Enter Lenght and Width:");
        len= int.Parse(Console.ReadLine());
        wid= int.Parse(Console.ReadLine());
        Rectangle r= new Rectangle();
        r.SetLW(len, wid);
        r.ShowRectangleArea();
    }
}
