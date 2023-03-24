using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.CrossCutting.DTOs.GenreHasEventDTOs.Response
{
    public class GeHasEvWithId
    {
        public int EventId { get; set; }
        public int GenreId { get; set; }
    }
}
