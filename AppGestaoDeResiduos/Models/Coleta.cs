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
        public int Id { get; set; }

        [Column("capacidade_usada")]
        public int CapacidadeUsada { get; set; }
        
        [Column("data_coleta")]
        public DateOnly DataDaColeta { get; set; } // Pegar data da coleta

        public Caminhao Caminhao { get; set; } // Uma coleta para Um caminhao

        public Rota Rota { get; set; } // Uma Coleta para Uma rota

        //Fazer relacionamento com classe Caminhao
        //[HasOne()]
        //public Caminhao CaminhaoId { get; set; }

        //Fazer relacionamento com Classe Rota
        //public Rota RotaId { get; set; }
    }
}
