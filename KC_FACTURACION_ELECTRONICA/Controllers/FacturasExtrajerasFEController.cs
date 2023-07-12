using Dapper;
using KC_FACTURACION_ELECTRONICA.Models;
using KC_FACTURACION_ELECTRONICA.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace KC_FACTURACION_ELECTRONICA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasExtrajerasFEController : ControllerBase
    {
        private readonly IConfiguration _config;

        public FacturasExtrajerasFEController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public async Task<ActionResult<List<FacturasExtrajerasFEHRequest>>> GetallFacturasFE()
        {
            using var connection = new SqlConnection(_config.GetConnectionString("SqlConnection"));
            var FE = await connection.QueryAsync<FacturasExtrajerasFEHRequest>("SELECT TOP (100) * FROM V_FE_FacDatosGenerales_Pac");

            return Ok(FE);
        }
    }
}
