using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Models;

namespace WebShop.Data.Interface
{
    public interface IAllPhones
    {
        IEnumerable<Phone> Phones { get; }
        IEnumerable<Phone> getFavoritePhones { get; set; }
        Phone getObjectPhone(int phoneId);
    }
}
