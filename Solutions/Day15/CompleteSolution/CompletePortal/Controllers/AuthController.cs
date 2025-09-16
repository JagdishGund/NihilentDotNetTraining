
namespace CompletePortal.Controllers;

using CatalogEntities;
using CatalogServices;
using Microsoft.AspNetCore.Mvc;

public class AuthController : Controller
{


    public AuthController()
    {

    }


    [HttpGet]   //attribute , Decorator, Annotation, Metadata
                //Action Filter
    public IActionResult Login()
    {

        return View();
    }


    [HttpPost]
    public IActionResult Login(string email, string password)
    {

        if (email == "jagdish.gund@nihilent.com" && password == "Jagdish1993")
        {
            // this.Response.Redirect("/home/index");
            this.Response.Redirect("/products/index");
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

        if (email == "jagdish.gund@nihilent.com" && password == "Jagdish1993")
        {
            this.Response.Redirect("/auth/login");
        }
         
        return View();
    }

}