using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketSale.Domain.Entities.TicketEntity;

namespace TicketSale.Data.Mapping.RelationshipMap
{
    public class TicketMapping : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(x => new { x.ClientId, x.TicketRegistrationId });

            builder.HasOne(x => x.Client).WithMany(x => x.Tickets).HasForeignKey(x => x.ClientId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.TicketRegistration).WithMany(x => x.Tickets).HasForeignKey(x => x.TicketRegistrationId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.PaymentStatus).WithMany(x => x.Tickets).HasForeignKey(x => x.PaymentStatusId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
