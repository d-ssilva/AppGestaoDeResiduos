using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    public class Notificacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? NotificacaoId { get; set; }

        [MaxLength(250)]
        public string? Mensagem { get; set; }

        public ICollection<UsuarioNotificacao>? UsuarioNotificacoes { get; set; }
    }

}
