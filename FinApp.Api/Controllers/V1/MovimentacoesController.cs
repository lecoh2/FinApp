using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinApp.Api.Controllers.V1
{
    [Route("api/v1/movimentacoes")]
    [ApiController]
    public class MovimentacoesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        public async Task<IActionResult> PutAsync()
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            throw new NotImplementedException();
        }

    }
}
