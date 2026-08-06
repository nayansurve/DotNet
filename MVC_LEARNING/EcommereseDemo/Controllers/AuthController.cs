using EcommereseDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
namespace EcommereseDemo.Controllers;

public class AuthController : Controller
{
    //action methods

    [HttpGet]
    public IActionResult Login()
    {
        Credential credential=new Credential();
        credential.UserName="";
        credential.Password="";
        return View(credential);
    }
    [HttpPost]
   public IActionResult Login(Credential credential)
    {
        if(credential.UserName == "admin" && credential.Password=="transflower")
        {
            return RedirectToAction("Welcome" ,"Home");
        }
        else
        {
            return View();
        }
    }
    [HttpGet]
    public IActionResult Register()
    {
        Customer customer=new Customer();
        customer.Name="";
        customer.Email="";
        customer.Phone="";
        customer.Id=2;

        return View(customer);

    }

      [HttpPost]
      public IActionResult Register(Customer customer)
    {
        //login to Register a new user
        Console.WriteLine($"New user registered : {customer.Name},{customer.Email},{customer.Phone}");
        return RedirectToAction("Login");
    }

    public IActionResult ChangePassword()
    {
        return View();
    }









    
}