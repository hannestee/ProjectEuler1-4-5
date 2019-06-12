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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FirstProblem.IsChecked == true)
            {
                Window1 subWindow = new Window1();
                subWindow.Show();
            }
            else if (SecondProblem.IsChecked == true)
            {
                Window2 subWindow = new Window2();
                subWindow.Show();
            }
            else if (ThirdProblem.IsChecked == true)
            {
                Window3 subWindow = new Window3();
                subWindow.Show();
            }
        }

    }
}
