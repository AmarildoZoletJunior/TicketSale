namespace TicketSale.Application.DTOs.ClientDTOs.Request
{
    public class ClientRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string  CPF { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string AdressInfo { get; set; }
        public string CityName { get; set; }
    }
}
