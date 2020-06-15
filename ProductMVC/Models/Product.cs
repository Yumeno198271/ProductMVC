using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductMVC.Models
{
    public class Product
    {

        [DisplayName("產品編號")]
        public int ID { get; set; }

        [Required]
        [DisplayName("產品名稱")]
        public string ProductName { get; set; }


        [RegularExpression(@"^[0-9]*$", ErrorMessage = "只能輸入數字")]
        [Required]
        [DisplayName("售價")]
        public int Price { get; set; }


    }
}