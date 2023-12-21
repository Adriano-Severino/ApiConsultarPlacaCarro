using CSTPlaca.CrossCutting.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ConsultarPlacaCarro.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ConsultCarController : Controller
    {
        private readonly IApiPlacaService _apiPlacaService;
        public ConsultCarController(IApiPlacaService apiPlacaService)
        {
            _apiPlacaService = apiPlacaService;
        }
        [HttpGet]
        //[Authorize(Policy = "Admin")]
        [Route("get-placa-api")]
        public async Task<IActionResult> CreateEmployeesByApi([FromQuery] string placa)
        {
            return await ExecuteAsync(async () => await _apiPlacaService.GetPlacaAsync(placa));
        }
        private async Task<IActionResult> ExecuteAsync(Func<Task<object>> func)
        {
            try
            {
                var result = await func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
