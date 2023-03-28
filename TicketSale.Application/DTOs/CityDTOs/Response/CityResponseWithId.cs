

namespace TicketSale.Application.DTOs.CityDTOs.Response
{
    public class CityResponseWithId
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
    }
}
