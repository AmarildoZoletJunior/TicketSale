using TicketSale.CrossCutting.DTOs.StateDTOs;

namespace TicketSale.CrossCutting.DTOs.CityDTOs.Response
{
    public class CityResponseWithId
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
    }
}
