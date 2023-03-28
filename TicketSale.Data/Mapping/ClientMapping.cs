using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketSale.Domain.Entities.ClientEntity;

namespace TicketSale.Data.Mapping
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {

            builder.HasKey(property => property.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();

            builder.OwnsOne(x => x.PersonInfo).Property(x => x.Name).IsRequired().HasMaxLength(50).HasColumnName("Name");
            builder.OwnsOne(x => x.PersonInfo).Property(x => x.Surname).IsRequired().HasMaxLength(50).HasColumnName("Surname");
            builder.OwnsOne(x => x.PersonInfo).Property(x => x.Birthday).IsRequired().HasColumnName("Birthday");
            builder.OwnsOne(x => x.PersonInfo).Property(x => x.CPF).IsRequired().HasMaxLength(14).HasColumnName("CPF");


            builder.Property(x => x.AdressInfo).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.CityId).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();


            builder.HasOne(x => x.City).WithMany(x => x.Clients).HasForeignKey(x => x.CityId);
            builder.HasOne(x => x.User).WithOne(x => x.Client).HasForeignKey<Client>(x => x.UserId);
        }
    }
}
