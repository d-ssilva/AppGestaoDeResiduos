using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_coleta")]
    [Index(nameof(Caminhao), IsUnique = true)]
    public class Coleta
    {

        [Key]
        [Column("coleta_id")]
        public int ColetaId { get; set; }

        [Column("qtd_de_coleta")]
        public int QtdColeta { get; set; }         

        [Column("data_coleta")]
        public DateOnly DataDaColeta { get; set; } // Pegar data da coleta


        //RELACIONAMENTOS
        // Uma coleta tem apenas um caminhao e um endereço
        public Caminhao Caminhao { get; set; }

        [Column("caminhao_id")]
        public int CaminhaoId { get; set; }


        public Endereco Endereco { get; set; }

        [Column("endereco_id")]
        public int EnderecoId { get; set; }

        // \RELACIONAMENTOS
    }
}
