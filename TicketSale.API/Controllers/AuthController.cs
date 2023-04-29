using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketSale.Application.DTOs.AuthDTOs;
using TicketSale.Application.Interfaces;
using TicketSale.Application.Services.TokenServices;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces;

namespace TicketSale.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
 
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AuthController(IMapper mapper, ITokenService token) 
        {
            _mapper = mapper;
            _tokenService = token;
        }

        [HttpPost]
        public async Task<IActionResult> AuthAsync(AuthRequest client)
        {
            var mapping = _mapper.Map<Client>(client);
            
            var token = await _tokenService.GenerateTokenAsync(mapping);

            if (token.IsValid)
            {
                return Ok(token);
            }
            return Unauthorized("Não foi autorizado");
        }
    }
}
