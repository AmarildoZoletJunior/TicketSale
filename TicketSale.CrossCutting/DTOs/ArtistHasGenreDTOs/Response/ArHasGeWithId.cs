using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.CrossCutting.DTOs.ArtistDTOs;
using TicketSale.CrossCutting.DTOs.GenreDTOs.Response;

namespace TicketSale.CrossCutting.DTOs.ArtistHasGenreDTOs.Response
{
    public class ArHasGeWithId
    {
        public GenreResponse Genre { get; set; }
        public ArtistResponse Artist { get; set; }
    }
}
