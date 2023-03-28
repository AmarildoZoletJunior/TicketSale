namespace TicketSale.CrossCutting.Exceptions
{
    public class ErrorMessage
    {
        public string Message { get; set; }
        public string TitleError { get; set; }

        public ErrorMessage(string message,string title)
        {
            this.Message = message;
                this.TitleError = title;
        }
    }
}
