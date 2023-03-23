using TicketSale.Domain.Entities.ArtistHasEventEntity;
using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.GenreHasEventEntity;

namespace TicketSale.Domain.Entities.CategoryEntity
{
    public class Genre : BaseEntity
    {
        public string TypeGenre { get; set; }
        public ICollection<GenreHasEvent> Events { get; set; }
    }
}
