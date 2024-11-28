using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_localizacao_caminhao")]
    [Index(nameof(LocalizacaoCaminhao), IsUnique = true)]
    public class LocalizacaoCaminhao
    {

    }
}
