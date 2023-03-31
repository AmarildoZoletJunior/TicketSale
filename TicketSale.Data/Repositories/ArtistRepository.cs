using TicketSale.Data.Context;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Data.Repositories
{
    public class ArtistRepository : BaseRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(TicketContext context) : base(context) { }

        public async Task<int> Update(Artist artist)
        {
            _ticketContext.Artirts.Update(artist);
           var rows =  await _ticketContext.SaveChangesAsync();
            return rows;
        }
    }
}
