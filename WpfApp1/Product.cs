using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public class Product
    {
        public string a;
        public string Name_Product { get; set; }
        public string Name_Dic { get; set; }
        public int Price_Product { get; set; }
        public DateTime Shelf_Life { get; set; }
        public int Count_Product { get; set; }

        public Product(string name, string dic, int price, DateTime shelf , int count_p)
        {
            Name_Product = name;
            Name_Dic = dic;
            Price_Product = price;
            Shelf_Life = shelf;
            Count_Product = count_p;
        }
        public override string ToString()
        {
            return $"{Name_Product}, {Name_Dic}, {Price_Product}, {Shelf_Life.Day}.{Shelf_Life.Month}.{Shelf_Life.Year} , {Count_Product}";
        }
    }
}
