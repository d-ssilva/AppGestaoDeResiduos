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
        public DateTime DataEHora { get; set; } // Pegar tempo real (minutos)

        //RELACIONAMENTOS
        // Uma localização só pode ter um caminhao
        public Caminhao Caminhao { get; set; }
        public int CaminhaoId { get; set; }
        // \RELACIONAMENTOS

    }
}
