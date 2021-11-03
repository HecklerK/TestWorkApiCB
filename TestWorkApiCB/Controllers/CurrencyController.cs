using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWorkApiCB.Models;

namespace TestWorkApiCB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        [HttpGet("{key}")]
        public async Task<ActionResult<Valute>> get(string key)
        {
            Daily newDaily = await Deserialize.deserialize("https://www.cbr-xml-daily.ru/daily_json.js");
            Currency currency = new Currency
            {
                Value = newDaily.Valute[key].Value
            };
            return Ok(currency);
        }
    }
}
