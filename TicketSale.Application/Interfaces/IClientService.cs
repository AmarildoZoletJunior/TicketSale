﻿using TicketSale.Application.DTOs.ResponseDTO;
using TicketSale.CrossCutting.Paged;
using TicketSale.Domain.Entities.ClientEntity;

namespace TicketSale.Application.Interfaces
{
    public interface IClientService
    {
        public Task<Response<Client>> CreateUser(Client client);
        public Task<Response<Client>> UpdateUser(Client client);

        public Task<Response<IEnumerable<Client>>> GetClients(PagedParameters paged);

    }
}
