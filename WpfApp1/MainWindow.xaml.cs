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
        public List<String> products = new List<String>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product(Name_Product.Text, Name_Dic.Text, Convert.ToInt32(Price.Text), Convert.ToDateTime(Shelf_Life_Pro.Text), Convert.ToInt32(Count_Product.Text));
                this.ProductList.Items.Add(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.ProductList.Items.Clear();
            if (Search_Name.IsSelected == true)
            {
                foreach (Product product in strings)
                {
                    if (product.Name_Product == Name_search.Text)
                    {
                        this.ProductList.Items.Add(product);
                    }
                }
            }

            //Lable_text.Items.Clear();
            //try
            //{
            //    foreach(Product product in strings)
            //    {
            //        if(product.Name_Product == Name_search.Text)
            //        {
            //            Lable_text.Items.Add(product.ToString());
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Я ФУТБОЛЬНЫЙ МЯЧИК");
            //}
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Lable_text.Items.Clear();
            //try
            //{
            //    foreach (Product product in strings)
            //    {
            //        if (product.Price_Product < Convert.ToInt32(Name_price_s.Text))
            //        {
            //            Lable_text.Items.Add(product.ToString());
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Я ФУТБОЛЬНЫЙ МЯЧИК");
            //}

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //Lable_text.Items.Clear();
            //try
            //{
            //    foreach (Product product in strings)
            //    {
            //        if (Convert.ToInt32(product.Shelf_Life) > Convert.ToInt32(Name_shelf_life.Text))
            //        {
            //            Lable_text.Items.Add(product.ToString());
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Я ФУТБОЛЬНЫЙ МЯЧИК");
            //}
        }
    }
}
