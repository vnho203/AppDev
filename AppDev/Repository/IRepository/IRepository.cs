using AppDev.Data;
using System.Linq.Expressions;

namespace AppDev.Repository.IRepository
{
	public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		T Get(Expression<Func<T, bool>> filter);
		void Add(T entity);

		void Delete(T entity);
		void Save();
	}
}
