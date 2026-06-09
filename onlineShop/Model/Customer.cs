using SQLite;

namespace onlineShop.Model
{
    /// <summary>
    /// Vevő modell.
   
    /// Az OrderHistory vesszővel elválasztott string-ként van tárolva,
    /// a property-k kezelik a konverziót.
    /// </summary>
    [Table("Customers")]
    public class Customer
    {
        public Customer() { }

        public Customer(string name, string email, string password,
                        string address, string city, string country,
                        int loyaltyPoints = 0)
        {
            Name          = name;
            Email         = email;
            Password      = password;
            Address       = address;
            City          = city;
            Country       = country;
            LoyaltyPoints = loyaltyPoints;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; } = string.Empty;

        [Unique]
        public string Email { get; set; } = string.Empty;

        public string Password      { get; set; } = string.Empty;
        public string Address       { get; set; } = string.Empty;
        public string City          { get; set; } = string.Empty;
        public string Country       { get; set; } = string.Empty;
        public int    LoyaltyPoints { get; set; }

        
        /// SQLite-ban tárolt string: "rendelés1,rendelés2,rendelés3"
        
        public string OrderHistoryRaw { get; set; } = string.Empty;

        
        
        /// Az adatbázisban OrderHistoryRaw-ként van tárolva.
        
        [Ignore]
        public List<string> OrderHistory
        {
            get => string.IsNullOrEmpty(OrderHistoryRaw)
                   ? new List<string>()
                   : new List<string>(OrderHistoryRaw.Split(','));
            set => OrderHistoryRaw = string.Join(",", value);
        }
    }
}
