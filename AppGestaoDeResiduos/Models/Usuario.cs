using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_morador")]
    [Index(nameof(Usuario), IsUnique = true)]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("usuario_id")]
        public int UsuarioId { get; set; }

        [Required]
        [StringLength(20)]
        [Column("nome")]
        public string Nome { get; set; }       

        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Column("email")]
        public string? Email { get; set; }

        [Column("agendou_coleta")]
        public Boolean AgendouColeta = false;

        [Column("foi_notificado")]
        public Boolean FoiNotificado = false;       

        //RELACIONAMENTO
        // Um usuário tem apenas um endereço
        // e um usuário pode ter muitas notificações
        public Endereco Endereco { get; set; }
        [Column("endereco_id")]
        public int EnderecoId { get; set; }
        public virtual ICollection<Notificacao> Notificacoes { get; set; }

        public virtual ICollection<Coleta> Coletas { get; set; }

        // \RELACIONAMENTO

    }
}
