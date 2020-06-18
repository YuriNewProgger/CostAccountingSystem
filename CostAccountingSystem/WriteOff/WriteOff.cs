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
    partial class WriteOff : Form
    {
        public Widthcolumn ColumnWidthSetting;

        public WriteOffProducts WriteOffProducts { get; set; }
        public List<WriteOffItem> WriteOffItems { get; set; }
        
        public List<WriteOffProducts> listWriteOffProducts = new List<WriteOffProducts>();
        
        public WriteOff(Widthcolumn setting)
        {
            InitializeComponent();

            ColumnWidthSetting = setting;
        }

        private void WriteOff_Load(object sender, EventArgs e)
        {
            ColumnWidthSetting(listView_WriteOff, 25, 25, 50);

            if (File.Exists("writeOff.xml"))
            {
                listWriteOffProducts = XElement.Load("writeOff.xml")
                    .Elements("writeOff")
                    .Select(i => WriteOffProducts.FromXml(i))
                    .ToList();

                CreateListViewItem();
            }
            
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            WriteOffSetup writeOffSetup = new WriteOffSetup(ColumnWidthSetting);
            writeOffSetup.ShowDialog();
            WriteOffProducts = writeOffSetup.WriteOffProducts;

            if (WriteOffProducts == null)
                return;

            listView_WriteOff.Items.Clear();
            

            listWriteOffProducts.Add(WriteOffProducts);
            
            CreateListViewItem();
        }
        
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (listView_WriteOff.SelectedItems.Count == 0)
            {
                MessageBox.Show("Списание не выбрано", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Удалить списание за: {listView_WriteOff.SelectedItems[0].Text}?", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                == DialogResult.OK)
            {
                int index = listView_WriteOff.SelectedItems[0].Index;
                listView_WriteOff.Items.RemoveAt(index);
                listWriteOffProducts.RemoveAt(index);
            }

            
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            if(listView_WriteOff.SelectedItems.Count == 0)
            {
                MessageBox.Show("Списание не выбрано", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            WriteOffProducts = (WriteOffProducts)listView_WriteOff.SelectedItems[0].Tag;

            WriteOffSetup writeOffSetup = new WriteOffSetup(WriteOffProducts, ColumnWidthSetting);
            writeOffSetup.ShowDialog();
            WriteOffProducts = writeOffSetup.WriteOffProducts;
            
            listView_WriteOff.Items.Clear();

            CreateListViewItem();
        }

        private void Button_ReturnToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();

            XElement root = new XElement("writeOffProducts",
                from b in listWriteOffProducts
                select b.ToXml());

            root.Save("writeOff.xml");
        }

        private void WriteOff_Resize(object sender, EventArgs e) =>
            ColumnWidthSetting(listView_WriteOff, 25, 25, 50);


        private void CreateListViewItem()
        {
            foreach (WriteOffProducts writeOffProducts in listWriteOffProducts)
            {
                string lineForListView = "";
                foreach (WriteOffItem writeOffItem in writeOffProducts.writeOffItems)
                    lineForListView += $"{writeOffItem.Product.Name}-{writeOffItem.Count}{writeOffItem.Product.Measures};";

                ListViewItem item = new ListViewItem(writeOffProducts.DateWriteOff);
                item.SubItems.Add(writeOffProducts.MasterName);
                item.SubItems.Add(lineForListView);
                item.Tag = writeOffProducts;

                listView_WriteOff.Items.Add(item);
            }

        }

        
    }
}
