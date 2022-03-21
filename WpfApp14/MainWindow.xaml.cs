using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "chery",
                Price = 1504.54,
                Image = "Data/chery.jpg",
                Categorys = Categorys.Food
            });
            products.Add(new Product()
            {
                Name = "cake",
                Price = 869.99,
                Image = "Data/cake.jpg",
                Categorys = Categorys.Food
            });
            products.Add(new Product()
            {
                Name = "cola",
                Price = 987.54,
                Image = "Data/cola.jpg",
                Categorys = Categorys.Food
            });
            products.Add(new Product()
            {
                Name = "hairdryer",
                Price = 3694.99,
                Image = "Data/fen.jpg",
                Categorys = Categorys.Applaince
            });
            lstBox.ItemsSource = products;

        }
        
    }
}
