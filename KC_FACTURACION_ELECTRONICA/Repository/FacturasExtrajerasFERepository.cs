using Dapper;
using KC_FACTURACION_ELECTRONICA.BbContext;
using KC_FACTURACION_ELECTRONICA.Interfaces;
using KC_FACTURACION_ELECTRONICA.Models.Request;

namespace KC_FACTURACION_ELECTRONICA.Repository
{
    public class FacturasExtrajerasFERepository : IFacturasExtrajerasFE
    {
        private readonly DatalakeContext _context;
        public FacturasExtrajerasFERepository(DatalakeContext context) => _context = context;
        public async Task<IEnumerable<FacturasExtrajerasFEHRequest>> GetallFacturasExtrajeras()
        {
            var query = "SELECT * FROM FacturasExtrajerasFEHRequest";
            using (var connection = _context.CreateConnection()) 
            {
                var FE = await connection.QueryAsync<FacturasExtrajerasFEHRequest>(query);
                return FE.ToList();
            }
        }
    }
}
