class Customer
{
    public virtual double getDiscount(double TotalSales)
    {
        return TotalSales;
    }
}

class SilverCustomer : Customer
{
    public override double getDiscount(double TotalSales)
    {
        return base.getDiscount(TotalSales) - 50;
    }
}

class GoldCustomer : SilverCustomer
{
    public override double getDiscount(double TotalSales)
    {
        return base.getDiscount(TotalSales) - 100;
    }
}

var list = new List<Customer>();
list.Add(new GoldCustomer());
list.Add(new SilverCustomer());
list.Add(new Customer());

foreach(var data in list)
{
    Console.WriteLine($"{data.GetType().Name}: {data.getDiscount(1000)}");
}