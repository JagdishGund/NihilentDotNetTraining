using System;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

public class CustomersController : Controller
{
    private readonly ILogger<CustomersController> _logger;

    public CustomersController(ILogger<CustomersController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
         var cust = new List<Customer>
        {
            new Customer { Id=1, Name="Jagdish", Email = "jgund3@gmail.com", Phone = "1234567890", Address = "Pune" },
            new Customer { Id=2, Name="Onkar", Email = "onkar@gmail.com", Phone = "1234567890", Address = "Solapur" },
            new Customer { Id=3, Name="Sajjan", Email = "sajjan@gmail.com", Phone = "1234567890", Address = "Solapur" }
        };
        return View(cust);

    }

    public IActionResult Details(int id)
    {

        var customer = new Customer { Id = id, Name = "Jagdish", Phone ="678456767", Email = "jgund3@gmail.com", Address = "Pune" };

        return View(customer);
    
    }
}