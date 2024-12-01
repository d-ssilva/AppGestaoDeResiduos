using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_coleta")]
    [Index(nameof(Coleta), IsUnique = true)]
    public class Coleta
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("coleta_id")]
        public int ColetaId { get; set; }

        [Column("qtd_de_coleta")]
        public int QtdColeta { get; set; }                

        [Column("data_coleta")]
        public DateOnly DataDaColeta { get; set; } // Pegar data da coleta


        //RELACIONAMENTOS
        // Uma coleta tem apenas um endereço
        // Uma coleta tem apenas um caminhao
        public Endereco Endereco { get; set; }
        [Column("endereco_id")]
        public int EnderecoId { get; set; }


        public Caminhao Caminhao { get; set; }
        [Column("caminhao_id")]
        public int CaminhaoId { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }

        // \RELACIONAMENTOS
    }
}
