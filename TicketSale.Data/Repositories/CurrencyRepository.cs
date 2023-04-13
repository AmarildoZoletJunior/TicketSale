using Newtonsoft.Json;
using System.Net.Http.Json;
using TicketSale.Domain.Entities.CurrencyEntity;
using TicketSale.Domain.Enum;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Data.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        public async Task<List<Currency>> GetCurrency(CurrentType current)
        {
            HttpClient client = new HttpClient();
            string url = $"https://economia.awesomeapi.com.br/json/BRL-{current}";
            HttpResponseMessage response = await client.GetAsync(url);
            List<Currency> objeto = await response.Content.ReadFromJsonAsync<List<Currency>>();
            return objeto;
        }
    }
}
