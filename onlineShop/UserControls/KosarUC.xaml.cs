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
	/// Interaction logic for KosarUC.xaml
	/// </summary>
	public partial class KosarUC : UserControl
	{
		public KosarUC()
		{
			InitializeComponent();
			KosarBetoltes(); 
		}

		private void KosarBetoltes()
		{
			var termekek = DatabaseService.Instance.GetKosar(1); // Betölti a kosár tartalmát a memóriába
			MessageBox.Show($"A kosárban {termekek.Count} termék van.");
			TermekLista3.ItemsSource = termekek;
			
		}


		private void torlesBTN_Click(object sender, RoutedEventArgs e)
		{
			
			//DatabaseService.Instance.KosarbolTorles();
		}
	}
}
