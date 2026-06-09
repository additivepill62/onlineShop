namespace onlineShop.Model
{
	internal interface IGenericRepository<T> where T : new()
	{
		List<T> GetAll();

		void Insert(T item);
		void Update(T item);
		void Delete(T item);

	}
}
