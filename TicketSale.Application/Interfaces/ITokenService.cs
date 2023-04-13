using TicketSale.Application.DTOs.AuthDTOs;
using TicketSale.Domain.Entities.ClientEntity;

namespace TicketSale.Application.Interfaces
{
    public interface ITokenService
    {
        Task<AuthResponse> GenerateTokenAsync(Client client);
    }
}
