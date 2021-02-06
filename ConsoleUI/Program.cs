using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
    //SOLID'in O harfi
    //Open-Closed Principle = Yapılan yazılıma yeni bir özellik ekliyorsan
    //mevcuttaki hiç bir koduna dokunamazsın
{
    class Program
    {
        static void Main(string[] args)
        {
            //DTO - Data Transformation Object
            ProductTest();
            //IoC
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
    }
}
