using onlineShop.Model;
using SQLite;
using System.IO;

namespace onlineShop.Services
{
    /// <summary>
    /// SQLite adatbázis-kezelő osztály – Singleton minta.
    ///
    /// HASZNÁLAT:
    ///     DatabaseService.Instance.GetTermekek()
    ///     DatabaseService.Instance.KosarbaAd(termekId, mennyiseg)
    ///     stb.
    ///
    /// Az adatbázis fájl az alkalmazás mellé kerül: onlineShop.db
    /// </summary>
    public class DatabaseService
    {
        // ── Singleton ────────────────────────────────────────────────────────
        private static DatabaseService? _instance;
        public static DatabaseService Instance => _instance ??= new DatabaseService();

        // ── SQLite kapcsolat ─────────────────────────────────────────────────
        private readonly SQLiteConnection _db;

        private DatabaseService()
        {
            string dbPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "onlineShop.db");

            _db = new SQLiteConnection(dbPath);
            InitializeTables();
            SeedIfEmpty();
        }

        // ── Táblák létrehozása ───────────────────────────────────────────────
        private void InitializeTables()
        {
            _db.CreateTable<Termek>();
            _db.CreateTable<Customer>();
            _db.CreateTable<Kosar>();
        }

        // ── Alap adatok betöltése (csak ha üres az adatbázis) ───────────────
        private void SeedIfEmpty()
        {
            if (_db.Table<Termek>().Count() > 0) return;

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

            _db.InsertAll(termekek);
        }

        // ════════════════════════════════════════════════════════════════════
        // TERMÉK MŰVELETEK
        // ════════════════════════════════════════════════════════════════════

        /// <summary>Összes termék lekérése.</summary>
        public List<Termek> GetTermekek()
            => _db.Table<Termek>().ToList();

        /// <summary>Egy termék lekérése Id alapján.</summary>
        public Termek? GetTermek(int id)
            => _db.Find<Termek>(id);

        /// <summary>Új termék hozzáadása.</summary>
        public void AddTermek(Termek termek)
            => _db.Insert(termek);

        /// <summary>Termék módosítása.</summary>
        public void UpdateTermek(Termek termek)
            => _db.Update(termek);

        /// <summary>Termék törlése.</summary>
        public void DeleteTermek(int id)
            => _db.Delete<Termek>(id);

        // ════════════════════════════════════════════════════════════════════
        // KOSÁR MŰVELETEK
        // ════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Terméket ad a kosárhoz.
        /// Ha már szerepel, növeli a mennyiséget.
        /// </summary>
        public void KosarbaAd(int customerId, int termekId, int mennyiseg = 1)
        {
            var meglevo = _db.Table<Kosar>()
                             .FirstOrDefault(k => k.CustomerId == customerId
                                               && k.ProductId  == termekId);
            if (meglevo != null)
            {
                meglevo.Quantity += mennyiseg;
                _db.Update(meglevo);
            }
            else
            {
                _db.Insert(new Kosar(customerId, termekId, mennyiseg));
            }
        }

        /// <summary>Egy vevő kosarának lekérése.</summary>
        public List<Kosar> GetKosar(int customerId)
            => _db.Table<Kosar>()
                  .Where(k => k.CustomerId == customerId)
                  .ToList();

        /// <summary>Egy tétel törlése a kosárból.</summary>
        public void KosarbolTorles(int kosarId)
            => _db.Delete<Kosar>(kosarId);

        /// <summary>Teljes kosár kiürítése.</summary>
        public void KosarUrites(int customerId)
        {
            var tetelek = GetKosar(customerId);
            foreach (var t in tetelek)
                _db.Delete<Kosar>(t.Id);
        }

        // ════════════════════════════════════════════════════════════════════
        // CUSTOMER MŰVELETEK
        // ════════════════════════════════════════════════════════════════════

        public List<Customer> GetCustomers()
            => _db.Table<Customer>().ToList();

        public Customer? GetCustomer(int id)
            => _db.Find<Customer>(id);

        public void AddCustomer(Customer customer)
            => _db.Insert(customer);

        public void UpdateCustomer(Customer customer)
            => _db.Update(customer);

        public void DeleteCustomer(int id)
            => _db.Delete<Customer>(id);
    }
}
