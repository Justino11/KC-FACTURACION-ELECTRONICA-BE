using KC_FACTURACION_ELECTRONICA.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KC_FACTURACION_ELECTRONICA.Controllers
{
    [Route("api/HistorialFacturasPac")]
    [ApiController]
    public class HistorialFacturasProcesadasController : ControllerBase
    {
        private readonly IHistorialFacturasProcesadas _hfactproceRepo;
        public HistorialFacturasProcesadasController(IHistorialFacturasProcesadas hfactproceRepo) => _hfactproceRepo = hfactproceRepo;

        [HttpGet]
        public async Task<IActionResult> GetallHistorialFacturasFE()
        {
            try
            {
                var HistorialFacturasProcesadasRequest = await _hfactproceRepo.GetallHistorialFacturasFE();
                return Ok(HistorialFacturasProcesadasRequest);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
