namespace Catalog;

public class Product
{
    private string name;
    private decimal amount;

    public void setName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }

     public void SetPrice(decimal amount)
        {
            this.amount = amount;
        }

        public decimal GetPrice()
        {
            return amount;
        }

    public Product(string name, decimal amount)
    {
        this.name = name;
        this.amount = amount;
    }

     //Constructor overloading
        public Product()
        {
            this.name = string.Empty;
            this.amount = 0.0m;
        }
}