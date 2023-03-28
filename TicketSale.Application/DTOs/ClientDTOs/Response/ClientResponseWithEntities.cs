using TicketSale.Application.DTOs.CityDTOs.Response;
using TicketSale.Application.DTOs.UserDTOs.Response;

namespace TicketSale.Application.DTOs.ClientDTOs.Response
{
    public class ClientResponseWithEntities
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string AdressInfo { get; set; }
        public UserResponseWithId User { get; set; }
        public CityResponseWithEntities City { get; set; }
    }
}
