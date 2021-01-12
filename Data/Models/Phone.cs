using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Data.Models
{
    public class Phone //описание самого телефона
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImgUrl { get; set; }
        public int Price { get; set; }
        public bool isFavorite { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; } //к какой категории относится
        public virtual Category Category { get; set; }
    }
}
