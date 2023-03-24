using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.CrossCutting.DTOs.UserDTOs.Response
{
    public class UserResponseWithId
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int ClientId { get; set; }
    }
}
