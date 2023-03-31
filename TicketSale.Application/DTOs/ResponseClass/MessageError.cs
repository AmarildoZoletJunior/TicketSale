namespace TicketSale.Application.DTOs.ResponseClass
{
    public class MessageError
    {
        public string TitleError { get; set; }
        public string Message { get; set; }

        public MessageError(string title, string message)
        {
            TitleError = title;
            Message = message;
        }
    }
}
