using TicketSale.Application.DTOs.ArtistDTOs.Response;
using TicketSale.Application.DTOs.GenreDTOs.Response;

namespace TicketSale.Application.DTOs.ArtistHasGenreDTOs.Response
{
    public class ArHasGeWithEntities
    {
        public DateTime CreatedAt { get; set; }
        public GenreResponse Genre { get; set; }
        public ArtistResponse Artist { get; set; }
    }
}
