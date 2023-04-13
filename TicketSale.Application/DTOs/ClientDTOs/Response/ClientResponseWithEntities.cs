using TicketSale.Application.DTOs.CityDTOs.Response;

namespace TicketSale.Application.DTOs.ClientDTOs.Response
{
    public class ClientResponseWithEntities
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string AdressInfo { get; set; }
        public DateTime Birthday { get; set; }
        public CityResponseWithEntities City { get; set; }
    }
}
