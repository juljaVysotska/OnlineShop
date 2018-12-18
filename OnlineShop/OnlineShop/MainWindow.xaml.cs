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
            canvaMain.Visibility = Visibility.Collapsed;
            canvaTemplate.Visibility = Visibility.Visible;
            canvaCart.Visibility = Visibility.Collapsed;
        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            canvaMain.Visibility = Visibility.Collapsed;
            canvaTemplate.Visibility = Visibility.Visible;
            canvaCart.Visibility = Visibility.Collapsed;
        }

        private void btnTassel_Click(object sender, RoutedEventArgs e)
        {
            canvaMain.Visibility = Visibility.Collapsed;
            canvaTemplate.Visibility = Visibility.Visible;
            canvaCart.Visibility = Visibility.Collapsed;
        }

        
        private void mainPaintBtn_Click(object sender, RoutedEventArgs e)
        {
            canvaMain.Visibility = Visibility.Collapsed;
            canvaTemplate.Visibility = Visibility.Visible;
            canvaCart.Visibility = Visibility.Collapsed;
        }

        private void mainPaperBtn_Click(object sender, RoutedEventArgs e)
        {
            canvaMain.Visibility = Visibility.Collapsed;
            canvaTemplate.Visibility = Visibility.Visible;
            canvaCart.Visibility = Visibility.Collapsed;
        }

       

        private void mainTasselBtn_Click(object sender, RoutedEventArgs e)
        {
            canvaMain.Visibility = Visibility.Collapsed;
            canvaTemplate.Visibility = Visibility.Visible;
            canvaCart.Visibility = Visibility.Collapsed;
        }

        void Paint()
        {
            MessageBox.Show("Paint");
        }

        void Paper()
        {
            MessageBox.Show("Paper");
        }

        void Tassel()
        {
            MessageBox.Show("Tassel");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

      

        private void logo_Click(object sender, RoutedEventArgs e)
        {
            canvaMain.Visibility = Visibility.Visible;
            canvaTemplate.Visibility = Visibility.Collapsed;

            canvaCart.Visibility = Visibility.Collapsed;
        }

        private void btnCart_Click(object sender, RoutedEventArgs e)
        {

            canvaMain.Visibility = Visibility.Collapsed;
            canvaTemplate.Visibility = Visibility.Collapsed;
            canvaCart.Visibility = Visibility.Visible;
        }
    }
}
