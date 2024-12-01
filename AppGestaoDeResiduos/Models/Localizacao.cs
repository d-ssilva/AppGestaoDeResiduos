using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_localizacao")]
    [Index(nameof(Localizacao), IsUnique = true)]
    public class Localizacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("localizacao_id")]
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
    }
}
