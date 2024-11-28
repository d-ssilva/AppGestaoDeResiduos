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

        [Column("capacidade_usada")]
        public int CapacidadeUsada { get; set; } 
        //  Permitir que o sistema avalie se o caminhão precisa retornar para descarregar
        //  ou se pode atender a outras solicitações.

        [Column("data_coleta")]
        public DateOnly DataDaColeta { get; set; } // Pegar data da coleta


        //RELACIONAMENTOS
        // Uma coleta tem apenas um caminhao e um endereço
        public Caminhao Caminhao { get; set; }
        public int CaminhaoId { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }

        // \RELACIONAMENTOS
    }
}
