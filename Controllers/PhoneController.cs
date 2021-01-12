using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interface;

namespace WebShop.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IAllPhones _allPhones;
        private readonly IPhoneCategory _allCategory;

        public PhoneController(IAllPhones iPhones, IPhoneCategory iCategory)
        {
            _allCategory = iCategory;
            _allPhones = iPhones;
        }

        public ViewResult ListResult()
        {
            var phones = _allPhones.Phones;
            return View(phones);
        }
    }
}
