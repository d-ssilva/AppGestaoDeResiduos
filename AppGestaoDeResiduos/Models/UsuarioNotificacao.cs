using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    public class UsuarioNotificacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioNotificacaoId { get; set; }

        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }

        public int NotificacaoId { get; set; }
        [ForeignKey("NotificacaoId")]
        public Notificacao? Notificacao { get; set; }

        public DateTime DataNotificacao { get; set; }
    }

}
