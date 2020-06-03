using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
// using WebApplCore.Core.Services.Interfaces;
using WebApplCore.Models;

namespace WebApplCore.Controllers
{
    public class ProductController : Controller
    {
        List<Product> productList;
        
        public ProductController()
        {
            productList = new List<Product>
            {
                new Product {Id = 1, Name = "Name_1", Description = "Description_1", Price = 21, UnitsInStock = 31},
                new Product {Id = 2, Name = "Name_2", Description = "Description_2", Price = 22, UnitsInStock = 31},
                new Product {Id = 3, Name = "Name_3", Description = "Description_3", Price = 23, UnitsInStock = 33}
            };
        }

        public ActionResult Index()
        {
            // var model = articlesRepository.GetArticles();
            var model = productList;
            
            return View(model);
        }

        public PartialViewResult GetProducts(string Name)
        {
            // var model = _productService.companySelectList;
            // ViewBag.Companies = _productService.companySelectList;
             var model = productList;

            return PartialView(model);
        }

    }
}

