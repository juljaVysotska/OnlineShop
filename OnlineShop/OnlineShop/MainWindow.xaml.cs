
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace OnlineShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Image img1;
        public TextBox UsernameBox, PassBox;
        public static MainWindow rindows;

        public string GetUsername()
        {
            return UsernameBox.Text;
        }

        public string GetPassword()
        {
            return PassBox.Text;
        }

        public MainWindow()
        {
            InitializeComponent();
            rindows = this;

            UsernameBox = txtBoxLogIn;
            PassBox = txtBoxPass;
            img1 = image1;
           // img1 = System.Drawing.Image.FromFile("/img/paint.jpg");

            Globals.instance = new Globals();
            Globals.network.Start();
            
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

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Globals.clientSendData.SendLogin(UsernameBox.Text, PassBox.Text);
            login(1);
        }

        public void login(int i)
        {
            if (i == 1)
            {
                Thread.Sleep(1000);
                navBar.Visibility = Visibility.Visible;
                canvaMain.Visibility = Visibility.Visible;
                logInCanva.Visibility = Visibility.Collapsed;
            }
        }

        private void btnRegistry_Click(object sender, RoutedEventArgs e)
        {
            Globals.clientSendData.SendNewAccount(UsernameBox.Text, PassBox.Text);
        }
    }
}
