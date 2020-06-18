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
    public partial class Purchase : Form
    {
        Widthcolumn ColumnWidthSetting;

        private List<Order> orders = new List<Order>();
        
        public Order Order { get; set; }

        public Purchase(Widthcolumn setting)
        {
            InitializeComponent();

            ColumnWidthSetting = setting;
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            ColumnWidthSetting(listView_Purchase, 20, 20, 40, 20);
            

            if (File.Exists("orders.xml"))
            {
                orders = XElement.Load("orders.xml")
                    .Elements("order")
                    .Select(node => Order.FromXml(node))
                    .ToList();
                
                CreateItemsForListView();
            }
        }
        
        private void Button_ReturnToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();

            XElement root = new XElement("orders",
                from b in orders
                select b.ToXml());

            root.Save("orders.xml");
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            PurchaseSetup purchaseSetup = new PurchaseSetup(ColumnWidthSetting);
            purchaseSetup.ShowDialog();
            Order = purchaseSetup.Order;

            if (Order == null)
                return;

            orders.Add(Order);

            listView_Purchase.Items.Clear();

            CreateItemsForListView();
            
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (listView_Purchase.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберете закупку", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Удалить закупку от: {listView_Purchase.SelectedItems[0].Text}?", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                == DialogResult.OK)
            {
                int index = listView_Purchase.SelectedItems[0].Index;

                listView_Purchase.Items.RemoveAt(listView_Purchase.SelectedItems[0].Index);

                orders.RemoveAt(index);
            }
            
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            if (listView_Purchase.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберете закупку", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Order = (Order)listView_Purchase.SelectedItems[0].Tag;
            PurchaseSetup purchaseSetup = new PurchaseSetup(Order, ColumnWidthSetting);
            purchaseSetup.ShowDialog();
            Order = purchaseSetup.Order;
            
            Replacement();

            listView_Purchase.Items.Clear();

            CreateItemsForListView();
        }

        private void Replacement()
        {
            int index = listView_Purchase.SelectedItems[0].Index;
            listView_Purchase.SelectedItems[0].Remove();
            orders.RemoveAt(index);
            orders.Insert(index, Order);
        }

        private void Purchase_Resize(object sender, EventArgs e) =>
            ColumnWidthSetting(listView_Purchase, 20, 20, 40, 20);
        
        
        private void CreateItemsForListView()
        {
            foreach (Order order in orders)
            {
                string x = "";
                foreach (OrderItem orderItem in order.orderItems)
                    x += $"{orderItem.Product.Name} x{orderItem.Count}";
                ListViewItem item = new ListViewItem(order.PayDate);
                item.SubItems.Add(order.Received);
                item.SubItems.Add(x);
                item.SubItems.Add(order.Price.ToString());
                item.Tag = order;

                listView_Purchase.Items.Add(item);

            }
        }
    }
}
