using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_system.sales_sys
{
    public class Product
    {
        public string name;
        public float price;

        public float totalSales()
        {
            return price;
        }
    }
}
