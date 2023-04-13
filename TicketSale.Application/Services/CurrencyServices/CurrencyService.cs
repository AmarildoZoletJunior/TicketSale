using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Application.DTOs.CurrencyDTOs;
using TicketSale.Application.Interfaces;
using TicketSale.Domain.Enum;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Application.Services.CurrencyServices
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public CurrencyService(ICurrencyRepository currency,IMapper mapper)
        {
            _currencyRepository = currency;
            _mapper = mapper;
        }
        public async Task<List<CurrencyResponse>> GetCurrency(int number)
        {
            var currentType = (CurrentType)number;
            var currentEntity = await _currencyRepository.GetCurrency(currentType);
            var map = _mapper.Map<List<CurrencyResponse>>(currentEntity);
            return map;
        }
    }
}
