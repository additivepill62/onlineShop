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
using System.Windows.Shapes;

namespace onlineShop
{
	/// <summary>
	/// Interaction logic for KosarWindow.xaml
	/// </summary>
	public partial class KosarWindow : Window
	{
		public KosarWindow()
		{
			InitializeComponent();
			UCSpace.Children.Clear();
			UCSpace.Children.Add(new UserControls.KosarUC());
		}

		private void VisszaBTN_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
        }
    }
}
