using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_Negocio.Models
{
    public class TipoConsultaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Tipo_Consulta { get; set; }

        [Required]
        public string Descripcion_Tipo_Consulta { get; set; }




        [Required]
        [Column(TypeName = "decimal (18,4)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Precio_Tipo_Consulta { get; set; }

    }
}
