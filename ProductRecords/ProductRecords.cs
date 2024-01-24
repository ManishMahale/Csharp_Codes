class Product
{
    private int Id;
    private String Name;
    private int Qty;
    private int Rate;
    public void SetId(int Id)
    {
        this.Id = Id;
    }
    public int GetId()
    {
        return Id;
    }
    public void SetName(String Name)
    {
        this.Name = Name;
    }
    public String GetName()
    {
        return Name;
    }
    
}

class CalculateBill
{
    void CalBill(Product p)
    {
        //in this fuction we can fatch all products using a loop with the help of array
        //using getter
    }
}
public class BillingApp
{
    public static void Main(string[] arg)
    {
        //here we need to create the more then one object pf Product class and set data in it
        //wee need to create the object of CalculateBill class and pass all product object in CaksukateBill class
    }
}