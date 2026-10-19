using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormOnlineShop_2026
{
    public partial class FormBasket : Form
    {
        public FormBasket()
        {
            InitializeComponent();
        }

        private void FormBasket_Load(object sender, EventArgs e)
        {

        }

        private void deleteChosenItems()
        {
            for (int i = checkedListBoxBasketItems.CheckedIndices.Count - 1; i >= 0; i--)
            {
                int index = checkedListBoxBasketItems.CheckedIndices[i];
                checkedListBoxBasketItems.Items.RemoveAt(index);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            deleteChosenItems();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string confirmeditems = "";
            foreach (var item in checkedListBoxBasketItems.CheckedItems)
            {
                confirmeditems += item.ToString() + "\n";
            }
            MessageBox.Show($"Ваш заказ: \n {confirmeditems}","", MessageBoxButtons.OK);
            if (checkedListBoxBasketItems.CheckedIndices != null)
            {
                deleteChosenItems();
            }
        }
    }
}
