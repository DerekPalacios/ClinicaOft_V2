using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capa_Logica_Negocio.Models
{
    public class CreditoConsultaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Credito")]
        public int Id_Credito_Consulta { get; set; }

        [Required]
        [Display(Name = "Factura")]
        public int IdFacturaConsulta_Credito_Consulta { get; set; }
        [ForeignKey("IdFacturaConsulta_Credito_Consulta")]
        public FacturaConsultaModel FacturaConsulta { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        public DateTime Fecha_Credito_Consulta { get; set; }

        [Required]
        [Display(Name = "Cuenta")]
        public int IdCuentaCliente_Credito_Consulta { get; set; }
        [ForeignKey("IdCuentaCliente_Credito_Consulta")]
        public CuentaClienteModel CuentaCliente { get; set; }

        [Required]
        [Display(Name = "Monto")]
        [Column(TypeName ="decimal (18,4")]
        public decimal Monto_Credito_Consulta { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        public string Decripcion_Credito_Consulta { get; set; }

    }
}
