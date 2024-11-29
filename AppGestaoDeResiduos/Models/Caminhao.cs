using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_caminhao")]
    [Index(nameof(Caminhao),IsUnique = true)]
    public class Caminhao
    {
        [Key]
        [Column("caminhao_id")]
        public int CaminhaoId { get; set; }

        [Required]
        [Column("placa")]
        public string Placa { get; set; }

        [Required]
        [Column("capacidade")]
        public int Capacidade { get; set; }

        [Required]
        [Column("qtd_de_coletas")]
        public int QtdColetas { get; set; }

        [Required]
        [Column("qtd_de_coletas_max")]
        public int QtdColetasMaxima { get; set; }
        

        //RELACIONAMENTO
        //Um caminhão tem apenas uma localização 
        // e uma coleta
        public LocalizacaoCaminhao? LocalizacaoCaminhao { get; set; }
        [Column("localizacao_caminhao_id")]
        public int LocalizacaoCaminhaoId { get; set; }
        public  Coleta Coleta { get; set; }
        [Column("coleta_id")]
        public int ColetaId { get; set; }

        // \RELACIONAMENTO




    }
}
