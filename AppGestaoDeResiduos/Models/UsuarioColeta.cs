using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_usuario_coleta")]
    [Index(nameof(UsuarioColeta), IsUnique = true)]
    public class UsuarioColeta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("usuario_coleta_id")]
        public int UsuarioColetaId { get; set; }

        public Usuario Usuario { get; set; }
        [Column("usuario_id")]
        public int UsuarioId { get; set; }



        public Coleta Coleta { get; set; }
        [Column("coleta_id")]
        public int ColetaId { get; set; }

    }
}
