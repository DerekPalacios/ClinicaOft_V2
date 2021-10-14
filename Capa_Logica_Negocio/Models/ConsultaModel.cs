using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_Negocio.Models
{
    public class ConsultaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Consulta { get; set; }

        [Required]
        public DateTime Fecha_Consulta { get; set; }

        [Required]
        [MinLength(10,ErrorMessage ="Ingrese una Descripción Válida")]
        public string Descripcion_Consulta { get; set; }

        [Required]
        public int IdPaciente_Consulta { get; set; }
        [ForeignKey("IdPaciente_Consulta")]
        public virtual PacienteModel Paciente { get; set; }

        [Required]
        public int IdTipoConsulta_Consulta { get; set; }
        [ForeignKey("IdTipoConsulta_Consulta")]
        public virtual TipoConsultaModel TipoConsulta { get; set; }
        
        
        public bool Cita_Cita_Previa_Consulta { get; set; } 
        public int IdCita_Consulta { get; set; }
        [ForeignKey("IdCita_Consulta")]
        public virtual  CitaModel Cita { get; set; }


        [Required]
        public int IdOftalmologo_Consulta { get; set; }
        [ForeignKey("IdOftalmologo_Consulta")]
        public virtual OftalmologoModel Oftalmologo { get; set; }
    }
}
