using onlineShop.Model;
using onlineShop.Services;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace onlineShop.UserControls
{
    
    ///  ha RaktarKeszlet == 0, piros szöveg, egyébként fekete.
    
    public class KeszletColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int keszlet && keszlet == 0)
                return Brushes.Red;
            return Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }

    
    public partial class Termek1UC : UserControl
    {
        public Termek1UC()
        {
            InitializeComponent();
            BetoltTermekek();
        }

        private void BetoltTermekek()
        {
            
            var termekek = new List<Termek>
            {
                new Termek("Szöveg 1",  432.00,   50),
                new Termek("Szöveg 2",  43232.00,  5),
                new Termek("Szöveg 3",  4.00,      0),
                new Termek("Szöveg 4",  42.00,     12),
                new Termek("Szöveg 5",  1000.00,   3),
                new Termek("Szöveg 6",  43211.00,  99),
                new Termek("Szöveg 7",  4321.00,   7),
                new Termek("Szöveg 8",  7.00,      0),
                new Termek("Szöveg 9",  89.00,     21),
            };

            TermekLista.ItemsSource = termekek;
        }

        
        private void KosarBTN_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag is Termek termek)
            {
                // TODO: DatabaseService.Instance.KosarbaAd(termek.Id, mennyiseg: 1);
                MessageBox.Show($"{termek.Nev} hozzáadva a kosárhoz!");
            }
        }
    }
}
