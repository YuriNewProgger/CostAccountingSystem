using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CostAccountingSystem
{
    public class Product
    {
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Splitting { get; set; }
        public string Measures { get; set; }
        public int Limit { get; set; }

        public Product() { }

        public Product(string name, string discription, int splitting, string measures, int limit)
        {
            Name = name;
            Discription = discription;
            Splitting = splitting;
            Measures = measures;
            Limit = limit;
        }

        public override string ToString() => $"{Name}";

        public XElement ToXml() =>
        new XElement("product",
            new XElement("name", Name),
            new XElement("discription", Discription),
            new XElement("splitting", Splitting),
            new XElement("measures", Measures),
            new XElement("limit", Limit));
        
        public static Product FromXml(XElement node) =>
            new Product(
                (string)node.Element("name"),
                (string)node.Element("discription"),
                (int)node.Element("splitting"),
                (string)node.Element("measures"),
                (int)node.Element("limit"));

    }
}
