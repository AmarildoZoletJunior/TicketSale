using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.CityEntity;
using TicketSale.Domain.Entities.Relationship.ArtistHasEventEntity;
using TicketSale.Domain.Entities.Relationship.GenreHasEventEntity;
using TicketSale.Domain.Entities.TicketRegistrationEntity;

namespace TicketSale.Domain.Entities.EventEntity
{
    public class Event : BaseEntity
    {
        public string Address { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public int AgeRestriction { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public ICollection<ArtistHasEvent> Artirts { get; set; }
        public ICollection<GenreHasEvent> Genres { get; set; }
        public ICollection<TicketRegistration> TicketsRegistrations  { get; set; }
    }
}
