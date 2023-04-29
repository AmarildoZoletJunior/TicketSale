namespace TicketSale.Application.DTOs.ClientDTOs.Response
{
    public class ClientResponseWithId
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string AdressInfo { get; set; }
        public int CityId { get; set; }
    }
}
