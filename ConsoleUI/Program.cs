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
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
