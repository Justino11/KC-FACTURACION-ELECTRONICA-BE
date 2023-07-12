namespace KC_FACTURACION_ELECTRONICA.Models
{
    public class V_Fe_FacDatosGenerales_Pac
    {
        public string? DataAreaId { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public string InvoiceAddressCountryRegionISOCode { get; set; } = null!;

        public int destino_operacion { get; set; }

        public string emisor_codigo_sucursal { get; set; } = null!;

        public DateTime fecha_contingencia { get; set; }

        public DateTime fecha_emision { get; set; }

        public DateTime fecha_salida { get; set; }

        public int formato_generacion_cafe { get; set; }

        public int manera_entrega_cafe { get; set; }

        public string naturaleza_operacion { get; set; } = null!;

        public string? numero_documento_fiscal { get; set; }

        public string? proceso_generacion_cafe { get; set; }

        public string punto_facturacion { get; set; } = null!;

        public string tipo_documento { get; set; } = null!;

        public string tipo_emision { get; set; } = null!;

        public string tipo_transaccion_venta { get; set; } = null!;

        public string? receptor_correo { get; set; }

        public string? receptor_digito_verificador { get; set; }

        public string? receptor_direccion { get; set; }

        public string? receptor_extranjero_identificacion { get; set; }

        public string receptor_extranjero_pais { get; set; } = null!;

        public string? receptor_nombre { get; set; }

        public string receptor_pais { get; set; } = null!;

        public string? receptor_ruc { get; set; }

        public string? receptor_telefono { get; set; }

        public string receptor_tipo { get; set; } = null!;

        public string receptor_tipo_contribuyente { get; set; } = null!;

        public int tiempo_pago { get; set; }

        public int Formas_de_pago { get; set; }

        public decimal pagoMonto { get; set; }

        public int cuotaNumero { get; set; }

        public DateTime? cuotaFecha { get; set; }

        public decimal cuotaMonto { get; set; }

        public string cuotaInformacion { get; set; } = null!;

        public string exportacion_condiciones_entrega { get; set; } = null!;

        public string exportacion_moneda_operacion { get; set; } = null!;

        public string exportacion_moneda_operacion_descripcion { get; set; } = null!;

        public int exportacion_moneda_tipo_cambio { get; set; }

        public string exportacion_puerto_embarque { get; set; } = null!;
    }
}
