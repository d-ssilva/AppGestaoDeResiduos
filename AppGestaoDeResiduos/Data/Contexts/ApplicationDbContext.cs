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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuração de tb_caminhao
        modelBuilder.Entity<Caminhao>(entity =>
        {
            entity.ToTable("tb_caminhao");
            entity.HasKey(e => e.CaminhaoId);
            entity.Property(e => e.Placa).HasColumnName("placa").HasMaxLength(7);
            entity.Property(e => e.QtdColetas).HasColumnName("qtd_de_coletas");
            entity.Property(e => e.QtdColetasMaxima).HasColumnName("qtd_de_coletas_max");           
        });

        // Configuração de tb_coleta
        modelBuilder.Entity<Coleta>(entity =>
        {
            entity.ToTable("tb_coleta");
            entity.HasKey(e => e.ColetaId);
            entity.Property(e => e.DataDaColeta).HasColumnName("data_coleta");
            entity.Property(e => e.QtdColeta).HasColumnName("qtd_de_coleta");
            entity.HasOne(d => d.Endereco)
                .WithMany()
                .HasForeignKey(d => d.EnderecoId)
                .OnDelete(DeleteBehavior.Cascade);            
        });

        // Configuração de tb_localizacao_caminhao
        modelBuilder.Entity<Localizacao>(entity =>
        {
            entity.ToTable("tb_localizacao_caminhao");
            entity.HasKey(e => e.LocalizacaoCaminhaoId);
            entity.Property(e => e.Latitude).HasColumnName("latitude").HasColumnType("NUMBER(9, 6)");
            entity.Property(e => e.Longitude).HasColumnName("longitude").HasColumnType("NUMBER(9, 6)");
            entity.Property(e => e.DataEHora).HasColumnName("data_hora");
            entity.HasOne(d => d.Caminhao)
                .WithMany()
                .HasForeignKey(d => d.CaminhaoId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configuração de tb_usuario
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("tb_usuario");
            entity.HasKey(e => e.UsuarioId);
            entity.Property(e => e.Nome).HasColumnName("nome").HasMaxLength(20);
            entity.Property(e => e.Email).HasColumnName("email").IsRequired().HasMaxLength(100);
            entity.Property(e => e.AgendouColeta).HasColumnName("agendou_coleta");
            entity.Property(e => e.FoiNotificado).HasColumnName("foi_notificado");
            entity.HasOne(d => d.Endereco)
                .WithMany()
                .HasForeignKey(d => d.EnderecoId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(d => d.Notificacao)
                .WithMany()
                .HasForeignKey(d => d.NotificacaoId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(d => d.Coleta)
                .WithMany()
                .HasForeignKey(d => d.ColetaId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        // Configuração de tb_notificacao
        modelBuilder.Entity<Notificacao>(entity =>
        {
            entity.ToTable("tb_notificacao");
            entity.HasKey(e => e.NotificacaoId);
            entity.Property(e => e.Mensagem).HasColumnName("mensagem").HasMaxLength(250);
            entity.Property(e => e.DataDeEnvio).HasColumnName("data_envio");
        });

        // Configuração de tb_endereco
        modelBuilder.Entity<Endereco>(entity =>
        {
            entity.ToTable("tb_endereco");
            entity.HasKey(e => e.EnderecoId);
            entity.Property(e => e.Cep).HasColumnName("cep");
            entity.Property(e => e.Estado).HasColumnName("estado").HasMaxLength(2);
            entity.Property(e => e.Cidade).HasColumnName("cidade");
            entity.Property(e => e.Rua).HasColumnName("rua").HasMaxLength(150);
            entity.Property(e => e.Numero).HasColumnName("numero");
        });

        // Relacionamento Caminhao e Coleta N:N
        modelBuilder.Entity<CaminhaoColeta>()
    .       HasKey(cc => new { cc.CaminhaoId, cc.ColetaId });

        modelBuilder.Entity<CaminhaoColeta>()
            .HasOne(cc => cc.Caminhao)
            .WithMany(c => c.CaminhaoColetas)
            .HasForeignKey(cc => cc.CaminhaoId);

        modelBuilder.Entity<CaminhaoColeta>()
            .HasOne(cc => cc.Coleta)
            .WithMany(c => c.CaminhaoColetas)
            .HasForeignKey(cc => cc.ColetaId);

    }
}
