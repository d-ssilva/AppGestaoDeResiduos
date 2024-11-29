using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_notificacao")]
    [Index(nameof(Notificacao), IsUnique = true)]
    public class Notificacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("notificacao_id")]
        public int NotificacaoId { get; set; }

        [Required]
        [StringLength(300)]
        [Column("mensagem")]
        public string? Mensagem { get; set; }

        [Required]
        [Column("data_de_envio")]
        public DateOnly DataDeEnvio { get; set; }


        //RELACIONAMENTO
        // Uma notificação tem apenas um usuário
        // Relacionamento N:N com Usuario
        public virtual ICollection<UsuarioNotificacao> UsuarioNotificacoes { get; set; }

        // \RELACIONAMENTO
    }
}
