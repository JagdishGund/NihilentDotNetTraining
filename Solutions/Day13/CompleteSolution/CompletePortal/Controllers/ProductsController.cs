
using CatalogServices;
using CatalogEntities;

using Microsoft.AspNetCore.Mvc;

namespace CompletePortal.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    private readonly IProductService _productService;

    public ProductsController(ILogger<ProductsController> logger, IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
       return _productService.GetAllProducts();
    }

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        var product = _productService.GetProductById(id);

        if (product == null)
            return NotFound();

        return Ok(product);
    }

    // POST: api/products
    // [HttpPost]
    // public ActionResult<Product> AddProduct([FromBody] Product product)
    // {
    //     if (product == null)
    //         return BadRequest("Product cannot be null");

    //     try
    //     {
    //         var createdProduct = _productService.AddProduct(product);

    //         // returns 201 Created with a Location header pointing to GET api/products/{id}
    //         return CreatedAtAction(
    //             nameof(Get),
    //             new { id = createdProduct.Id },
    //             createdProduct
    //         );
    //     }
    //     catch (ArgumentException ex)
    //     {
    //         return BadRequest(ex.Message);
    //     }
    // }

    [HttpDelete("{id}")]
    public bool DeleteProduct(int id)
    {
    
        var deleted = _productService.DeleteProduct(id);
        if (!deleted)
            return false;

        return true;
    }

    // [HttpGet("{id}")]

    // public IActionResult GetProductById(int id)
    // {
    //     IProductRepository productRepository = new ProductRepository();
    //     IProductService productService = new ProductService(productRepository);
    //     var product = productService.GetProductById(id);
    //     if (product == null)
    //         return NotFound($"Product with given id {id} is not available");

    //     return Ok(product);
    // }

    // [HttpPut("{id}")]

    // public ActionResult<Product> UpdateProduct(int id, [FromBody] Product updatedProduct)
    // {
    //     IProductRepository productRepository = new ProductRepository();
    //     IProductService productService = new ProductService(productRepository);
    //     var product = productService.UpdateProduct(id, updatedProduct);

    //     if (updatedProduct == null || id != updatedProduct.Id)
    //         return BadRequest("Product Id mismatch or invalid data");


    // if (!product)
    //     return NotFound($"Product with Id {id} not found");

    // return Ok($"Product with Id {id} updated successfully");
        
    // }
}