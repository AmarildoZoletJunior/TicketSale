using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketSale.Domain.Entities.CityEntity;

namespace TicketSale.Data.Mapping
{
    public class CityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(property => property.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();

            builder.Property(x => x.CityName).IsRequired();

            builder.HasOne(x => x.State).WithMany(x => x.Cities).HasForeignKey(x => x.StateId);
        }
    }
}
