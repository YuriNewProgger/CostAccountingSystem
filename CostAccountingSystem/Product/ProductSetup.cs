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
using System.Xml.Serialization;

namespace CostAccountingSystem
{
    public partial class ProductSetup : Form
    {
        public Product Product { get; set; }


        public ProductSetup()
        {
            InitializeComponent();
            
            numericUpDown_Splitting.Enabled = false;
            comboBox_Measures.Enabled = false;
        }

        private void Button_Cancel_Click(object sender, EventArgs e) =>
            Close();

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if(textBox_ProductName.Text.Length == 0 || textBox_limit.Text.Length == 0)
            {
                MessageBox.Show("Заполните обязательные поля название и предел предупреждения", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (checkBox_Splitting.Checked)
            {
                Product = new Product(
                textBox_ProductName.Text,
                richTextBox_Discription.Text,
                int.Parse(numericUpDown_Splitting.Value.ToString()),
                comboBox_Measures.SelectedItem.ToString(),
                int.Parse(textBox_limit.Text));
                
                Close();
            }
            else
            {
                Product = new Product
                {
                    Name = textBox_ProductName.Text,
                    Discription = richTextBox_Discription.Text,
                    Limit = int.Parse(textBox_limit.Text)
                };
                
                Close();
            }
        }

        private void CheckBox_Splitting_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_Splitting.Enabled = checkBox_Splitting.Checked;
            comboBox_Measures.Enabled = checkBox_Splitting.Checked;
        }
        
    }
}
