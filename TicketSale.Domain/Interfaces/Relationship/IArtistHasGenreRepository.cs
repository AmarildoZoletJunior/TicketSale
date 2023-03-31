using TicketSale.Domain.Entities.ArtistHasGenreEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces.Relationship
{
    public interface IArtistHasGenreRepository : IBaseRepository<ArtistHasGenre>
    {
        Task<int> Delete(int artistId, int genreId);
        Task<int> Update(int artistId, int genreId);
    }
}
