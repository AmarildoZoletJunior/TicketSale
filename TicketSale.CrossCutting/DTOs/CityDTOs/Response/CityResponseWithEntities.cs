using TicketSale.CrossCutting.DTOs.StateDTOs.Response;

namespace TicketSale.CrossCutting.DTOs.CityDTOs.Response
{
    public class CityResponseWithEntities
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public StateResponse State { get; set; }
    }
}
