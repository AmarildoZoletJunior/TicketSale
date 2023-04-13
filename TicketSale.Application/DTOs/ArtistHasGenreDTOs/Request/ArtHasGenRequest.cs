using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.Application.DTOs.ArtistHasGenreDTOs.Request
{
    public class ArtHasGenRequest
    {
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
    }
}
