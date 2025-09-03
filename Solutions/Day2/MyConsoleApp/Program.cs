using Catalog;
using HR;

int age = 45;
age++;
if (age < 45)
{
    Console.WriteLine("Not Eligible to Meeting Area");
}
else
{
    Console.WriteLine("You can attend Meeting");
}

Product product = new Product("Lapy", 123);
Console.WriteLine($"Product Name: {product.GetName()}, weight:{product.GetWet()}");

IProductRepository productRepository = new ProductRepository();
IProductService productService = new ProductService(productRepository);
List<Product> productList = new List<Product>()
{
    new Product("Laptop", 1500.00m),
    new Product("Smartphone", 800.00m),
    new Product("Tablet", 400.00m)
};

foreach (var p in productList)
{
    productService.AddProduct(p);
}