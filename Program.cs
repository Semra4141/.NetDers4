using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.ID=0;
            product1.CategoryId=1;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 5;

            ProductManager productManeger = new ProductManager();

           

        }
    }
}
