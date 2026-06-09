using onlineShop.Model;
using onlineShop.Services;
using System.Windows;
using System.Windows.Controls;

namespace onlineShop.UserControls
{
    
    public partial class Termek2UC : UserControl
    {
        public Termek2UC()
        {
            InitializeComponent();
            BetoltTermekek();
        }

        private void BetoltTermekek()
        {
            //var termekek = DatabaseService.Instance.GetTermekek(kategoria: 2);
            var termekek = new List<Termek>
            {
                new Termek("Termék 1",  19.99,      1),
                new Termek("Termék 2",  29.99,    101),
                new Termek("Termék 3",  165.99,    40),
                new Termek("Termék 4",  9.99,     110),
                new Termek("Termék 5",  119.99,     0),
                new Termek("Termék 6",  0.99,   53253),
                new Termek("Termék 7",  113.99,   532),
                new Termek("Termék 8",  1111.99,  265),
                new Termek("Termék 9",  1.99,      75),
                new Termek("Termék 10", 19.49,    764),
                new Termek("Termék 11", 229.99,    14),
                new Termek("Termék 12", 339.99,     0),
                new Termek("Termék 13", 539.99,     0),
                new Termek("Termék 14", 165239.99,  4),
                new Termek("Termék 15", 1142.99,  654),
                new Termek("Termék 16", 11.99,    634),
                new Termek("Termék 17", 1429.99,  213),
            };

            TermekLista2.ItemsSource = termekek;
        }

        private void KosarBTN_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag is Termek termek)
            {
				DatabaseService.Instance.KosarbaAd(termek.Id, 1);
				MessageBox.Show($"{termek.Nev} hozzáadva a kosárhoz!");
            }
        }
    }
}
