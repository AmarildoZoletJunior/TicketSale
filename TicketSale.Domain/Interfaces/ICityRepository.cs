using TicketSale.Domain.Entities.CityEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface ICityRepository : IBaseRepository<City>
    {
        public void Update(City city);
    }
}
