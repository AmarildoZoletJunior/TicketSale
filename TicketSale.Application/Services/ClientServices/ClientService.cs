﻿using TicketSale.Application.DTOs.ResponseDTO;
using TicketSale.Application.Interfaces;
using TicketSale.Application.Validators;
using TicketSale.Data.UnitOfWork;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Application.Services.ClientServices
{
    public class ClientService : IClientService
    {
        private readonly IUnitOfWorkRepository _unit;
        private readonly IClientRepository _client;
        private readonly ICityRepository _cityRepository;

        public ClientService(IUnitOfWorkRepository unit,IClientRepository client, ICityRepository cityRepository)
        {
            _unit = unit;
            _client = client;
            _cityRepository = cityRepository;
        }

        public async Task<Response<Client>> CreateUser(Client client)
        {
            var responseClass = new Response<Client>();

            var cityFind = await _cityRepository.FindByIdAsync(client.CityId);
            if (cityFind == null)
            {
                responseClass.AddMessage("Cidade não encontrada", "O id da cidade fornecida não foi encontrado no banco");
                return responseClass;
            }

            var CpfIsUsed = await _client.CPFIsUsed(client.PersonInfo.CPF);
            if (CpfIsUsed == null)
            {
                responseClass.AddMessage("CPF já esta em uso", "Este CPF já esta sendo registrado no banco");
                return responseClass;
            }

            var emailIsUsed = await _client.EmailIsUsed(client.Email);
            if (emailIsUsed == null)
            {
                responseClass.AddMessage("Email já esta em uso", "Este email já esta sendo registrado no banco");
                return responseClass;
            }

            var classValidator = new ClientValidator();
            var Validate = classValidator.Validate(client);
            if (!Validate.IsValid) 
            {
                Validate.Errors.ForEach(x => responseClass.AddMessage(x.PropertyName, x.ErrorMessage));
                return responseClass;
            }


            _client.CryptoPasswordClient(client);
            responseClass.AddData(client);
            await _client.Create(client);
            await _unit.Commit();
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