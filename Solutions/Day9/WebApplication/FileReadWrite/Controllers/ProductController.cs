using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FileReadWrite.Models;
using FileReadWrite.Entities;
using FileReadWrite.Services;
using FileReadWrite.Repository;

namespace FileReadWrite.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {

        IProductRepository productRepository = new ProductRepository();
        IProductService productService = new ProductService(productRepository);
        return productService.GetAllProducts();

    }
    // [HttpPost]
    // public ActionResult Create(Product product)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         ProductRepository.Add(product);
    //         return RedirectToAction("Index");
    //     }
    //     return View(product);
    // }

    //      public ActionResult Delete(int id)
    //     {
    //         var product = ProductRepository.GetById(id);
    //         if (product == null) return null;
    //         return View(product);
    //     }

    //     // DELETE: Confirm
    //     [HttpPost, ActionName("Delete")]
    //     public ActionResult DeleteConfirmed(int id)
    //     {
    //         ProductRepository.Delete(id);
    //         return RedirectToAction("Index");
    //     }
}
