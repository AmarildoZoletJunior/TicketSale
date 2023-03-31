using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.CrossCutting.Paged;
using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Entities.Base;

namespace TicketSale.Domain.Interfaces.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<int> Create(T entity);
        Task<T> FindByIdAsync(int id);
        Task<IEnumerable<T>> GetAllPaged(PagedParameters parameters);
    }
}
