using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IArtistRepository : IBaseRepository<Artist>
    {
        public void Update(Artist artist);
    }
}
