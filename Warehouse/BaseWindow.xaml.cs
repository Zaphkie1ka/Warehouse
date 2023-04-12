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

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : Window
    {
        string cmbox;
        public BaseWindow(string cmb)
        {
            InitializeComponent();
            cmbox = cmb;
            label1.Content = cmbox;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddingWindow win3 = new AddingWindow();
            win3.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
