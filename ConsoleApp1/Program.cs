using System;

namespace ConsoleApp1
{
    class Program
    {
        private static object product;

        static void Main(string[] args)
        {
            string adi = "e ticaret ödevi";

            Product product1 = new Product();
            product1.productName = "telefon";
            product1.productPrice = 2000;

            Product product2 = new Product();
            product2.productName = "kalem";
            product2.productPrice = 20;

            Product[] products = new Product[] {product1,product2 };
            foreach (var Product in products)
            {
                Console.WriteLine(Product.productName + " " product.productPrice);
            }
        }
    }
}
