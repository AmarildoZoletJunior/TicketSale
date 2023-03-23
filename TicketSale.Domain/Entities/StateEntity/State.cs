using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.Base;

namespace TicketSale.Domain.Entities.StateEntity
{
    public class State : BaseEntity
    {
        public string AcronymState { get; set; }
        public string StateName { get; set; }
    }
}
