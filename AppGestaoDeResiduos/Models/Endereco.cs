using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_rota")]
    [Index(nameof(Endereco), IsUnique = true)]
    public class Endereco
    {
        [Key]
        [Column("endereco_id")]
        public int EnderecoId { get; set; }

        [Required]
        [MaxLength(7)]
        [Column("cep")]
        public int Cep { get; set; }


        [Required]
        [Column("estado")]
        public string Estado { get; set; }

        [Required]
        [StringLength(20)]
        [Column("cidade")]
        public string? Cidade { get; set; }

        [Required]
        [StringLength(200)]
        [Column("rua")]
        public string Rua { get; set; }

        [Required]
        [Column("numero")]
        public int Numero { get; set; }       
        


        //RELACIONAMENTO
        // Um Endereço tem apenas uma usuário
        // e uma coleta
        public Usuario Usuario { get; set; }
        [Column("usuario_id")]
        public int UsuarioId { get; set; }

        public Coleta Coleta { get; set; }
        [Column("coleta_id")]
        public int ColetaId { get; set; }

        // \RELACIONAMENTO
    }
}
