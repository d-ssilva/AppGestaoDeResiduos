using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_morador")]
    [Index(nameof(Morador), IsUnique = true)]
    public class Morador
    {
    }
}
