using SQLite;

namespace onlineShop.Model
{
    [Table("Kosar")]
    public class Kosar
    {
        public Kosar() { }

        public Kosar(int customerId, int productId, int quantity)
        {
            CustomerId = customerId;
            ProductId  = productId;
            Quantity   = quantity;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public int ProductId  { get; set; }
        public int Quantity   { get; set; }
    }
}
