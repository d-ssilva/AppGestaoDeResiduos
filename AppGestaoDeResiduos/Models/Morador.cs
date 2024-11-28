﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestaoDeResiduos.Models
{
    [Table("tb_morador")]
    [Index(nameof(Morador), IsUnique = true)]
    public class Morador
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Email { get; set; }

    }
}
