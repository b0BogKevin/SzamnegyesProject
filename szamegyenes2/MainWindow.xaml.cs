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

namespace szamegyenes2
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

        private void A_Click(object sender, RoutedEventArgs ea)
        {
            a.Text = (Convert.ToInt32(a.Text) + 1).ToString();
            b.Text = (Convert.ToInt32(b.Text) + 1).ToString();
            d.Text = (Convert.ToInt32(d.Text) + 1).ToString();
            e.Text = (Convert.ToInt32(e.Text) + 1).ToString();

        }

        private void B_Click(object sender, RoutedEventArgs ea)
        {
            b.Text = (Convert.ToInt32(b.Text) + 1).ToString();
            c.Text = (Convert.ToInt32(c.Text) + 1).ToString();
            e.Text = (Convert.ToInt32(e.Text) + 1).ToString();
            f.Text = (Convert.ToInt32(f.Text) + 1).ToString();
        }

        private void C_Click(object sender, RoutedEventArgs ea)
        {
            d.Text = (Convert.ToInt32(d.Text) + 1).ToString();
            e.Text = (Convert.ToInt32(e.Text) + 1).ToString();
            g.Text = (Convert.ToInt32(g.Text) + 1).ToString();
            h.Text = (Convert.ToInt32(h.Text) + 1).ToString();
        }

        private void D_Click(object sender, RoutedEventArgs ea)
        {
            e.Text = (Convert.ToInt32(e.Text) + 1).ToString();
            f.Text = (Convert.ToInt32(f.Text) + 1).ToString();
            h.Text = (Convert.ToInt32(h.Text) + 1).ToString();
            i.Text = (Convert.ToInt32(i.Text) + 1).ToString();
        }
        private void nulla_Click(object sender, RoutedEventArgs ea)
        {
            a.Text = "0";
            b.Text = "0";
            c.Text = "0";
            d.Text = "0";
            e.Text = "0";
            f.Text = "0";
            g.Text = "0";
            h.Text = "0";
            i.Text = "0";

        }
    }
}