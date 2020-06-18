using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CostAccountingSystem
{
    public class OrderItem
    {
        public int Count { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(Product product, int count, int price)
        {
            Product = product;
            Count = count;
            Price = price;
        }

        public override string ToString() => $"{Product.Name} x{Count} ";
        
        public XElement ToXml() =>
            new XElement("orderItem",
                Product.ToXml(),
                new XElement("count", Count),
                new XElement("price", Price));
        
        public static OrderItem FromXml(XElement node) =>
            new OrderItem(
                Product.FromXml(node.Element("product")),
                (int)node.Element("count"),
                (int)node.Element("price"));

    }
}
