using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FCMBTransactionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        // GET: api/<TransactionController>
        [HttpGet]
        public IActionResult GetTransactionHistory()
        {
            return Ok();
        }


        // POST api/<TransactionController>
        [HttpPost("{DoTransfer}")]
        public IActionResult DoTransfer([FromBody] string value)
        {
            return Ok();
        }

        // POST api/<TransactionController>
        [HttpPost("{BuyAirtime}")]
        public IActionResult BuyAirtime([FromBody] string value)
        {
            return Ok();
        }

    }
}
