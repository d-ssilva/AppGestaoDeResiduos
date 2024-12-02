﻿// <auto-generated />
using System;
using AppGestaoDeResiduos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace AppGestaoDeResiduos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Caminhao", b =>
                {
                    b.Property<int>("CaminhaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaminhaoId"));

                    b.Property<int>("LocalizacaoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("NVARCHAR2(7)");

                    b.Property<int>("QtdDeColetas")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("QtdDeColetasMax")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CaminhaoId");

                    b.HasIndex("LocalizacaoId");

                    b.ToTable("Caminhoes");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Coleta", b =>
                {
                    b.Property<int>("ColetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColetaId"));

                    b.Property<int>("CaminhaoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("DataColeta")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("QtdDeColeta")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("ColetaId");

                    b.HasIndex("CaminhaoId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Coletas");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnderecoId"));

                    b.Property<int>("Cep")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<int>("Numero")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Localizacao", b =>
                {
                    b.Property<int>("LocalizacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocalizacaoId"));

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("Latitude")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Longitude")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("LocalizacaoId");

                    b.ToTable("Localizacoes");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Notificacao", b =>
                {
                    b.Property<int>("NotificacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificacaoId"));

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("NVARCHAR2(250)");

                    b.HasKey("NotificacaoId");

                    b.ToTable("Notificacoes");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<bool>("AgendouColeta")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<bool>("FoiNotificado")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.HasKey("UsuarioId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.UsuarioColeta", b =>
                {
                    b.Property<int>("UsuarioColetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioColetaId"));

                    b.Property<int>("ColetaId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("UsuarioColetaId");

                    b.HasIndex("ColetaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioColetas");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.UsuarioNotificacao", b =>
                {
                    b.Property<int>("UsuarioNotificacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioNotificacaoId"));

                    b.Property<DateTime>("DataNotificacao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("NotificacaoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("UsuarioNotificacaoId");

                    b.HasIndex("NotificacaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioNotificacoes");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Caminhao", b =>
                {
                    b.HasOne("AppGestaoDeResiduos.Models.Localizacao", "Localizacao")
                        .WithMany("Caminhoes")
                        .HasForeignKey("LocalizacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Localizacao");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Coleta", b =>
                {
                    b.HasOne("AppGestaoDeResiduos.Models.Caminhao", "Caminhao")
                        .WithMany("Coletas")
                        .HasForeignKey("CaminhaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppGestaoDeResiduos.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caminhao");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Usuario", b =>
                {
                    b.HasOne("AppGestaoDeResiduos.Models.Endereco", "Endereco")
                        .WithMany("Usuarios")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.UsuarioColeta", b =>
                {
                    b.HasOne("AppGestaoDeResiduos.Models.Coleta", "Coleta")
                        .WithMany("UsuarioColetas")
                        .HasForeignKey("ColetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppGestaoDeResiduos.Models.Usuario", "Usuario")
                        .WithMany("UsuarioColetas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coleta");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.UsuarioNotificacao", b =>
                {
                    b.HasOne("AppGestaoDeResiduos.Models.Notificacao", "Notificacao")
                        .WithMany("UsuarioNotificacoes")
                        .HasForeignKey("NotificacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppGestaoDeResiduos.Models.Usuario", "Usuario")
                        .WithMany("UsuarioNotificacoes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Notificacao");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Caminhao", b =>
                {
                    b.Navigation("Coletas");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Coleta", b =>
                {
                    b.Navigation("UsuarioColetas");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Endereco", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Localizacao", b =>
                {
                    b.Navigation("Caminhoes");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Notificacao", b =>
                {
                    b.Navigation("UsuarioNotificacoes");
                });

            modelBuilder.Entity("AppGestaoDeResiduos.Models.Usuario", b =>
                {
                    b.Navigation("UsuarioColetas");

                    b.Navigation("UsuarioNotificacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
