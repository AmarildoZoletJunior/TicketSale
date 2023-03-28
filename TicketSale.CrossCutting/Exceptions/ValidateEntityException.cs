namespace TicketSale.CrossCutting.Exceptions
{
    public class ValidateEntityException : Exception
    {
        public ValidateEntityException(string message, Exception innerException) : base(message,innerException)
        {
            
        }
        public ValidateEntityException(string message) : base(message)
        {
            
        }
    }
}
