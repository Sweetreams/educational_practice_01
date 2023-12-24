using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using WpfApp1.Properties;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> strings = new List<Product>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product(Name_Product.Text, Name_Dic.Text, Convert.ToInt32(Price.Text), Convert.ToDateTime(Shelf_Life_Pro.Text), Convert.ToInt32(Count_Product.Text));
                strings.Add(product);
                ProductList.Items.Add(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Search_Name.IsSelected == true)
            {
                ProductList.Items.Clear();
                foreach (Product product in strings)
                {
                    if (product.Name_Product == Name_search.Text)
                    {

                        ProductList.Items.Add(product);
                    }
                }
            }
            else if (Search_Price.IsSelected == true)
            {
                ProductList.Items.Clear();
                foreach (Product product in strings)
                {
                    if (product.Price_Product == Convert.ToInt32(Name_search.Text))
                    {
                        ProductList.Items.Add(product);
                    }
                }
            }
            else
            {
                MessageBox.Show("Я хз");
            }

        }
        // TODO: Сделать открытие csv-фалйа b и запись данных в product
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
