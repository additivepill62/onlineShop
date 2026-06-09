using System.Windows;
using System.Windows.Input;

namespace onlineShop
{
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
            // Ide jön majd a 3. kategória UC-ja
        }

        private void mainWKosarBTN_Click(object sender, RoutedEventArgs e)
        {
            Window kosarWindow = new KosarWindow();
            kosarWindow.ShowDialog();
        }
    }
}
