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
            Paint();
        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            Paper();
        }

        private void btnTassel_Click(object sender, RoutedEventArgs e)
        {
            Tassel();
        }

        
        private void mainPaintBtn_Click(object sender, RoutedEventArgs e)
        {
            Paint();
        }

        private void mainPaperBtn_Click(object sender, RoutedEventArgs e)
        {
            Paper();
        }

       

        private void mainTasselBtn_Click(object sender, RoutedEventArgs e)
        {
            Tassel();
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
    }
}
