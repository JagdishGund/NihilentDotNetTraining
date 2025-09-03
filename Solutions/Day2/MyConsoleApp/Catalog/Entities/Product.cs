namespace Catalog;

public class Product
{
    private string name;
    private decimal weight;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetWet(decimal weight)
    {
        this.weight = weight;
    }

    public decimal GetWet()
    {
        return weight;
    }

    //consrtuctor overloading

    public Product()
    {
        this.name = "Jagdish";
        this.weight = 72.12m;
    }

    public Product(string name, decimal weight)
    {
        this.name = name;
        this.weight = weight;
    }

}