using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.CurrencyEntity;
using TicketSale.Domain.Enum;

namespace TicketSale.Domain.Interfaces
{
    public interface ICurrencyRepository
    {
        Task<Currency> GetCurrency(int current);
    }
}
