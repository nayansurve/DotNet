using EcommereseDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommereseDemo.Controllers;

public class ProductController :Controller
{
    private static List<Product> products=new List<Product>()
    {
       new Product{Id=101,Name="Laptop",Price=55000},
       new Product{Id=103,Name="Smart Watch",Price=7000},
       new Product{Id=104,Name="Mobile",Price=90000},
       new Product{Id=105,Name="Mouse",Price=7000},
       new Product{Id=106,Name="Monitor",Price=900000}   
    };

    // ========================
    //Display All products
    // =========================

    public IActionResult List()
    {
        return View(products);
    }

    //===========
    // Display Product details
    //=============
    public IActionResult Details(int id)
    {
        Product product= products.FirstOrDefault(p =>p.Id ==id);

        if(product == null)
        {
            return NotFound();

        }
        return View(product);
    }
    //============
    // Insert Product Means Here WE need to use HttpGet
    //===========
    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }
    [HttpPost]

    public IActionResult Insert(Product product)
    {
        products.Add(product);
        return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Product product=products.FirstOrDefault(p =>p.Id==id);

        if(product == null)
        {
            return NotFound();
        }
        return View(product);
    }

 [HttpGet]
 public IActionResult Update(Product product)
    {
        Product exisitingProduct=products.FirstOrDefault(p => p.Id==product.Id);
        if(exisitingProduct != null)
        {
            exisitingProduct.Name=product.Name;
            exisitingProduct.Price=product.Price;
        }
        return RedirectToAction("List");
    }

     //==============================
        // Remove Product (GET)
        //==============================
        [HttpDelete]
        public IActionResult Remove(int id)
    {
        Product removeProduct=products.FirstOrDefault(P => P.Id == id);
        if(removeProduct == null)
        {
            return NotFound();
        }
        return View(removeProduct);
    }
    [HttpPost]
    public IActionResult Remove(Product product)
    {
        Product existingProduct=products.FirstOrDefault (P => P.Id== product.Id);
        if(existingProduct != null)
        {
            products.Remove(existingProduct);
        }
        return RedirectToAction("List");

    }



}