﻿using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.Relationship.ArtistHasEventEntity;
using TicketSale.Domain.Entities.Relationship.ArtistHasGenreEntity;

namespace TicketSale.Domain.Entities.ArtistEntity
{
    public class Artist : BaseEntity
    {
        public string ArtistName { get; set; }
        public ICollection<ArtistHasEvent> Events { get; set; }
        public ICollection<ArtistHasGenre> Genres { get; set; }
    }
}
