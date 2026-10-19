using OnlineShop;
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
        public Catalog catalogbasket = new Catalog();
        public FormBasket()
        {
            InitializeComponent();
        }

        private void FormBasket_Load(object sender, EventArgs e)
        {

        }
        private void RecalculateCost()
        {
            decimal cost = 0;
            foreach (var item in checkedListBoxBasketItems.CheckedItems)
            {
                foreach (Product product in catalogbasket.getAll())
                {
                    if (item.ToString() == product.Name)
                    {
                        cost += product.Price;
                        break;
                    }
                }
            }
            labelPrice.Text = $"Стоимость: {cost}";
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
            if (checkedListBoxBasketItems.CheckedIndices != null)
            {
                deleteChosenItems();
                RecalculateCost();
            }
            else
            {
                MessageBox.Show($"Выберете товар!", "", MessageBoxButtons.OK);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string confirmeditems = "";
            if (checkedListBoxBasketItems.CheckedIndices != null)
            {
                foreach (var item in checkedListBoxBasketItems.CheckedItems)
                {
                    confirmeditems += item.ToString() + "\n";
                }
                MessageBox.Show($"Ваш заказ: \n {confirmeditems} " , "", MessageBoxButtons.OK);
                deleteChosenItems();
                RecalculateCost() ;
            }
            else
            {
                MessageBox.Show($"Выберете товар!", "", MessageBoxButtons.OK);
            }
        }

        private void checkedListBoxBasketItems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            decimal cost = 0;

            for (int i = 0; i < checkedListBoxBasketItems.Items.Count; i++)
            {
                bool isChecked = false;
                if (i == e.Index)
                    isChecked = (e.NewValue == CheckState.Checked);
                else
                    isChecked = checkedListBoxBasketItems.GetItemChecked(i);

                if (!isChecked) continue;

                string itemName = checkedListBoxBasketItems.Items[i].ToString();
                foreach (Product product in catalogbasket.getAll())
                {
                    if (itemName == product.Name)
                    {
                        cost += product.Price;
                        break;
                    }
                }
            }

            labelPrice.Text = $"Стоимость: {cost}";
        }
    }
}
