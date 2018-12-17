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

namespace OnlineShop
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

        private void btnPaint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("herra");
        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hurra");
        }

        private void btnTassel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("lfg;ls");
        }
    }
}
