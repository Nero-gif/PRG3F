using CookieClicker;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CookieClicker;


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameState gameState = new GameState();
        private DispatcherTimer timer;

        vobchod vobchod;



        public MainWindow()
        {
            InitializeComponent();


            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            vobchod vobchod = new vobchod(gameState);
            vobchod.Show();
    }

        private void Timer_Tick(object sender, EventArgs e)
        {
            gameState.Cookies += gameState.CookiesPerSecond;
            txtCookieCount.Text = "" + gameState.Cookies;
            if (gameState.Cookies >= 10)
            {
                c_Image.ImageSource = new BitmapImage(new Uri("pack://application:,,,/roshen.jpg"));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gameState.click();
            txtCookieCount.Text = "" + gameState.Cookies;
            txtTotalClicks.Text = "" + gameState.TotalClicks;
        }
    }
