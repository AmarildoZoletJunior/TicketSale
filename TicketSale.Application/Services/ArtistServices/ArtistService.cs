using TicketSale.Application.Interfaces;
using TicketSale.Data.UnitOfWork;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Application.Services.ArtistServices
{
    public class ArtistService : IArtistService
    {
        private readonly IUnitOfWorkRepository _teste;
        private readonly IArtistRepository _artistRepository;

        public ArtistService(IUnitOfWorkRepository teste, IArtistRepository artistRepository)
        {
            _teste = teste;
            _artistRepository = artistRepository;
        }
    }
}
