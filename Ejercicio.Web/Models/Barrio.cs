using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio.Web.Models
{
    public class Barrio
    {


        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        public string Name { get; set; }

        public ICollection<Alumno> Alumnoes { get; set; }
        [DisplayName("Alumnoes Number")]
        public int AlumnoesNumber => Alumnoes == null ? 0 : Alumnoes.Count;
    }
}
