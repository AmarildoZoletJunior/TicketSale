using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.GenreHasEventEntity;

namespace TicketSale.Data.Mapping.RelationshipMap
{
    public class GenreHasEventMapping : IEntityTypeConfiguration<GenreHasEvent>
    {
        public void Configure(EntityTypeBuilder<GenreHasEvent> builder)
        {
            builder.HasKey(x => new { x.EventId, x.GenreId });

            builder.HasOne(x => x.Genre).WithMany(x => x.Events).HasForeignKey(x => x.GenreId);

            builder.HasOne(x => x.Event).WithMany(x => x.Genres).HasForeignKey(x => x.EventId);
        }
    }
}
