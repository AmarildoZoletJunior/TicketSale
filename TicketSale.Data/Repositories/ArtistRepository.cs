using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Data.Repositories
{
    public class ArtistRepository : BaseRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(TicketContext context) : base(context) { }

        public void Update(Artist artist)
        {
            _ticketContext.Artirts.Update(artist);
        }
    }
}
