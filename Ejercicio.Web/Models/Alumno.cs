using System.ComponentModel.DataAnnotations;

namespace Ejercicio.Web.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        public string Nombres { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        public string Apellidos { get; set; }

      
        [Required]
        public int Documento { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        public string Direccion { get; set; }

        [Required]
        public int Telefono { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        public int Grado { get; set; }

   
        [Required]
        public int Edad { get; set; }
    }
}
