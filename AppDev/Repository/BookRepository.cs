using AppDev.Data;
using AppDev.Models;
using AppDev.Repository.IRepository;

namespace AppDev.Repository
{
	public class BookRepository : Repository<Book>, IBookRepository
	{
		private readonly ApplicationDBContext _dbContext;
		public BookRepository(ApplicationDBContext dBContext) : base(dBContext)
		{
			_dbContext = dBContext;
		}

		public void Update(Book entity)
		{
			_dbContext.Books.Update(entity);
		}
	}
}
