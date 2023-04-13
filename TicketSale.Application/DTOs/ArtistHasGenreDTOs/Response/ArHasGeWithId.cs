using TicketSale.Application.DTOs.ArtistDTOs.Response;
using TicketSale.Application.DTOs.GenreDTOs.Response;

namespace TicketSale.Application.DTOs.ArtistHasGenreDTOs.Response
{
    public class ArHasGeWithId
    {
        public DateTime CreatedAt { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
    }
}
