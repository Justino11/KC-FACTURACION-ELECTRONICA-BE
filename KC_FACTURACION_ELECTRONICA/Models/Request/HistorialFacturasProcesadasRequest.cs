namespace KC_FACTURACION_ELECTRONICA.Models.Request
{
    public class HistorialFacturasProcesadasRequest
    {
        public string InvoiceNumber { get; set; } = null!;
        public DateTime fecha_salida { get; set; }
        public string tipo_emision { get; set; } = null!;
        public string? receptor_ruc { get; set; }
        public string? receptor_digito_verificador { get; set; }
        public string? receptor_nombre { get; set; }
        public int Formas_de_pago { get; set; }
        public decimal pagoMonto { get; set; }
    }
}
