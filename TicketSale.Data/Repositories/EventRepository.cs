using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Data.Context;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.ArtistHasEventEntity;
using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Entities.GenreHasEventEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class EventRepository : BaseRepository<Event>, IBaseRepository<Event>, IEventRepository
    {
        public EventRepository(TicketContext ticket) : base(ticket) { }


        public Task<ArtistHasEvent> AddArtistToEvent(ArtistHasEvent artistHasEvent)
        {
            throw new NotImplementedException();
        }

        public Task<GenreHasEvent> AddGenreToEvent(GenreHasEvent genreHasEvent)
        {
            throw new NotImplementedException();
        }

        public Task<Event> Update(Event Event)
        {
            throw new NotImplementedException();
        }
    }
}
