using TicketSale.Application.DTOs.ResponseDTO;
using TicketSale.Domain.Entities.ClientEntity;

namespace TicketSale.Application.Interfaces
{
    public interface IClientService
    {
        public Task<Response<Client>> CreateUser(Client client);
        public Task<Response<Client>> UpdateUser(Client client);
        public Task<Response<Client>> GetById(int id);
    }
}
