using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capa_Logica_Negocio.Models
{
    public class CuentaClienteModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Cuenta { get; set; }


        [Required]
        [Column(TypeName = "decimal (18,4)")]
        [Display(Name = "Saldo")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Saldo_Cuenta {  get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0: dd / MM / yyyy}")]
        [Display(Name = "Fecha Creación")]
        public DateTime Fecha_Cuenta { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0: dd / MM / yyyy}")]
        [Display(Name = "Fecha Cancelación")]
        public DateTime Fecha_Cancelacion_Cuenta { get; set; }

        [Required]
        [Display(Name ="Saldada")]
        public bool Saldada { get; set; }

        [Required]
        public int IdCliente_Cuenta { get; set; }

        [ForeignKey("IdCliente_Cuenta")]
        public ClienteModel Cliente { get; set; }

    }
}
