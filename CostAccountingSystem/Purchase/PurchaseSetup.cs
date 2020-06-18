using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CostAccountingSystem
{
    public partial class PurchaseSetup : Form
    {
        public Widthcolumn ColumnWidthSetting;

        public OrderItem OrderItem { get; set; }
        public Order Order { get; set; }

        private IList<OrderItem> orderItems = new List<OrderItem>();        
        private List<Order> OrderCollection = new List<Order>();
        private List<Product> products = new List<Product>();

        public PurchaseSetup(Widthcolumn setting)
        {
            InitializeComponent();

            ColumnWidthSetting = setting;
        }

        public PurchaseSetup(Order order, Widthcolumn setting)
        {
            ColumnWidthSetting = setting;

            InitializeComponent();

            Order = order;

            dateTimePicker_Pay.Value = DateTime.Parse(Order.PayDate);
            if (Order.Received != "")
                dateTimePicker_Received.Value = DateTime.Parse(Order.Received);

            orderItems = Order.orderItems;
            foreach(OrderItem orderItem in orderItems)
            {
                ListViewItem item = new ListViewItem(orderItem.Product.Name);
                item.SubItems.Add(orderItem.Count.ToString());
                item.Tag = orderItem;

                listView_Orders.Items.Add(item);
            }

        }

        private void PurchaseSetup_Load(object sender, EventArgs e)
        {
            ColumnWidthSetting(listView_Orders, 75, 25);

            if (File.Exists("products.xml"))
            {
                products = XElement.Load("products.xml")
                    .Elements("product")
                    .Select(productNode => Product.FromXml(productNode))
                    .ToList();

                foreach (Product product in products)
                {
                    comboBox_Product.Items.Add(product);
                }

            }
        }

        private void Button_AddToList_Click(object sender, EventArgs e)
        {
            OrderItem = new OrderItem(
            (Product)comboBox_Product.SelectedItem,
            Convert.ToInt32(numericUpDown_CountProduct.Value),
            int.Parse(textBox_Price.Text));

            ListViewItem item = new ListViewItem(OrderItem.Product.Name);
            item.SubItems.Add(OrderItem.Count.ToString());
            item.Tag = OrderItem;

            listView_Orders.Items.Add(item);
            orderItems.Add(OrderItem);

        }

        private void Button_DeleteFromList_Click(object sender, EventArgs e)
        {
            orderItems.RemoveAt(listView_Orders.SelectedItems[0].Index);

            listView_Orders.Items.RemoveAt(listView_Orders.SelectedItems[0].Index);
            
        }

        private void Button_SaveExit_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0)
                Close();
            else if (dateTimePicker_Received.Checked)
                Order = new Order(dateTimePicker_Pay.Value.ToShortDateString(),
                    dateTimePicker_Received.Value.ToShortDateString(),
                    orderItems);
            else
            {
                Order = new Order(dateTimePicker_Pay.Value.ToShortDateString(),
                "",
                orderItems);
            }

            Close();
        }

        private void PurchaseSetup_Resize(object sender, EventArgs e) =>
            ColumnWidthSetting(listView_Orders, 75, 25);
    }
}
