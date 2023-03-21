using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
