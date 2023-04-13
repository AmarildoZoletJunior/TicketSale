using TicketSale.Domain.Entities.GenreEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IGenreRepository : IBaseRepository<Genre>
    {
        public void Update(Genre genre);
    }
}
