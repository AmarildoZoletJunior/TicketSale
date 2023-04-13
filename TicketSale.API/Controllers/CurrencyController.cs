using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketSale.Application.Interfaces;
using XAct.Security;

namespace TicketSale.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService _currencyService;
        private readonly ILogger _logger;
        public CurrencyController(ICurrencyService currencyService,ILogger<CurrencyController> logger) 
        { 
            _currencyService = currencyService;
            _logger = logger;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get(int number) 
        {
            var response = await _currencyService.GetCurrency(number);
            if(response != null)
            {
                //_logger.LogInformation("Ok deu certo");
                return Ok(response);
            }
            //_logger.LogInformation("Ok deu certo");
            return BadRequest("Não foi possivel encontrar esta cotação.");
        }
    }
}
