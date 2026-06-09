using SQLite;

namespace onlineShop.Model
{
    /// <summary>
    /// Termék modell – SQLite táblává képezhető.
    /// KategoriaId: melyik menüponthoz tartozik a termék (1, 2, 3...).
    /// </summary>
    [Table("Termekek")]
    public class Termek
    {
        public Termek() { }

        public Termek(string nev, double ar, int raktarKeszlet, int kategoriaId = 1)
        {
            Nev = nev;
            Ar = ar;
            RaktarKeszlet = raktarKeszlet;
            KategoriaId = kategoriaId;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Nev { get; set; } = string.Empty;

        public double Ar { get; set; }

        public int RaktarKeszlet { get; set; }

        
        /// Melyik kategóriához (menüponthoz) tartozik a termék.
        /// 1 = 'Termék típus 1', 2 = 'Termék típus 2', stb.
        
        public int KategoriaId { get; set; } = 1;
    }
}
