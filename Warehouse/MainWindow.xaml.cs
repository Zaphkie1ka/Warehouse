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

namespace Warehouse
{
    public partial class MainWindow : Window
    {
        public string cmb;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "123456" || combo1.Text != "Администратор")
            {
                MessageBox.Show("Неправильный логин или пароль!");
            }
            else if (textbox1.Text != "123456" || combo1.Text != "Администратор")
            {

            }
            else
            {
                cmb = combo1.Text;
                BaseWindow win2 = new BaseWindow(cmb);
                win2.Show();
                this.Close();
            }
            }
        }
    }
}
