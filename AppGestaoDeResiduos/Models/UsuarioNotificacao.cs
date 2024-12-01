using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_usuario_notificacao")]
    [Index(nameof(UsuarioNotificacao), IsUnique = true)]
    public class UsuarioNotificacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("usuario_notificacao_id")]
        public int UsuarioNotificacaoId { get; set; }

        public Usuario Usuario { get; set; }
        [Column("usuario_id")]
        public int UsuarioId { get; set; }



        public Notificacao Notificacao { get; set; }
        [Column("notificacao_id")]
        public int NotificacaoId { get; set; }
        
    }
}
