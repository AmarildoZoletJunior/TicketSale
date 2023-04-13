using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.GenreEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class GenreRepository : BaseRepository<Genre>, IBaseRepository<Genre>, IGenreRepository
    {
        public GenreRepository(TicketContext ticket) : base(ticket) { }


        public void Update(Genre genre)
        {
           _ticketContext.Genres.Update(genre);
        }
    }
}
