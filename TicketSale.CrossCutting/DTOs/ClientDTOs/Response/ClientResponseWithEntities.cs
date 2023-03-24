using TicketSale.CrossCutting.DTOs.CityDTOs.Response;
using TicketSale.CrossCutting.DTOs.UserDTOs.Response;

namespace TicketSale.CrossCutting.DTOs.ClientDTOs.Response
{
    public class ClientResponseWithEntities
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string AdressInfo { get; set; }
        public UserResponseWithId User { get; set; }
        public CityResponseWithEntities City { get; set; }
    }
}
