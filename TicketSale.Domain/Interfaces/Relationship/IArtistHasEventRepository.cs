using TicketSale.Domain.Entities.Relationship.ArtistHasEventEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces.Relationship
{
    public interface IArtistHasEventRepository
    {
        public void Delete(int artistId, int eventId);
        public void Create(ArtistHasEvent artist);
    }
}
