using TicketSale.Domain.Entities.GenreHasEventEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces.Relationship
{
    public interface IGenreHasEventRepository : IBaseRepository<GenreHasEvent>
    {
        Task<int> Delete(int genreId, int eventId);

        Task<int> Update(int genreId, int eventId);
    }
}
