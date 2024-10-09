public class Product : IProduct
{
    private string name;
    private decimal price;
    private int stock;

    public Product(string name, decimal price, int stock)
    {
        this.name = name;
        this.price = price;
        this.stock = stock;
    }

    public string GetName()
    {
        return name;
    }

    public decimal GetPrice()
    {
        return price;
    }

    public int GetStock()
    {
        return stock;
    }
}