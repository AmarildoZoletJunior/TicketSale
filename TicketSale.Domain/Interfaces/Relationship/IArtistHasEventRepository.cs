using TicketSale.Domain.Entities.ArtistHasEventEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces.Relationship
{
    public interface IArtistHasEventRepository : IBaseRepository<ArtistHasEvent>
    {
        Task<int> Delete(int artistId, int eventId);
        Task<int> Update(int artistId, int eventId);
    }
}
