using TicketSale.Domain.Entities.Relationship.GenreHasEventEntity;

namespace TicketSale.Domain.Interfaces.Relationship
{
    public interface IGenreHasEventRepository
    {
        public void Delete(int genreId, int eventId);
        public void Create(GenreHasEvent genre);
    }
}
