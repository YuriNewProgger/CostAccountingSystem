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
    public partial class WriteOffSetup : Form
    {

        public Widthcolumn ColumnWidthSetting;

        public List<WriteOffItem> writeOffItems = new List<WriteOffItem>();
        public WriteOffProducts WriteOffProducts { get; set; }

        private List<Product> products = new List<Product>();

        public WriteOffSetup(Widthcolumn setting)
        {
            InitializeComponent();

            ColumnWidthSetting = setting;
        }

        public WriteOffSetup(WriteOffProducts writeOffProducts, Widthcolumn setting)
        {
            InitializeComponent();

            ColumnWidthSetting = setting;

            WriteOffProducts = writeOffProducts;
            writeOffItems = WriteOffProducts.writeOffItems;

            dateTimePicker_WriteOfffDate.Value = DateTime.Parse(WriteOffProducts.DateWriteOff);
            textBox_MasterName.Text = WriteOffProducts.MasterName;
            
            foreach (WriteOffItem writeOffItem in writeOffItems)
            {
                ListViewItem item = new ListViewItem(writeOffItem.Product.Name);
                item.SubItems.Add(writeOffItem.ToString());
                item.Tag = writeOffItem;

                listView_WriteOffItem.Items.Add(item);
            }
            
        }

        private void WriteOffSetup_Load(object sender, EventArgs e)
        {
            ColumnWidthSetting(listView_WriteOffItem, 75, 25);

            if (File.Exists("products.xml"))
            {
                products = XElement.Load("products.xml")
                    .Elements("product")
                    .Select(productNode => Product.FromXml(productNode))
                    .ToList();

                foreach (Product product in products)
                    comboBox_Products.Items.Add(product);
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            WriteOffItem writeOffItem = new WriteOffItem(
                (Product)comboBox_Products.SelectedItem, 
                int.Parse(numericUpDown_Count.Value.ToString()),
                (string)comboBox_Measures.SelectedItem);
            
            ListViewItem item = new ListViewItem(writeOffItem.Product.Name);
            item.SubItems.Add($"{writeOffItem.Count}{writeOffItem.Measures}");
            item.Tag = writeOffItem;

            listView_WriteOffItem.Items.Add(item);

            writeOffItems.Add(writeOffItem);
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            int index = listView_WriteOffItem.SelectedItems[0].Index;
            listView_WriteOffItem.Items.RemoveAt(index);
            writeOffItems.RemoveAt(index);
        }

        private void Button_SaveAndExit_Click(object sender, EventArgs e)
        {
            if(writeOffItems.Count != 0)
                WriteOffProducts = new WriteOffProducts(dateTimePicker_WriteOfffDate.Value.ToShortDateString(),
                textBox_MasterName.Text, writeOffItems);


            Close();
        }

        private void WriteOffSetup_Resize(object sender, EventArgs e) =>
            ColumnWidthSetting(listView_WriteOffItem, 75, 25);
    }
}
