namespace TicketSale.Application.DTOs.StateDTOs.Response
{
    public class StateResponse
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string AcronymState { get; set; }
        public string StateName { get; set; }
    }
}
