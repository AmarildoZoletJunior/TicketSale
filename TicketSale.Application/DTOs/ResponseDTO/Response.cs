namespace TicketSale.Application.DTOs.ResponseDTO
{
    public class Response<T> where T : class
    {
        public List<MessageError>? Messages { get; private set; } = new List<MessageError>();
        public T? Data { get; set; }
        public bool Success { get; set; }


        public void AddMessage(string title, string message)
        {
            this.Success = false;
            if(Data != null)
            {
                this.Data = null;
            }
            Messages!.Add(new MessageError(title, message));
        }
        public void AddData(T data)
        {
            if (this.Messages.Any())
            {
                return;
            }
            this.Data = data;
            this.Success = true;
        }

    }
}
