using TicketSale.Application.DTOs.ArtistDTOs;
using TicketSale.Application.DTOs.GenreDTOs.Response;

namespace TicketSale.Application.DTOs.ArtistHasGenreDTOs.Response
{
    public class ArHasGeWithId
    {
        public DateTime CreatedAt { get; set; }
        public GenreResponse Genre { get; set; }
        public ArtistResponse Artist { get; set; }
    }
}
