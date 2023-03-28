using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.Application.DTOs.UserDTOs.Response
{
    public class UserResponseWithId
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public int ClientId { get; set; }
    }
}
