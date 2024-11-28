using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_rota")]
    [Index(nameof(Rota), IsUnique = true)]
    public class Rota
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
