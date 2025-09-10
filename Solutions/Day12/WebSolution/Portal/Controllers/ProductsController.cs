using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

public class ProductsController : Controller
{

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Rose Bouquet", Price = 29.99M },
            new Product { Id = 2, Name = "Tulip Bouquet", Price = 19.99M },
            new Product { Id = 3, Name = "Lily Bouquet", Price = 24.99M }
        };
        return View(products);

    }

    public IActionResult Details(int id)
    {
          var product = new Product { Id = id, Name = "Jagdish", Price = 29.99M, Description = "Handsome hunk", ImageUrl = "/images/itsme.jpeg" };

          return View(product);
    }
}