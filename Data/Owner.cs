using System.ComponentModel.DataAnnotations;

namespace Veterinaria.Data
{
    public class Owner
    {
        [Key]
        public int IdOwner { get; set; }

        [Required(ErrorMessage = "El CUIL es obligatorio.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "El CUIL debe tener 11 dígitos.")]
        public string Cuil { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "El DNI es obligatorio.")]
        [StringLength(8, MinimumLength = 7, ErrorMessage = "El DNI debe tener entre 7 y 8 dígitos.")]
        public string Dni { get; set; } = string.Empty;

        [Required(ErrorMessage = "El domicilio es obligatorio.")]
        public string Domicilio { get; set; } = string.Empty;

        // --- NUEVOS CAMPOS ---
        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        public string Telefono { get; set; } = string.Empty;
        // ---------------------

        public virtual ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }
}