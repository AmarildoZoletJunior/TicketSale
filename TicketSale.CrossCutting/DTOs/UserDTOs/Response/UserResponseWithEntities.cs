using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.CrossCutting.DTOs.ClientDTOs.Response;

namespace TicketSale.CrossCutting.DTOs.UserDTOs.Response
{
    public class UserResponseWithEntities
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public ClientResponseWithEntities Client { get; set; }
    }
}
