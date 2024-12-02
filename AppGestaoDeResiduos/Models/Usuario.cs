using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Nome { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public bool? AgendouColeta { get; set; }
        [Required]
        public bool? FoiNotificado { get; set; }

        public int? EnderecoId { get; set; }
        [ForeignKey("EnderecoId")]
        public Endereco? Endereco { get; set; }

        public ICollection<UsuarioNotificacao>? UsuarioNotificacoes { get; set; }
        public ICollection<UsuarioColeta>? UsuarioColetas { get; set; }
    }
}
