namespace TicketSale.Application.DTOs.ResponseClass
{
    public class ResponseErrors<T> where T : class
    {
        public string MessageIntroduction { get; set; }
        public List<MessageError>? Messages { get; private set; } = new List<MessageError>();
        public T? Data { get; set; }
        public bool Success { get; set; }

        public ResponseErrors(T? data)
        {
            Success = true;
            Data = data;

        }

        public ResponseErrors(string messageIntroduction)
        {

            MessageIntroduction = messageIntroduction;
            Success = false;

        }
        public void AddMessage(string title, string message)
        {
            if (!Success)
            {
                Messages!.Add(new MessageError(title, message));
            }
        }


    }
}
