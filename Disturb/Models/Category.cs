using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Disturb.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Product> Products { get; set; }

    }
}