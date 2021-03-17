using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_system.sales_sys
{
    public class Program
    {
        public static void Main(String[] args)
        {

            Product glasses = new Product();
            glasses.name = "Glasses";
            glasses.price = 350;

            Product hat = new Product();
            hat.name = "Hat";
            hat.price = 500;

            Product watch = new Product();
            watch.name = "Watch";
            watch.price = 700;

            Seller nicolas = new Seller();
            nicolas.name = "Nicolas";
            nicolas.age = 23;
            nicolas.AddProduct(glasses);

            Seller diana = new Seller();
            diana.name = "Diana";
            diana.age = 25;
            diana.AddProduct(watch);

            Seller mateo = new Seller();
            mateo.name = "Mateo";
            mateo.age = 22;
            mateo.AddProduct(hat);

            System system = new System();
            system.Addseller(nicolas);
            system.Addseller(diana);
            system.Addseller(mateo);

            float totalSales = system.getTotalSales();
            Console.WriteLine("Total sales amount: " + totalSales);

            float avargeSales = system.getAvarageSales();
                Console.WriteLine("Avarage sales: " + avargeSales);

            Seller cheapestSale = system.CheapestSale();
            Console.WriteLine("Seller name lowest sell: " + cheapestSale.name);

            Product ExpensiveProduct = system.ExpensiveProduct();
            Console.WriteLine("Most expensive product: " + ExpensiveProduct.name + ", Price: " + ExpensiveProduct.price);
        }
    }
}
