using Microsoft.EntityFrameworkCore;
using TicketSale.Data.Mapping;
using TicketSale.Data.Mapping.RelationshipMap;
using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Entities.CityEntity;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Entities.GenreEntity;
using TicketSale.Domain.Entities.PaymentStatusEntity;
using TicketSale.Domain.Entities.Relationship.ArtistHasEventEntity;
using TicketSale.Domain.Entities.Relationship.ArtistHasGenreEntity;
using TicketSale.Domain.Entities.Relationship.GenreHasEventEntity;
using TicketSale.Domain.Entities.StateEntity;
using TicketSale.Domain.Entities.TicketEntity;
using TicketSale.Domain.Entities.TicketRegistrationEntity;

namespace TicketSale.Data
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options) : base(options) { }

        public DbSet<Artist> Artirts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<TicketRegistration> TicketRegistrations { get; set; }
        public DbSet<GenreHasEvent> GenreHasEvents { get; set; }
        public DbSet<ArtistHasEvent> ArtistsHasEvents { get; set; }
        public DbSet<ArtistHasGenre> ArtistsHasGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());
            modelBuilder.ApplyConfiguration(new ClientMapping());
            modelBuilder.ApplyConfiguration(new EventMapping());
            modelBuilder.ApplyConfiguration(new GenreMapping());
            modelBuilder.ApplyConfiguration(new PaymentStatusMapping());
            modelBuilder.ApplyConfiguration(new StateMapping());
            modelBuilder.ApplyConfiguration(new TicketRegistrationMapping());
            modelBuilder.ApplyConfiguration(new ArtistHasEventMapping());
            modelBuilder.ApplyConfiguration(new ArtistHasGenreMapping());
            modelBuilder.ApplyConfiguration(new TicketMapping());
            modelBuilder.ApplyConfiguration(new GenreHasEventMapping());

        }
    }
}
