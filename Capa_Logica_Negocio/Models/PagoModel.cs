using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capa_Logica_Negocio.Models
{
    public class PagoModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Pago { get; set; }

        [Required]
        public int IdCuenta_Pago { get; set; }

        [ForeignKey("IdCuenta_Pago")]
        public CuentaClienteModel Cuenta { get; set; }


        [Required]
        public DateTime Fecha_Pago { get; set; }

        [Required]
        public string Concepto_Pago { get; set; }

        [Required]
        public string Pagador_Pago { get; set; }

        [Required]
        [Column(TypeName = "decimal (18,4)")]
        public decimal Monto_Pago { get; set; }

    }
}
