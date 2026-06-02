using SQLite;

namespace onlineShop.Model
{
	public class Customer
	{
		public Customer()
		{ }


		[PrimaryKey, AutoIncrement]	
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public int LoyaltyPoints { get; set; }
		public List<string> OrderHistory { get; set; } = new List<string>();

		public Customer(List<string> orderhistory, string name, string email, string password, string address, string city, string country, int loyaltyPoints)
		{
			OrderHistory = orderhistory;
			Name = name;
			Email = email;
			Password = password;
			Address = address;
			City = city;
			Country = country;
			LoyaltyPoints = loyaltyPoints;
		}
		
		}
}
