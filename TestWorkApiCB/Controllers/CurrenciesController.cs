using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWorkApiCB.Models;

namespace TestWorkApiCB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Valute>>> Get(int quantity)
        {
            var list = new Dictionary<string, Currency>();
            Daily newDaily = await Deserialize.deserialize("https://www.cbr-xml-daily.ru/daily_json.js");
            foreach (var valute in newDaily.Valute)
            {
                Currency currency = new Currency
                {
                    Value = valute.Value.Value
                };
                list.Add(valute.Key, currency);
            }
            if (quantity == 0)
                return Ok(list);
            else
                return Ok(list.Take(quantity).ToDictionary(item => item.Key, item => item.Value));
        }
    }
}
