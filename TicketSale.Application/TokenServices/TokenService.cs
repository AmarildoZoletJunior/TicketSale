using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.ClientEntity;

namespace TicketSale.Application.TokenServices
{
    public class TokenService
    {

        public static object GenerateToken(Client client, IConfiguration _configuration)
        {
            var key = Encoding.ASCII.GetBytes(_configuration["TokenJwtPassword"]);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                 {
                     new Claim(ClaimTypes.Name, client.Id.ToString())
                 }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            var tokenString = tokenHandler.WriteToken(token);

            return new
            {
                token = tokenString,
            };
        }
    }
}
