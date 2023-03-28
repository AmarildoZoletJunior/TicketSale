using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.ClientEntity;

namespace TicketSale.Domain.Entities.UserEntity
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Client Client { get; set; }
        public Client ClientId { get; set; }

    }
}
