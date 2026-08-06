using EcommereseDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommereseDemo.Controllers;

public class CustomersController : Controller
{
     public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutsUs()
    {
        string content="Doing Ordinary things extraordinary is the key to success";
        ViewData["Message"]=content;
        return View();
    }
    public IActionResult ContactUs()
    {
        Address address=new Address
        {
            Street="601,Pune Satara Road",
            City="Pune",
            State="MH",
            Zipcode="41009"

        };
        ViewData["Address"]=address;

        return View();
    }
    
}