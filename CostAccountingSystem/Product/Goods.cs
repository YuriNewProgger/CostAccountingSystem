using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CostAccountingSystem
{
    public partial class Goods : Form
    {
        public Widthcolumn ColumnWidthSetting;
        
        public Product ProductItem { get; set; }
        private IList<Product> products = new List<Product>();
        private bool IsChanges = false;


        public Goods(Widthcolumn setting)
        {
            InitializeComponent();

            ColumnWidthSetting = setting;
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            ColumnWidthSetting(listView_Goods, 30, 30, 13, 13, 13);


            if (File.Exists("products.xml"))
            {
                products = XElement.Load("products.xml")
                    .Elements("product")
                    .Select(productNode => Product.FromXml(productNode))
                    .ToList();

                foreach (Product product in products)
                    CreateItem(product);

            }
        }
        
        private void Button_ReturnToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
            
            if (IsChanges)
            {
                products.Clear();

                foreach (ListViewItem item in listView_Goods.Items)
                    products.Add((Product)item.Tag);

                XElement root = new XElement("products",
                    from b in products
                    select b.ToXml()
                    );

                root.Save("products.xml");

                IsChanges = false;
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            ProductSetup productSetup = new ProductSetup();
            productSetup.ShowDialog();
            ProductItem = productSetup.Product;

            if (ProductItem == null)
                return;
            
            CreateItem(ProductItem);
            
            IsChanges = true;
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нельзя изменить товар после добавления",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (listView_Goods.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберете товар", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Удалить товар: {listView_Goods.SelectedItems[0].Text}?", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                == DialogResult.OK)
            {
                listView_Goods.Items.RemoveAt(listView_Goods.SelectedItems[0].Index);
                IsChanges = true;
            }
        }

        private void Goods_Resize(object sender, EventArgs e) => 
            ColumnWidthSetting(listView_Goods, 30, 30, 13, 13, 13);
            

        private void CreateItem(Product product)
        {
            ListViewItem item = new ListViewItem(product.Name);
            item.SubItems.Add(product.Discription);
            item.SubItems.Add(product.Splitting.ToString());
            item.SubItems.Add(product.Measures);
            item.SubItems.Add(product.Limit.ToString());
            item.Tag = product;

            listView_Goods.Items.Add(item);
        }
        
    }
}
