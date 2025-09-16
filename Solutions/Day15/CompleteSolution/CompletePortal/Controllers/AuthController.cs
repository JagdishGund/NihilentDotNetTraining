
namespace CompletePortal.Controllers;

using CRMEntities;
using CRMServices;
using CRMRepositories;
using Microsoft.AspNetCore.Mvc;

public class AuthController : Controller
{
   
   private readonly ICustomerService _customerService;

    public AuthController(ICustomerService customerService)
    {

        _customerService = customerService;
    }


    [HttpGet]  
    public IActionResult Login()
    {

        return View();
    }


    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var customers = _customerService.GetAllCustomers();

        var customer = customers.FirstOrDefault(c => 
        c.Email.Equals(email, StringComparison.OrdinalIgnoreCase) 
        && c.Password == password);
        if (customer != null)
        {
            this.Response.Redirect("/auth/register");
        }

        return View();
    }



    public IActionResult Register()
    {

        return View();
    }

    [HttpPost]
    public IActionResult Register(string name, string email, string password)
    {
        var customers = _customerService.GetAllCustomers();
        var existingCustomer = customers.FirstOrDefault(c =>
            string.Equals(c.Email, email, StringComparison.OrdinalIgnoreCase));

        if (existingCustomer != null)
        {
            ViewBag.ErrorMessage = "User already exists with this email address.";
            return View();
        }

        var names = name.Split(' ', 2);
        string firstName = names[0];
        string lastName = names.Length > 1 ? names[1] : "";
        var newCustomer = new Customer
        {
            Id = customers.Any() ? customers.Max(c => c.Id) + 1 : 1,
            FistName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };

        _customerService.AddCustomer(newCustomer);

        this.Response.Redirect("/auth/login");
      return View();
}


}