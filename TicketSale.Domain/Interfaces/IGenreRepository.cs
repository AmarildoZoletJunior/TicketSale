using TicketSale.Domain.Entities.GenreEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IGenreRepository : IBaseRepository<Genre>
    {
        Task<Genre> Update(Genre genre);
    }
}
