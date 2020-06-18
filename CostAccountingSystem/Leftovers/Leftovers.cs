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
    public partial class Leftovers : Form
    {
        public Widthcolumn ColumnWidthSetting;

        private List<WriteOffProducts> DecommissionedGoods = new List<WriteOffProducts>();
        private List<Order> orders = new List<Order>();

        private List<ProductLeftover> warehouse = new List<ProductLeftover>();
        
        private List<WriteOffItem> writeOffReport = new List<WriteOffItem>();

        public Leftovers(Widthcolumn setting)
        {
            InitializeComponent();

            ColumnWidthSetting = setting;
        }

        private void Button_ReturnToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

        private void Leftovers_Load(object sender, EventArgs e)
        {
            ColumnWidthSetting(listView_LeftoversProduct, 50, 25, 25);

            LoadOrderInformation();

            CreateWarehouse();

            SumAllOrders();

            LoadWriteOffInformation();

            foreach (WriteOffProducts decommissionedGood in DecommissionedGoods)
                foreach (WriteOffItem writeOffItem in decommissionedGood.writeOffItems)
                    writeOffReport.Add(writeOffItem);

            MinusWriteOff();

            CalculateAndAddItemInListView();
        }

        private void Leftovers_Resize(object sender, EventArgs e) =>
            ColumnWidthSetting(listView_LeftoversProduct, 50, 25, 25);



        private void LoadOrderInformation()
        {
            if (File.Exists("orders.xml"))
            {
                orders = XElement.Load("orders.xml")
                    .Elements("order")
                    .Select(order => Order.FromXml(order))
                    .ToList();
            }
        }

        private void CreateWarehouse()
        {
            foreach (Order order in orders)
            {
                if (order.Received.Length == 0)
                    continue;

                foreach (OrderItem item in order.orderItems)
                {
                    ProductLeftover productLeftover = new ProductLeftover(
                        item.Product,
                        item.Count,
                        item.Product.Splitting * item.Count);

                    warehouse.Add(productLeftover);
                }
            }
        }

        private void SumAllOrders()
        {
            for (int i = 0; i < warehouse.Count; i++)
            {
                for (int j = i; j < warehouse.Count; j++)
                {
                    if (i == j)
                        continue;
                    if (warehouse[i].Product.Name == warehouse[j].Product.Name)
                    {
                        warehouse[i].Count += warehouse[j].Count;
                        warehouse[i].Weight += warehouse[j].Weight;
                        warehouse.RemoveAt(j);
                    }
                }
            }
        }

        private void LoadWriteOffInformation()
        {
            if (File.Exists("writeOff.xml"))
            {
                DecommissionedGoods = XElement.Load("writeOff.xml")
                    .Elements("writeOff")
                    .Select(i => WriteOffProducts.FromXml(i))
                    .ToList();

            }
        }

        private void MinusWriteOff()
        {
            for (int i = 0; i < writeOffReport.Count; i++)
            {
                for (int j = 0; j < warehouse.Count; j++)
                {
                    if (writeOffReport[i].Product.Name == warehouse[j].Product.Name)
                    {
                        warehouse[j].Weight -= writeOffReport[i].Count;
                        if (warehouse[j].Count < 0)
                        {
                            warehouse[j].Count = 0;
                            warehouse[j].Weight = 0;
                        }
                    }
                }
            }
        }

        private void CreateItemWarehouse(ProductLeftover productLeftover, int count, int weight, ListViewItem item)
        {
            item.SubItems.Add($"{count}");
            item.SubItems.Add($"{weight} {productLeftover.Product.Measures}");
            listView_LeftoversProduct.Items.Add(item);

            if (count <= productLeftover.Product.Limit)
            {
                item.UseItemStyleForSubItems = false;
                item.SubItems[1].ForeColor = Color.Red;
                item.SubItems[2].ForeColor = Color.Red;
            }
        }

        private void CalculateAndAddItemInListView()
        {
            foreach (ProductLeftover productLeftover in warehouse)
            {
                int count = 0;
                int weight = 0;

                ListViewItem item = new ListViewItem(productLeftover.Product.Name);

                if (productLeftover.Product.Splitting == 0)
                {
                    count = productLeftover.Count - productLeftover.Weight * (-1);
                    
                    CreateItemWarehouse(productLeftover, count,
                        productLeftover.Product.Splitting, item);
                }
                else if (productLeftover.Count != 0)
                {
                    count = productLeftover.Weight / productLeftover.Product.Splitting;
                    weight = productLeftover.Weight % productLeftover.Product.Splitting;
                    
                    CreateItemWarehouse(productLeftover, count, weight, item);
                }
                else
                {
                    weight = productLeftover.Product.Splitting - productLeftover.Weight;
                    
                    CreateItemWarehouse(productLeftover, count, weight, item);
                }
            }
        }

        
    }
}
