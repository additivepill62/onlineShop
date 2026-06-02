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

namespace onlineShop
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

		private void termektipus1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			UCSpace.Children.Clear();
			UCSpace.Children.Add(new UserControls.Termek1UC());
		}

		private void termektipus2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			UCSpace.Children.Clear();
			UCSpace.Children.Add(new UserControls.Termek2UC());
		}

		private void termektipus3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{

		}
	}
}