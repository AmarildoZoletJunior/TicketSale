using TicketSale.Application.DTOs.StateDTOs.Response;

namespace TicketSale.Application.DTOs.CityDTOs.Response
{
    public class CityResponseWithEntities
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string CityName { get; set; }
        public StateResponse State { get; set; }
    }
}
