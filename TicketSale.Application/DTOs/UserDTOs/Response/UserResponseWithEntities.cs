using TicketSale.Application.DTOs.ClientDTOs.Response;

namespace TicketSale.Application.DTOs.UserDTOs.Response
{
    public class UserResponseWithEntities
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public ClientResponseWithEntities Client { get; set; }
    }
}
