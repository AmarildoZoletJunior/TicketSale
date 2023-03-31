using TicketSale.Data.Repositories;
using TicketSale.Domain.Interfaces;

namespace TicketSale.API.Injections
{
    public static class Injection
    {
        public static void RegisterInjections(IServiceCollection collection)
        {
            collection.AddScoped<IArtistRepository, ArtistRepository>();
            collection.AddScoped<ICurrencyRepository, CurrencyRepository>();
        }
    }
}
