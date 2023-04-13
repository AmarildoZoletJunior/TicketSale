using TicketSale.Domain.Entities.Relationship.ArtistHasGenreEntity;

namespace TicketSale.Domain.Interfaces.Relationship
{
    public interface IArtistHasGenreRepository
    {
        public void Delete(int artistId, int genreId);
        public void Create(ArtistHasGenre artist);
    }
}
