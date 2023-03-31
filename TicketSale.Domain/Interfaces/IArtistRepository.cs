using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Entities.ArtistHasGenreEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IArtistRepository : IBaseRepository<Artist>
    {
        Task<int> Update(Artist artist);
    }
}
