using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Data
{
    public class Dueño
    {
        public int IdDueño { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "El DNI es obligatorio.")]
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "El DNI debe tener 8 dígitos.")]
        public int Dni { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateTime? FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El domicilio es obligatorio.")]
        public string Domicilio { get; set; } = string.Empty;

        [Required(ErrorMessage = "El sexo es obligatorio.")]
        public string Sexo { get; set; } = string.Empty;

    }
}
