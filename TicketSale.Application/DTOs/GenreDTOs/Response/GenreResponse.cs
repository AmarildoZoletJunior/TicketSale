using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.Application.DTOs.GenreDTOs.Response
{
    public class GenreResponse
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string TypeGenre { get; set; }
    }
}
