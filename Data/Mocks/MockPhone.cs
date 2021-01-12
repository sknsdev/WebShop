using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interface;
using WebShop.Data.Models;

namespace WebShop.Data.Mocks
{
    public class MockPhone : IAllPhones
    {
        private readonly IPhoneCategory _categoryPhone = new MockCategory();

        public IEnumerable<Phone> Phones 
        { 
        get
            {
                return new List<Phone>
                {
                    new Phone
                    {
                        Name = "Apple iPhone 12 pro",
                        ShortDescription = "Iphone 12",
                        LongDescription = "C iPhone 12 Pro можно использовать адаптеры питания, наушники EarPods с разъёмом Lightning и кабели USB‑A/Lightning, которые у вас уже есть.",
                        ImgUrl = "https://mytradestore.ru/upload/iblock/022/022e5885b2bf29c2ec6af3042586869a.png",
                        Price = 89900,
                        isFavorite = true,
                        Available = true,
                        Category = (Category)_categoryPhone.AllCategories.Where(e=> e.CategoryName =="IOS")

                    },
                 new Phone
                    {
                        Name = "Apple iPhone 11",
                        ShortDescription = "APPLE iphone 11",
                        LongDescription = "C iPhone 11 В мире проданы миллиарды таких аксессуаров — и часто покупателям просто не нужны новые.",
                        ImgUrl = "https://mytradestore.ru/upload/iblock/022/022e5885b2bf29c2ec6af3042586869a.png",
                        Price = 89900,
                        isFavorite = true,
                        Available = true,
                        Category = (Category)_categoryPhone.AllCategories.Where(e=> e.CategoryName =="IOS")

                    },
                  new Phone
                  {
                      Name = "Huawei mate 20 lite",
                      ShortDescription = "Ну такой телефон ",
                      LongDescription = "Блни ну такое — и часто покупателям просто не нужны новые.",
                      ImgUrl = "https://mytradestore.ru/upload/iblock/022/022e5885b2bf29c2ec6af3042586869a.png",
                      Price = 89900,
                      isFavorite = true,
                      Available = true,
                      Category = (Category)_categoryPhone.AllCategories.Where(e => e.CategoryName == "Android")

                  },
                };
            }
        }
        public IEnumerable<Phone> getFavoritePhones { get; set; }

        public Phone getObjectPhone(int phoneId)
        {
            throw new NotImplementedException();
        }
    }
}
