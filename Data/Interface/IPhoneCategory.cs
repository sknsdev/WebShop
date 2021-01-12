using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Models;

namespace WebShop.Data.Interface
{
    public interface IPhoneCategory //Отвечает за получение всех категорий в нашем проекте (из модели Категори)
    {
        IEnumerable<Category> AllCategories { get; }//Получает какие либо данные
        //Функция возвращает список с типом данный Category
    }
}
