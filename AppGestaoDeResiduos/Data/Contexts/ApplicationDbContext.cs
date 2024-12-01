using AppGestaoDeResiduos.Models;
using Microsoft.EntityFrameworkCore;
using static AppGestaoDeResiduos.Models.UsuarioColeta;

public class ApplicationDbContext : DbContext
{
    public DbSet<Caminhao>? Caminhoes { get; set; }
    public DbSet<Coleta>? Coletas { get; set; }
    public DbSet<Usuario>? Usuarios { get; set; }
    public DbSet<Notificacao>? Notificacoes { get; set; }
    public DbSet<Endereco>? Enderecos { get; set; }
    public DbSet<Localizacao>? LocalizacoesCaminhoes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configuração do Oracle (esta no meu usuário)
        optionsBuilder.UseOracle("User Id=rm553989;Password=200794;Data Source=oracle.fiap.com.br:1521/orcl");
    }
}
