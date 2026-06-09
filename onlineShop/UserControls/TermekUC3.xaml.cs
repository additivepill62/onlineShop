using onlineShop.Model;
using onlineShop.Services;
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

namespace onlineShop.UserControls
{
	/// <summary>
	/// Interaction logic for TermekUC3.xaml
	/// </summary>
	public partial class TermekUC3 : UserControl
	{
		public TermekUC3()
		{
			InitializeComponent();

			
		}

		

		private void KosarBTN_Click(object sender, RoutedEventArgs e)
		{
			if (sender is Button btn && btn.Tag is Termek termek)
			{
				DatabaseService.Instance.KosarbaAd(termek.Id, 1); // 1 darabot adunk a kosárhoz
				MessageBox.Show($"{termek.Nev} hozzáadva a kosárhoz!");
			}
		}
	}
}
