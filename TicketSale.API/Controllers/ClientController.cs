using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TicketSale.Application.DTOs.ClientDTOs.Request;
using TicketSale.Application.Interfaces;
using TicketSale.Domain.Entities.ClientEntity;

namespace TicketSale.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _client;
        private readonly IMapper _mapper;

        public ClientController(IClientService client,IMapper mapper)
        {
            _client = client;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateClientAsync(ClientRequest client)
        {
           var mappping = _mapper.Map<Client>(client);
           var result =  await _client.CreateUser(mappping);
            if (result.Success)
            {
                return Ok(client);
            }
            return BadRequest(result.Messages);
        }

    }
}
