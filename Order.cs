using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile201_GroupProject1
{
    internal class Order
    {
        // fields 
        public const decimal TAX_RATE = 0.09M;
        private List<Product> productInOrder;

        // properties
        public List<Product> ProductInOrder
        {
            get { return productInOrder; }
            set { productInOrder = value; }
        }

        // constructors 
        public Order(List<Product> productsInOrder)
        {
            ProductInOrder = productsInOrder;
        }

        // methods 
        public decimal CalculateSubTotal()
        {
            decimal subTotal = 0;
            foreach (Product p in ProductInOrder)
            {
                subTotal += p.CalculateProductCost();

            }
            return subTotal;
        }

        public decimal CalculateTax()
        {
            decimal TaxAmount;
            TaxAmount = CalculateSubTotal() * TAX_RATE;
            return TaxAmount;
        }

        public decimal CalculateTotal()
        {
            decimal total;
            total = CalculateSubTotal() + CalculateTax();
            return total;
        }

        // tostring 

        public override string ToString()
        {
            string str;
            str = $"        Dragon Phoenix Toy\n";
            str += $"             123 Toy St.\n";
            str += $"       Argentina OK 48451\n";
            str += $"   " + DateTime.Now.ToString() + "\n";
            foreach (Product p in ProductInOrder)
            {
                str += $"{p.Name,-15}{p.UnitSold,-2}{p.CalculateProductCost(),10:n2}\n";
            }
            str += $"{"Sub total:",15}{CalculateSubTotal(),10:n2}\n";
            str += $"{"Tax:",15}{CalculateSubTotal(),10:n2}\n";
            str += $"{"Total:",15}{CalculateTotal(),10:n2}";
            return str;

        }



    }
}
