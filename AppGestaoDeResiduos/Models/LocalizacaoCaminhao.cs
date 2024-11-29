using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_localizacao_caminhao")]
    [Index(nameof(LocalizacaoCaminhao), IsUnique = true)]
    public class LocalizacaoCaminhao
    {
        [Key]
        [Column("localizacao_caminhao_id")]
        public int LocalizacaoCaminhaoId { get; set; }

        [Required]
        [Column("latitude")]
        public int Latitude { get; set; }

        [Required]
        [Column("longitude")]
        public int Longitude { get; set; }

        [Required]
        [Column("data_hora")]
        public DateTime DataEHora { get; set; } // Pegar tempo real (minutos)



        //RELACIONAMENTOS
        // Uma localização só pode ter um caminhao
        public Caminhao Caminhao { get; set; }
        [Column("caminhao_id")]
        public int CaminhaoId { get; set; }
        // \RELACIONAMENTOS

    }
}
