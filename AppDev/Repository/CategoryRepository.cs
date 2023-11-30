using AppDev.Data;
using AppDev.Models;
using AppDev.Repository.IRepository;

namespace AppDev.Repository
{
	public class CategoryRepository : Repository<Category>, ICategoryRepository
	{
		private readonly ApplicationDBContext _dbContext;
		public CategoryRepository(ApplicationDBContext dBContext) : base(dBContext)
		{
			_dbContext = dBContext;
		}
		public void Update(Category entity)
		{
			_dbContext.Categories.Update(entity);
		}
	}
}
