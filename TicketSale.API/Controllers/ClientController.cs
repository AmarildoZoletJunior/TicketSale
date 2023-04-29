using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;
using System.ComponentModel.DataAnnotations;
using TicketSale.Application.DTOs.ClientDTOs.Request;
using TicketSale.Application.DTOs.ClientDTOs.Response;
using TicketSale.Application.Interfaces;
using TicketSale.CrossCutting.Paged;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces;

namespace TicketSale.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _client;
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public ClientController(IClientService client,IMapper mapper,ICityRepository city)
        {
            _client = client;
            _mapper = mapper;
            _cityRepository = city;
        }

        [HttpPost]
        public async Task<IActionResult> CreateClientAsync(ClientRequest client)
        {
            var cityFind = await _cityRepository.FindByNameAsync(client.CityName);
           if(cityFind == null)
            {
                return BadRequest("Não foi possivel encontrar esta cidade");
            }
           var mapping = _mapper.Map<Client>(client);
            mapping.CityId = cityFind.Id;
           var result =  await _client.CreateUser(mapping);
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest(result.Messages);
        }

        [HttpGet]
        public async Task<IActionResult> GetClientsAsync([FromQuery]PagedParameters parameters)
        {
            var find = await _client.GetClients(parameters);
            if (find.Success)
            {
                var map = _mapper.Map<IEnumerable<ClientResponseWithId>>(find.Data);
                return Ok(new {dados = map, parametros = new { Pagina = parameters.PageNumber, QuantidadeRequerida = parameters.PageSize, QuantidadeBuscada = find.Data.Count() } });
            }
            return BadRequest(find.Messages);
        }
    }
}
