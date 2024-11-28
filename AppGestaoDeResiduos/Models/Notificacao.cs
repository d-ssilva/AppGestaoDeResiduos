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
        public int NotificacaoId { get; set; }

        [Required]
        [StringLength(300)]
        public string? Mensagem { get; set; }

        [Required]
        public DateOnly DataDeEnvio { get; set; }


        //RELACIONAMENTO
        // Uma notificação tem apenas um usuário
        [ForeignKey("UsuarioId")] // Relacionamento N:1
        public virtual Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }

        // \RELACIONAMENTO
    }
}
