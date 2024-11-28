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
        public int CaminhaoId { get; set; }

        [Required]
        public string Placa { get; set; }

        [Required]
        public int Capacidade { get; set; }
        

        //RELACIONAMENTO
        //Um caminhão tem apenas uma localização 
        // e uma coleta
        public LocalizacaoCaminhao? LocalizacaoCaminhao { get; set; }
        public  Coleta Coleta { get; set; }
        public int ColetaId { get; set; }

        // \RELACIONAMENTO




    }
}
