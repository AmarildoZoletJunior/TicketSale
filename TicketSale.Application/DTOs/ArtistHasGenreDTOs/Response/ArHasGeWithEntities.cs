using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.Application.DTOs.ArtistHasGenreDTOs.Response
{
    public class ArHasGeWithEntities
    {
        public DateTime CreatedAt { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
    }
}
