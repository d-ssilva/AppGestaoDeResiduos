using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{ 

    public class Caminhao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CaminhaoId { get; set; }

        [MaxLength(7)]
        public string Placa { get; set; }

        public int QtdDeColetas { get; set; }
        public int QtdDeColetasMax { get; set; }

        public int LocalizacaoId { get; set; }
        [ForeignKey("LocalizacaoId")]
        public Localizacao Localizacao { get; set; }

        public ICollection<Coleta> Coletas { get; set; }
    }
}
