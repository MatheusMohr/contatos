using System.ComponentModel.DataAnnotations;

namespace SistemaContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }
        [Required(ErrorMessage="O campo nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo e-mail é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo celular é obrigatório")]
        public string Celular { get; set; }
    }
}
