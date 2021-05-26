using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsLab.Models;
using System.Diagnostics;

namespace ProductsLab.Controllers
{
    public class ProductsController : Controller
    {
        List<ProductModel> products = new List<ProductModel> { new ProductModel()
            {
                Id = 1,
                Name = "iPhone 12",
                Price = 3999,
                Image = "https://www.techinn.com/f/13782/137821845/apple-iphone-12-pro-max-6gb-128gb-6.7.jpg"
            },
            new ProductModel()
            {
                Id = 2,
                Name = "Huwawei P30 Pro",
                Price = 2799,
                Image = "https://img.gkbcdn.com/s3/p/2019-03-27/huawei-p30-pro-6-47-inch-8gb-512gb-smartphone-aurora-1574132222782.jpg"
            },
            new ProductModel()
            {
                Id = 3,
                Name = "Samsung A50",
                Price = 4999,
                Image = "https://jawalmax.com/wp-content/uploads/2019/02/Samsung-Galaxy-A50.jpg"
            }


        };
        public IActionResult Index(string color, string size)
        {
            /* products.Add(new Product()
             {
                 Id = 1,
                 Name = "iPhone",
                 Price = 3999
             }) ;
             products.Add(new Product()
             {
                 Id = 2,
                 Name = "Huawei",
                 Price = 2799
             });
             products.Add(new Product()
             {
                 Id = 3,
                 Name = "Samsung A50",
                 Price = 4999
             });*/
            ViewBag.Title = "Phone Shop";
            ViewBag.ProductList = products;
            ViewBag.Color = color;
            ViewBag.Size = size; 
            return View();
        }

        public IActionResult Details(int ID)
        {
            ViewBag.Title = "Details";
            if (ID > 0)
            {
                
                foreach (var product in products)
                {
                    if (product.Id == ID)
                    {   
                        ViewBag.Product = product;
                        break;
                    }
                }
                
            }
            else
            {

                ProductModel product1 = new ProductModel()
                {
                    Id = 4,
                    Name = "Samsung A50",
                    Price = 4999,
                    Image = "https://jawalmax.com/wp-content/uploads/2019/02/Samsung-Galaxy-A50.jpg"
                };
                products.Add(product1);
                ViewBag.Product = product1;
            }

           
            return View();
        }

        public IActionResult Random()
        {
            return View();
        }


    }
}
