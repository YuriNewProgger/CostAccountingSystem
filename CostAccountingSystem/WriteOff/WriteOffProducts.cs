using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CostAccountingSystem
{
    public class WriteOffProducts
    {
        public string DateWriteOff { get; set; }
        public string MasterName { get; set; }
        public List<WriteOffItem> writeOffItems = new List<WriteOffItem>();

        public WriteOffProducts(string dateWriteOff, string masterName, List<WriteOffItem> writeOffItems)
        {
            DateWriteOff = dateWriteOff;
            MasterName = masterName;
            this.writeOffItems = writeOffItems;
        }

        public XElement ToXml() =>
        new XElement("writeOff",
            new XElement("date", DateWriteOff),
            new XElement("masterName", MasterName),
            new XElement("writeOffItems",
                from b in writeOffItems
                select b.ToXml()));

        public static WriteOffProducts FromXml(XElement node) =>
            new WriteOffProducts(
                (string)node.Element("date"),
                (string)node.Element("masterName"),
                node.Element("writeOffItems").Elements("writeOffItem").Select(i => WriteOffItem.FromXml(i)).ToList());
         
    }
}
