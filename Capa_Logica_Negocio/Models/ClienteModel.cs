using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capa_Logica_Negocio.Models
{
    public class ClienteModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Cliente { get; set; }


        [Required(ErrorMessage = " Especifique un Nombre Válido ")]
        [StringLength(200, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombres")]
        public string Nombres_Cliente { get; set; }

        [Required(ErrorMessage = " Especifique un Apellido Válido ")]
        [StringLength(200, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Apellidos")]
        public string Apellidos_Cliente { get; set; }

        [Required(ErrorMessage = " Especifique un Número Telefónico Válido ")]
        [StringLength(12, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 8)]
        [Display(Name = "Teléfono")]
        public string Telefono_Cliente { get; set; }

        [Required(ErrorMessage = " Especifique una Dirección Válida ")]
        [MinLength(10, ErrorMessage = " Especifique una Dirección Válida")]
        [Display(Name = "Dirección")]
        public string Direccion_Cliente { get; set; }
    }
}
