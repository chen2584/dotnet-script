public interface ICustomer
{
    string PrintCustomer();
    int GetDiscount();
}

public class SliverCustomer : ICustomer
{
    public string PrintCustomer()
    {
        return "SliverCustomer";
    }

    public int GetDiscount()
    {
        return -50;
    }
}

public class GoldCustomer : ICustomer
{
    public string PrintCustomer()
    {
        return "GoldCustomer";
    }

    public int GetDiscount()
    {
        return -100;
    }
}

public class MyClass
{
    private ICustomer customer;
    public MyClass(ICustomer customer)
    {
        this.customer = customer;
    }

    public void GetDetail()
    {
        Console.WriteLine($"Customer Type: {customer.PrintCustomer()}, Discount: {customer.GetDiscount()}");
    }
}

var customer = new GoldCustomer();

var myClass = new MyClass(customer);
myClass.GetDetail();