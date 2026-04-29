using HL.Core.Common;
using System.Linq.Expressions;

namespace HL.Core.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity

{
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    IQueryable<T> Where(Expression<Func<T, bool>> predicate);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);

}
