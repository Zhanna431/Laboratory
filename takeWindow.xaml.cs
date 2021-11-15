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
using System.Windows.Shapes;

namespace Laboratory
{
    /// <summary>
    /// Логика взаимодействия для takeWindow.xaml
    /// </summary>
    public partial class takeWindow : Window
    {
        public takeWindow()
        {
            InitializeComponent();
        }
        private void Button_Home_Click(object sender, RoutedEventArgs e)
        {
            loginWindow loginWindow = new loginWindow();
            loginWindow.Show();
        }
    }
}
