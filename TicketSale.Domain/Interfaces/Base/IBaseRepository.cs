using TicketSale.CrossCutting.Paged;

namespace TicketSale.Domain.Interfaces.Base
{
    public interface IBaseRepository<T> where T : class
    {
        public Task Create(T entity);
        Task<T> FindByIdAsync(int id);
        Task<IEnumerable<T>> GetAllPaged(PagedParameters parameters);
    }
}
