namespace KC_FACTURACION_ELECTRONICA.Models.Request
{
    public class FacturasExtrajerasFEHRequest
    {
        public string tipo_emision { get; set; } = null!;
        public string tipo_documento { get; set; } = null!;
        public string? numero_documento_fiscal { get; set; }
        public string punto_facturacion { get; set; } = null!;
        public string tipo_transaccion_venta { get; set; } = null!;
        public string emisor_codigo_sucursal { get; set; } = null!;
        public string naturaleza_operacion { get; set; } = null!;
        public string destino_operacion { get; set; } = null!;
        public string receptor_tipo { get; set; } = null!;
        public string receptor_nombre { get; set; } = null!;
        public string receptor_extranjero_identificacion { get; set; } = null!;
        public string receptor_extranjero_pais { get; set; } = null!;
        public string receptor_correo { get; set; } = null!;
        public string receptor_pais { get; set; } = null!;
        public string Formas_de_pago { get; set; } = null!;
        public string pagoMonto { get; set; } = null!;

        public List<FacturasExtrajerasFEDRequest> items { get; set; } = new List<FacturasExtrajerasFEDRequest>();


        public List<FormapagoFE> formas_pago_factura { get; set; } = new List<FormapagoFE>();
 
    }
}
