using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CostAccountingSystem
{
    public class Order
    {
        public string PayDate { get; set; }
        public string Received { get; set; }
        public IList<OrderItem> orderItems = new List<OrderItem>();
        public int Price => orderItems.Select(orderItem => orderItem.Price * orderItem.Count).Sum();

        public Order(string payDate, string received, IList<OrderItem> orderItems)
        {
            PayDate = payDate;
            Received = received;
            this.orderItems = orderItems;
        }
        
        public XElement ToXml() =>
        new XElement("order",
            new XElement("dateOfPayment", PayDate),
            new XElement("dateOfReceiving", Received),
            new XElement("orderItems", 
                from b in orderItems
                select b.ToXml()),
            new XElement("price", Price));


        public static Order FromXml(XElement node) =>
            new Order(
                (string)node.Element("dateOfPayment"),
                (string)node.Element("dateOfReceiving"),
                node.Element ("orderItems").Elements("orderItem").Select(i => OrderItem.FromXml(i)).ToList());
    }
}
