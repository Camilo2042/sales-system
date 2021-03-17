using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_system.sales_sys
{
    public class Seller
    {
        public string name;
        public int age;
        Product[] Products = new Product[15];
        int productCount = 0;

        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }

        public Product CheapestSale()
        {
            Product sale = Products[0];

            for (int i = 1; i < productCount; i++)
            {
                if (Products[i].totalSales() < Products[i].totalSales())
                {
                    sale = Products[i];
                }
            }

            return sale;
        }

        public float CalculateTotalSales()
        {
            float totalSales = 0;
            {
                for (int i = 0; i < productCount; i++)
                {
                    float totalPsale = Products[i].totalSales();
                    totalSales = totalSales + totalPsale;
                    Console.WriteLine("Product " + Products[i].name + ": " + productCount);
                }
            }

            return totalSales;
        }


        public float CalculateAverageSales()
        {
            float avarageSales = 0;

            {
                for (int i = 0; i < productCount; i++)
                {
                    float avaragePsale = Products[i].totalSales();
                    avarageSales = avarageSales + avaragePsale;
                }

                return avarageSales;
            }

        }

        public float TotalSales()
        {
            float totalSales = 0;
            {
                for (int i = 0; i < productCount; i++)
                {
                    float totalPsale = Products[i].totalSales();
                    totalSales = totalSales + totalPsale;
                }
            }

            return totalSales;
        }

        public Product ExpensiveProduct()
        {
            Product sale = Products[0];

            for (int i = 1; i < productCount; i++)
            {
                if (Products[i].totalSales() > Products[i].totalSales())
                {
                    sale = Products[i];
                }
            }

            return sale;
        }

    }
    }
