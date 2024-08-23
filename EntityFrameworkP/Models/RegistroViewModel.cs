using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkP.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [EmailAddress(ErrorMessage ="El campo debe ser un correo electrinico valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
