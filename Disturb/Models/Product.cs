using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Disturb.Models
{
    //[Bind(Exclude = "ProductId")]
    public class Product
    {
        //public Product()
        //{
        //    //Category = new Category();
        //}
        [ScaffoldColumn(false)]
        public int Id{ get; set; }
        [DisplayName("Код")]
        public string Code { get; set; }
        [DisplayName("Категория")]
        public int CategoryId { get; set; }
        [DisplayName("Марка")]
        public int BrandId { get; set; }
        [DisplayName("Описание")]
        [Required(ErrorMessage = "Описанието не може да бъде празно")]
        [StringLength(255)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Цената не може да бъде празна")]
        [Range(0.01, 100.00, ErrorMessage = "Цената трябва да е м/у 0.01 и 100.00")]
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        [DisplayName("Снимка")]
        [StringLength(1024)]
        public string PicUrl { get; set; }

        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}