using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Phone> Phones { get; set; } //Список товаров входящих в категорию
    }
}
