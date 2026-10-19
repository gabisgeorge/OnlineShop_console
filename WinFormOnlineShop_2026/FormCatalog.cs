using OnlineShop;

namespace WinFormOnlineShop_2026
{
    public partial class FormCatalog : Form
    {
        Catalog catalog = new Catalog();
        FormBasket formBasket = new FormBasket();
        public FormCatalog()
        {
            InitializeComponent();
            catalog.Add(new Product("Вертолет", 100, "игрушка веселая"));
            catalog.Add(new Product("Майка", 1005, "с принтом"));
            catalog.Add(new Product("Тапки", 250, "пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "по информатике"));
            ShowCatalog();
        }

        void ShowCatalog()
        {
            //int i = 0;
            foreach (Product product in catalog.getAll())
                listBoxCatalog.Items.Add($"{product.Name}");
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelProductName.Text = listBoxCatalog.SelectedItem.ToString();
            foreach (Product product in catalog.getAll())
            {
                if (listBoxCatalog.SelectedItem.ToString() == product.Name)
                {
                    labelDescription.Text = product.Description;
                    labelDescription.Text += "\n" + product.Price + " рублей";
                }
            }
        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            formBasket.Show();
            if (listBoxCatalog.SelectedItem != null)
            {
                formBasket.checkedListBoxBasketItems.Items.Add(listBoxCatalog.SelectedItem);
                foreach (Product product in catalog.getAll())
                {
                    if (listBoxCatalog.SelectedItem.ToString() == product.Name)
                    {
                        formBasket.catalogbasket.Add(product);
                    }
                }
            }
        }
    }
}
