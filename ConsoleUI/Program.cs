using Business.Concreate;
using DataAccess.Concreate.EntityFrameWork;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //foreach(var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}
            
            
        }
    }
}
