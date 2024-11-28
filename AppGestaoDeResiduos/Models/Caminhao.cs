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
        public int Id { get; set; }

        [Required]
        public string? Placa { get; set; }

        [Required]
        public int Capacidade { get; set; }




    }
}
