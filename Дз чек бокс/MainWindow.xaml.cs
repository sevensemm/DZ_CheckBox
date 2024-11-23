using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;

namespace Дз_чек_бокс
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            delet.IsChecked = true;
            Install.IsChecked = false;

            string imagePath = "C:\\Users\\dalio\\source\\repos\\Дз чек бокс\\Дз чек бокс\\images\\getero.jpg";         
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;      
        }

        private void Install_Checked(object sender, RoutedEventArgs e)
        {
            delet.IsChecked = false;

            string imagePath = "C:\\Users\\dalio\\source\\repos\\Дз чек бокс\\Дз чек бокс\\images\\LGBT.jpeg";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;
        }
    }
}
