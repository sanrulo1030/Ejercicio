using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio.Web.Models
{
    public class Municipio
    {


        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        public string Name { get; set; }

        public ICollection<Alumno> Alumnoes { get; set; }
        [DisplayName("Alumnoes Number")]
        public int AlumnoesNumber => Alumnoes == null ? 0 : Alumnoes.Count;

        public ICollection<Barrio> Barrios { get; set; }
        [DisplayName("Barrios Number")]
        public int BarriosNumber => Barrios == null ? 0 : Barrios.Count;
    }
}
