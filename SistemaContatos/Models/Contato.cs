using System.ComponentModel.DataAnnotations;

namespace SistemaContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }
        [Required(ErrorMessage="O campo nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo e-mail é obrigatório!")]
        [EmailAddress(ErrorMessage ="E-mail inválido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O número de celular é obrigatório!")]
        [Phone(ErrorMessage ="Número do celular inválido!")]
        public string Celular { get; set; }
    }
}
