using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capa_Logica_Negocio.Models
{
    public class CreditoConsultaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Credito_Consulta { get; set; }

        [Required]
        public int IdFacturaConsulta_Credito_Consulta { get; set; }
        [ForeignKey("IdFacturaConsulta_Credito_Consulta")]
        public FacturaConsultaModel FacturaConsulta { get; set; }

        [Required]
        public DateTime Fecha_Credito_Consulta { get; set; }

        [Required]
        public int IdCuentaCliente_Credito_Consulta { get; set; }
        [ForeignKey("IdCuentaCliente_Credito_Consulta")]
        public CuentaClienteModel CuentaCliente { get; set; }

        [Required]
        [Column(TypeName ="decimal (18,4")]
        public decimal Monto_Credito_Consulta { get; set; }

        [Required]
        public string Decripcion_Credito_Consulta { get; set; }

    }
}
