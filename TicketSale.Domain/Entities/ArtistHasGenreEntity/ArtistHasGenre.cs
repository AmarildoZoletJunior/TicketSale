using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Entities.GenreEntity;

namespace TicketSale.Domain.Entities.ArtistHasGenreEntity
{
    public class ArtistHasGenre
    {
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
    }
}
