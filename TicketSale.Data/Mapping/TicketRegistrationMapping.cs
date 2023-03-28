using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketSale.Domain.Entities.TicketRegistrationEntity;

namespace TicketSale.Data.Mapping
{
    public class TicketRegistrationMapping : IEntityTypeConfiguration<TicketRegistration>
    {
        public void Configure(EntityTypeBuilder<TicketRegistration> builder)
        {
            builder.HasKey(property => property.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();

            builder.Property(x => x.TicketQuantity).IsRequired();
            builder.Property(x => x.Value).IsRequired();
            builder.Property(x => x.EventId).IsRequired();

            builder.HasOne(x => x.Event).WithMany(x => x.TicketsRegistrations).HasForeignKey(x => x.EventId);
        }
    }
}
