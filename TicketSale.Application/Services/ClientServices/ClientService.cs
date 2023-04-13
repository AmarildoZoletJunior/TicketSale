using TicketSale.Application.DTOs.ResponseDTO;
using TicketSale.Application.Interfaces;
using TicketSale.Application.Validators;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Application.Services.ClientServices
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _client;

        public ClientService(IClientRepository client)
        {
            _client = client;
        }

        public async Task<Response<Client>> CreateUser(Client client)
        {
            var responseClass = new Response<Client>();
            var classValidator = new ClientValidator();
            var Validate = classValidator.Validate(client);
            if (!Validate.IsValid) 
            {
                Validate.Errors.ForEach(x => responseClass.AddMessage(x.PropertyName, x.ErrorMessage));
                return responseClass;
            }
            responseClass.AddData(client);
            await _client.Create(client);
            return responseClass;
        }

        public Task<Response<Client>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Client>> UpdateUser(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
