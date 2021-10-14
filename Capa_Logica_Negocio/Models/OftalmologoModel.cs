using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capa_Logica_Negocio.Models
{
    public class OftalmologoModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Oftalmologo { get; set; }


        [Required(ErrorMessage = " Especifique un Nombre Válido ")]
        [StringLength(200, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombres")]
        public string Nombres_Oftalmologo { get; set; }

        [Required(ErrorMessage = " Especifique un Apellido Válido ")]
        [StringLength(200, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Apellidos")]
        public string Apellidos_Oftalmologo { get; set; }


        [Required]
        [StringLength(maximumLength:2,MinimumLength =1, ErrorMessage ="Ingrese una edad Valida")]
        public int Edad_Oftalmologo { get; set; }

        [Required(ErrorMessage = " Especifique un Número Telefónico Válido ")]
        [StringLength(12, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 8)]
        [Display(Name = "Teléfono")]
        public string Telefono_Oftalmologo { get; set; }

        [Required(ErrorMessage = " Especifique una Dirección Válida ")]
        [MinLength(10, ErrorMessage = " Especifique una Dirección Válida")]
        [Display(Name = "Dirección")]
        public string Direccion_Oftalmologo { get; set; }

        [Required]
        [MinLength(6,ErrorMessage ="Cadena muy corta para una Especialidad  minStr: {1}")]
        public string Especialidad_Oftalmologo { get; set; }
    }
}
