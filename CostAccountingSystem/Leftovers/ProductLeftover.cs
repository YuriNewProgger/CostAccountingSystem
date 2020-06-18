using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostAccountingSystem
{
    public class ProductLeftover
    {
        public Product Product { get; set; }
        public int Count { get; set; }
        public int Weight { get; set; }

        public ProductLeftover(Product product, int count, int weight)
        {
            Product = product;
            Count = count;
            Weight = weight;
        }

        public override string ToString() => Product.Name;
    }
}
