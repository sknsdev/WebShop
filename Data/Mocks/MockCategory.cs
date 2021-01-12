using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interface;
using WebShop.Data.Models;

namespace WebShop.Data.Mocks
{
    public class MockCategory : IPhoneCategory // Класс реализует интерфейс для работы с категориями
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Android", Description = "Mobile phones working on operation system called Android"},
                    new Category { CategoryName = "IOS", Description = "IPHONES" }
                };
            }
        }
    }
}
