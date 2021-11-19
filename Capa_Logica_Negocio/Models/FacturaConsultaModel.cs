using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capa_Logica_Negocio.Models
{
    public class FacturaConsultaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Factura_Consulta { get; set; }

        [Required]
        public DateTime Fecha_Factura_Consulta { get; set; }

        [Required]
        public int IdCliente_Factura_Consulta { get; set; }

        [ForeignKey("IdCliente_Factura_Consulta")]
        public ClienteModel Cliente { get; set; }


        [Required]
        public int IdConsulta_Factura_Consulta { get; set; }

        [ForeignKey("IdConsulta_Factura_Consulta")]
        public ConsultaModel Consulta { get; set; }


        [Required]
        public int IdCita_Factura_Consulta { get; set; }
        [ForeignKey("IdCita_Factura_Consulta")]
        public CitaModel Cita { get; set; }
        
        [Column(TypeName ="decimal (18,4)")]
        public decimal IVA_Factura_Consulta { get; set; }

        [Column(TypeName = "decimal (18,4)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal SubTotal_Factura_Consulta { get; set; }

        [Column(TypeName = "decimal (18,4)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Total_Factura_Consulta { get; set; }

        [Required]
        public bool Acreditada_Factura_Consulta { get; set; }

        [Column(TypeName = "decimal (18,4)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Deposito_Factura_Consulta { get; set; }



    }
}
