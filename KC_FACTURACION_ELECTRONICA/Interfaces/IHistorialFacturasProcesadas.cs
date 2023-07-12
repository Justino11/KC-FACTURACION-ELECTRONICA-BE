using KC_FACTURACION_ELECTRONICA.Models.Request;

namespace KC_FACTURACION_ELECTRONICA.Interfaces
{
    public interface IHistorialFacturasProcesadas
    {
        public Task<IEnumerable<HistorialFacturasProcesadasRequest>> GetallHistorialFacturasFE();
    }
}
