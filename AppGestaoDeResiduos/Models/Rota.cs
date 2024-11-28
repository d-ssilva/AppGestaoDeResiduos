using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_rota")]
    [Index(nameof(Rota), IsUnique = true)]
    public class Rota
    {
    }
}
