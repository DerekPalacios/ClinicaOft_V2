using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Capa_Logica_Negocio.Models
{
    public class CitaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Cita { get; set; }

        [Required]
        public DateTime Fecha_Cita { get; set; }
        [Required]
        public int IdPaciente_Cita { get; set; }
        [ForeignKey("IdPaciente_Cita")]
        public virtual PacienteModel Paciente { get; set; }


        [Required]
        public int IdOftalmologo_Cita { get; set; }
        [ForeignKey("IdOftalmologo_Cita")]
        public OftalmologoModel Oftalmologo { get; set; }

        [Required]
        public int IdCliente_Cita { get; set; }
        [ForeignKey("IdCliente_Cita")]
        public virtual ClienteModel Cliente { get; set; }

        [Required]
        public int IdTipoConsulta_Cita { get; set; }
        [ForeignKey("IdTipoConsulta_Cita")]
        public virtual TipoConsultaModel TipoConsulta { get; set; }

        [Required]
        public bool Estado_Cita { get; set; }
        
        [Required]
        public DateTime Fecha_Programacion_Cita { get; set; }


    }
}
