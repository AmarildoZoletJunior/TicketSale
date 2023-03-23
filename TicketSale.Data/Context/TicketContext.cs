using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Entities.ArtistHasEventEntity;
using TicketSale.Domain.Entities.CategoryEntity;
using TicketSale.Domain.Entities.CityEntity;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Entities.GenreHasEventEntity;
using TicketSale.Domain.Entities.PaymentStatusEntity;
using TicketSale.Domain.Entities.StateEntity;
using TicketSale.Domain.Entities.TicketEntity;
using TicketSale.Domain.Entities.TicketRegistrationEntity;
using TicketSale.Domain.Entities.UserEntity;

namespace TicketSale.Data.Context
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options) : base(options) { }



        public DbSet<Artist> Artirts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ArtistHasEvent> ArtistsHasEvents { get; set; }
        public DbSet<GenreHasEvent> GenresHasEvents { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<TicketRegistration> TicketRegistrations { get; set; }
    }
}
