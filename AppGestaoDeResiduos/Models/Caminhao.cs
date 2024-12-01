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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        //Um caminhão tem uma localização 
        //Um caminhão tem uma coletas

        public Coleta Coleta { get; set; }
        [Column("coleta_id")]
        public int ColetaId { get; set; }

        public Localizacao? LocalizacaoCaminhao { get; set; }
        [Column("localizacao_id")]
        public int LocalizacaoId { get; set; }       
        
        
        

        // \RELACIONAMENTO




    }
}
