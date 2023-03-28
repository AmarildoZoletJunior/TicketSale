using TicketSale.Domain.Entities.ArtistHasEventEntity;
using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Entities.GenreHasEventEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IEventRepository : IBaseRepository<Event>
    {
        Task<Event> Update(Event Event);
        Task<ArtistHasEvent> AddArtistToEvent(ArtistHasEvent artistHasEvent);
        Task<GenreHasEvent> AddGenreToEvent(GenreHasEvent genreHasEvent);
    }
}
