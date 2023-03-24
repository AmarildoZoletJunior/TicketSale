using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.EventEntity;

namespace TicketSale.Data.Mapping
{
    public class EventMapping : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(property => property.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();

            builder.Property(x => x.AgeRestriction).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.InitialDate).IsRequired();
            builder.Property(x => x.FinalDate).IsRequired();
            builder.Property(x => x.CityId).IsRequired();

            builder.HasOne(x => x.City).WithMany(x => x.Events).HasForeignKey(x => x.CityId);
        }
    }
}
