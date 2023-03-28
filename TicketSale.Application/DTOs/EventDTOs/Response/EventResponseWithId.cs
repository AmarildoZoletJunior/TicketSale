namespace TicketSale.Application.DTOs.EventDTOs.Response
{
    public class EventResponseWithId
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public int AgeRestriction { get; set; }
        public int CityId { get; set; }

    }
}
