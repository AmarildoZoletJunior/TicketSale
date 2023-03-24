using TicketSale.Domain.Entities.ArtistHasEventEntity;
using TicketSale.Domain.Entities.ArtistHasGenreEntity;
using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.GenreHasEventEntity;

namespace TicketSale.Domain.Entities.GenreEntity
{
    public class Genre : BaseEntity
    {
        public string TypeGenre { get; set; }
        public ICollection<GenreHasEvent> Events { get; set; }
        public ICollection<ArtistHasGenre> Artirts { get; set; }
    }
}
