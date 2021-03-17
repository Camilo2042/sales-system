using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_system.sales_sys
{
    class System
    {
        Seller[] Sellers = new Seller[15];
        int sellerCount = 0;

        public void Addseller(Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }

        public float getTotalSales()
        {
            float totalSales = 0;
            for (int i = 0; i < sellerCount; i++)
            {
                totalSales = totalSales + Sellers[i].CalculateTotalSales();
            }

            return totalSales;
        }

        public Seller CheapestSale()
        {
            Seller seller = Sellers[0];

            for (int i = 1; i < sellerCount; i++)
            {
                if (Sellers[i].CheapestSale().totalSales() < seller.TotalSales())
                {
                    seller = Sellers[i];
                }
            }

            return seller;

        }

        public float getAvarageSales()
        {
            float totalAvarageSales = 0;
            for (int i = 0; i < sellerCount; i++)
            {
                totalAvarageSales = totalAvarageSales + Sellers[i].CalculateAverageSales() / sellerCount;
            }

            return totalAvarageSales;
        }

        public Product ExpensiveProduct()
        {
            Product product = Sellers[0].ExpensiveProduct();

            for (int i = 1; i < sellerCount; i++)
            {
                if (Sellers[i].ExpensiveProduct().totalSales() > product.totalSales())
                {
                    product = Sellers[i].ExpensiveProduct();
                }
            }

            return product;
        }
    }
}
