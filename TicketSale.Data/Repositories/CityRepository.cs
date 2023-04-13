using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.CityEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class CityRepository : BaseRepository<City>, IBaseRepository<City>, ICityRepository
    {
        public CityRepository(TicketContext ticket) : base(ticket) { }

        public void Update(City city)
        {
            _ticketContext.Cities.Update(city);
        }
    }
}
