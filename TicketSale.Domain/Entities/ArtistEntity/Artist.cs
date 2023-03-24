using TicketSale.Domain.Entities.ArtistHasEventEntity;
using TicketSale.Domain.Entities.ArtistHasGenreEntity;
using TicketSale.Domain.Entities.Base;

namespace TicketSale.Domain.Entities.ArtistEntity
{
    public class Artist : BaseEntity
    {
        public string ArtistName { get; set; }
        public ICollection<ArtistHasEvent> Events { get; set; }
        public ICollection<ArtistHasGenre> Genres { get; set; }
    }
}
