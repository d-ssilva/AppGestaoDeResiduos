using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_localizacao_caminhao")]
    [Index(nameof(LocalizacaoCaminhao), IsUnique = true)]
    public class LocalizacaoCaminhao
    {
        public int Id { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public DateTime DataEHora { get; set; } // Necessário para pegar tempo real
        public Caminhao Caminhao { get; set; } // Uma localização para Um caminhao setar OneToOne

    }
}
