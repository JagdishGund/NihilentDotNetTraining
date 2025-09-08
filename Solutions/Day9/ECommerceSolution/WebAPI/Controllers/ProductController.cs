using Repositories;
using Services;
using Entities;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;

   private readonly IProductService _productService;
    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
        //  _productService = productService;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        IProductRepository productRepository = new ProductRepository();
        IProductService productService = new ProductService(productRepository);
        return productService.GetAllProducts();
    }

  [HttpPost]
    public ActionResult<Product> AddProduct([FromBody] Product product)
    {
         IProductRepository productRepository = new ProductRepository();
         IProductService productService = new ProductService(productRepository);
        if (product == null)
            return BadRequest("Product cannot be null");

        try
        {
            var createdProduct = productService.AddProduct(product);
            return CreatedAtAction(nameof(Get), new { id = createdProduct.Id }, createdProduct);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}