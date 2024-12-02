using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    public class Localizacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocalizacaoId { get; set; }

        public int? Longitude { get; set; }
        public int? Latitude { get; set; }
        public DateTime DataHora { get; set; }

        public ICollection<Caminhao>? Caminhoes { get; set; }
    }

}
