using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Application.DTOs.ArtistDTOs.Response;
using TicketSale.Application.DTOs.ResponseClass;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Application.Services.ArtistServices
{
    public class ArtistService
    {
        private readonly IArtistRepository _artistRepository;

        public ArtistService(IArtistRepository artist)
        {
            _artistRepository = artist;
        }

    }
}
