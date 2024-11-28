using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_rota")]
    [Index(nameof(Endereco), IsUnique = true)]
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }

        public string? PontoDeReferencia { get; set; }

        public string Estado { get; set; }

        public int Cep { get; set; }


        //RELACIONAMENTO
        // Um Endereço tem apenas uma usuário
        // e uma coleta
        public Usuario Usuario { get; set; }
        public Coleta Coleta { get; set; }

        // \RELACIONAMENTO
    }
}
