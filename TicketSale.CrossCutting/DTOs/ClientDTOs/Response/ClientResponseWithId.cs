namespace TicketSale.CrossCutting.DTOs.ClientDTOs.Response
{
    public class ClientResponseWithId
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string AdressInfo { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
    }
}
