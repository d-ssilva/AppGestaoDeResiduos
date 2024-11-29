using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AppGestaoDeResiduos.Models.UsuarioColeta;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_caminhao")]
    [Index(nameof(Caminhao),IsUnique = true)]
    public class Caminhao
    {
        [Key]
        [Column("caminhao_id")]
        public int CaminhaoId { get; set; }

        [Required]
        [Column("placa")]
        public string Placa { get; set; }

        [Required]
        [Column("qtd_de_coletas")]
        public int QtdColetas { get; set; }

        [Required]
        [Column("qtd_de_coletas_max")]
        public int QtdColetasMaxima { get; set; }
        

        //RELACIONAMENTO
        //Um caminhão tem apenas uma localização 
        //Um caminhão tem muitas coletas
        public Localizacao? LocalizacaoCaminhao { get; set; }
        [Column("localizacao_id")]
        public int LocalizacaoId { get; set; }       
        
        // Relacionamento N:N com Coleta
        public virtual ICollection<CaminhaoColeta> CaminhaoColetas { get; set; }

        // \RELACIONAMENTO




    }
}
