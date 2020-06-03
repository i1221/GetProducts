using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//
// using Microsoft.AspNetCore.Mvc.Rendering;
// using System.Collections.Generic;

namespace WebApplCore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }

    }
}
