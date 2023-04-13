using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TicketSale.Application.DTOs.AuthDTOs;
using TicketSale.Application.Interfaces;
using TicketSale.CrossCutting.Helper;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Application.Services.TokenServices
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly IClientRepository _clientRepository;

        public TokenService(IClientRepository clientRepository, IConfiguration configuration)
        {
            _clientRepository = clientRepository;
            _configuration = configuration;
        }

        public async Task<AuthResponse> GenerateTokenAsync(Client client)
        {
            var clientFind = await _clientRepository.AccountIsValid(client.Email,client.Password);
            if (clientFind == 0)
            {
                return new AuthResponse { IsValid = false };
            }


            var key = Encoding.ASCII.GetBytes(_configuration["JwtToken"]);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                 {
                     new Claim(ClaimTypes.Name, client.Id.ToString())
                 }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            var tokenString = tokenHandler.WriteToken(token);

            return new AuthResponse
            {
                AuthToken = tokenString,
                ClientId = clientFind,
                IsValid = true
            };
        }
    }
}
