using KC_FACTURACION_ELECTRONICA.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace KC_FACTURACION_ELECTRONICA.Interfaces
{
    public interface IFacturasExtrajerasFE
    {
        public Task<IEnumerable<FacturasExtrajerasFEHRequest>> GetallFacturasExtrajeras();
    }
}
