using onlineShop.Model;
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
	/// Interaction logic for Termek2UC.xaml
	/// </summary>
	public partial class Termek2UC : UserControl
	{
		public Termek2UC()
		{
			InitializeComponent();
			List<Termek> termekekkk = new List<Termek>();
			termekekkk.Add(new Termek("Termék 1", 19.99, 1));
			termekekkk.Add(new Termek("Termék 2", 29.99, 101));
			termekekkk.Add(new Termek("Termék 3", 165.99, 40));
			termekekkk.Add(new Termek("Termék 4", 9.99, 110));
			GenerateTermek(termekekkk);
		}

		private void GenerateTermek(List<Termek> termekekkk)
		{
			foreach (var item in termekekkk)
			{
				var stackPanel = new StackPanel();
				stackPanel.
				var nevTextBlock = new TextBlock() { Text = item.Nev };
				var arTextBlock = new TextBlock() { Text = item.Ar.ToString("C") };
				var raktarKeszletTextBlock = new TextBlock() { Text = $"Raktárkészlet: {item.RaktarKeszlet}" };
				stackPanel.Children.Add(nevTextBlock);
				stackPanel.Children.Add(arTextBlock);
				stackPanel.Children.Add(raktarKeszletTextBlock);
				termek2UC_UGrid.Children.Add(stackPanel);
			}
			
		}
	}
}
