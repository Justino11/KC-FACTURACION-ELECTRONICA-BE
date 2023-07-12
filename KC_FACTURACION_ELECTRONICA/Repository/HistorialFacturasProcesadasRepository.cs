using Dapper;
using KC_FACTURACION_ELECTRONICA.BbContext;
using KC_FACTURACION_ELECTRONICA.Interfaces;
using KC_FACTURACION_ELECTRONICA.Models.Request;

namespace KC_FACTURACION_ELECTRONICA.Repository
{
    public class HistorialFacturasProcesadasRepository : IHistorialFacturasProcesadas
    {
        private readonly DatalakeContext _context;
        public HistorialFacturasProcesadasRepository(DatalakeContext context) => _context = context;
        public async Task<IEnumerable<HistorialFacturasProcesadasRequest>> GetallHistorialFacturasFE()
        {
            var query = "SELECT TOP (1000) * FROM V_Fe_FacDatosGenerales_Pac";
            using (var connection = _context.CreateConnection())
            {
                var HFE = await connection.QueryAsync<HistorialFacturasProcesadasRequest>(query);
                return HFE.ToList();
            }
        }
    }
}
