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
        public int UsuarioColetaId { get; set; }

        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }



        public Coleta Coleta { get; set; }
        public int ColetaId { get; set; }

    }
}
