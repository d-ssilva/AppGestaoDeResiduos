using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_notificacao")]
    [Index(nameof(Notificacao), IsUnique = true)]
    public class Notificacao
    {        
        public int Id { get; set; }
        public string? Mensagem { get; set; }
        public DateOnly DataDeEnvio { get; set; }
    }
}
