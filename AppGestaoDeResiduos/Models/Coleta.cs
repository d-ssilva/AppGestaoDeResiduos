using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    public class Coleta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColetaId { get; set; }

        public int QtdDeColeta { get; set; }
        public DateTime DataColeta { get; set; }

        public int EnderecoId { get; set; }
        [ForeignKey("EnderecoId")]
        public Endereco Endereco { get; set; }

        public int CaminhaoId { get; set; }
        [ForeignKey("CaminhaoId")]
        public Caminhao Caminhao { get; set; }

        public ICollection<UsuarioColeta> UsuarioColetas { get; set; }
    }

}
