using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CostAccountingSystem
{
    public class WriteOffItem 
    {
        public int Count { get; set; }
        public Product Product { get; set; }
        public string Measures { get; set; }
        
        public WriteOffItem(Product product, int count, string measures)
        {
            Product = product;
            Count = count;
            Measures = measures;
        }

        public override string ToString() => Product.Name;

        public XElement ToXml() =>
        new XElement("writeOffItem",
            Product.ToXml(),
            new XElement("count", Count),
            new XElement("measures", Measures));
        
        public static WriteOffItem FromXml(XElement node) =>
            new WriteOffItem(
                Product.FromXml(node.Element("product")),
                (int)node.Element("count"),
                (string)node.Element("measures"));
    }
}
