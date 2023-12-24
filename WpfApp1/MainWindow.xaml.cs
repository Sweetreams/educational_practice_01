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
        List<String> products = new List<String>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product(Name_Product.Text, Name_Dic.Text, Convert.ToInt32(Price.Text), Shelf_Life_Pro.Text, Convert.ToInt32(Count_Product.Text));
                products.Add($"{product.Name_Product}, {product.Name_Dic}, {product.Price_Product}, {product.Shelf_Life}, {product.Count_Product}");
                strings.Add(product);
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Lable_text.Items.Clear();
            foreach(string s in products)
            {
                Lable_text.Items.Add(s);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Lable_text.Items.Clear();
            try
            {
                foreach(Product product in strings)
                {
                    if(product.Name_Product == Name_search.Text)
                    {
                        Lable_text.Items.Add(product.ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Я ФУТБОЛЬНЫЙ МЯЧИК");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Lable_text.Items.Clear();
            try
            {
                foreach (Product product in strings)
                {
                    if (product.Price_Product < Convert.ToInt32(Name_price_s.Text))
                    {
                        Lable_text.Items.Add(product.ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Я ФУТБОЛЬНЫЙ МЯЧИК");
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Lable_text.Items.Clear();
            try
            {
                foreach (Product product in strings)
                {
                    if (Convert.ToInt32(product.Shelf_Life) > Convert.ToInt32(Name_shelf_life.Text))
                    {
                        Lable_text.Items.Add(product.ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Я ФУТБОЛЬНЫЙ МЯЧИК");
            }
        }
    }
}
