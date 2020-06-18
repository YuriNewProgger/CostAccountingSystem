using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostAccountingSystem
{
    public delegate void Widthcolumn(ListView listView, params int[] width);

    public partial class MainMenu : Form
    {
        public Widthcolumn Setting { get; set; }

        public MainMenu()
        {
            InitializeComponent();

            Setting = ColumnWidthSetting;
        }

        private void Button_Exit_Click(object sender, EventArgs e) =>
            Application.Exit();

        private void Button_Goods_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods(Setting);
            goods.Show();
            Hide();
        }

        private void Button_Purchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase(Setting);
            purchase.Show();
            Hide();
        }

        private void Button_WriteOff_Click(object sender, EventArgs e)
        {
            WriteOff writeOff = new WriteOff(Setting);
            writeOff.Show();
            Hide();
        }

        private void Button_LeftOvers_Click(object sender, EventArgs e)
        {
            Leftovers warehouse = new Leftovers(Setting);
            warehouse.Show();
            Hide();
        }


        private void Button_Inventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный функционал не работает в демо версии", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void ColumnWidthSetting(ListView listView, params int[] columnWidthPercent)
        {
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                listView.Columns[i].Width = listView.Width * columnWidthPercent[i] / 100;
            }
        }
        
    }
}
