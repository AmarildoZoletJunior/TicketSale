using TicketSale.Domain.Entities.ArtistHasEventEntity;
using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.CategoryEntity;

namespace TicketSale.Domain.Entities.ArtistEntity
{
    public class Artist : BaseEntity
    {
        public string ArtistName { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public ICollection<ArtistHasEvent> Events { get; set; }
    }
}
