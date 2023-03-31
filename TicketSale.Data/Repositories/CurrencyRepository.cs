using Newtonsoft.Json;
using System.Net.Http.Json;
using TicketSale.Domain.Entities.CurrencyEntity;
using TicketSale.Domain.Enum;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Data.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        public async Task<Currency> GetCurrency(int number)
        {
            CurrentType teste = (CurrentType) number;
            HttpClient client = new HttpClient();
            string url = $"https://economia.awesomeapi.com.br/last/{teste}-BRL";
            HttpResponseMessage response = await client.GetAsync(url);
            Currency objeto = await response.Content.ReadFromJsonAsync<Currency>();
            return objeto;
        }
    }
}
