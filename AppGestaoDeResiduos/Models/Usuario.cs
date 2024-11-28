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
        public int UsuarioId { get; set; }

        [Required]
        [StringLength(20)]
        public string Nome { get; set; }       

        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string? Email { get; set; }

        public Boolean ChamarColeta = false;


        //RELACIONAMENTO
        // Um usuário tem apenas um endereço
        // e um usuário pode ter muitas notificações
        public Endereco Endereco { get; set; }
        public virtual ICollection<Notificacao> Notificacao { get; set; }
        public int NotificacaoId {  get; set; }

        // \RELACIONAMENTO

    }
}
