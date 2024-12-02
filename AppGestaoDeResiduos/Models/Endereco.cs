using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnderecoId { get; set; }

        public int? Cep { get; set; }

        [MaxLength(50)]
        public string? Estado { get; set; }

        [MaxLength(50)]
        public string? Cidade { get; set; }

        [MaxLength(100)]
        public string? Rua { get; set; }

        public int? Numero { get; set; }

        public ICollection<Usuario>? Usuarios { get; set; }
    }

}
