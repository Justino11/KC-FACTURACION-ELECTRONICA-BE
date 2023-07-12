namespace KC_FACTURACION_ELECTRONICA.Models.Request
{
    public class FacturasExtrajerasFEDRequest
    {
        public string descripcionProducto { get; set; } = null!;
        public string? numero_documento_fiscal { get; set; }
        public string? codigoInterno { get; set; }
        public string unidadMedida { get; set; } = null!;
        public decimal? cantidadProducto { get; set; }
        public decimal? precioUnitario { get; set; }
        public string tasaITBMS { get; set; } = null!;
        public int Descuento { get; set; }
    }
}
