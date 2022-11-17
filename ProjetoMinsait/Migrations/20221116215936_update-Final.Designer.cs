﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoMinsait.Data;

#nullable disable

namespace ProjetoMinsait.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221116215936_update-Final")]
    partial class updateFinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoMinsait.Models.Cobrador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OnibusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("Salario")
                        .HasColumnType("float");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("OnibusId")
                        .IsUnique()
                        .HasFilter("[OnibusId] IS NOT NULL");

                    b.ToTable("Cobradores");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Motorista", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cnh")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OnibusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("Salario")
                        .HasColumnType("float");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("OnibusId")
                        .IsUnique()
                        .HasFilter("[OnibusId] IS NOT NULL");

                    b.ToTable("Motoristas");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Onibus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeViacao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Onibus");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Passageiro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Assento")
                        .HasColumnType("int");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PassagemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("Seguro")
                        .HasColumnType("bit");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<double>("ValorPassagem")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PassagemId");

                    b.ToTable("Passageiros");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Passagem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DestinoChegada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinoSaida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioChegada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioSaida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OnibusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("PrecoPassagem")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OnibusId")
                        .IsUnique()
                        .HasFilter("[OnibusId] IS NOT NULL");

                    b.ToTable("Passagem");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Cobrador", b =>
                {
                    b.HasOne("ProjetoMinsait.Models.Onibus", "Onibus")
                        .WithOne("Cobrador")
                        .HasForeignKey("ProjetoMinsait.Models.Cobrador", "OnibusId");

                    b.Navigation("Onibus");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Motorista", b =>
                {
                    b.HasOne("ProjetoMinsait.Models.Onibus", "Onibus")
                        .WithOne("Motorista")
                        .HasForeignKey("ProjetoMinsait.Models.Motorista", "OnibusId");

                    b.Navigation("Onibus");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Passageiro", b =>
                {
                    b.HasOne("ProjetoMinsait.Models.Passagem", "Passagem")
                        .WithMany("Passageiros")
                        .HasForeignKey("PassagemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Passagem");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Passagem", b =>
                {
                    b.HasOne("ProjetoMinsait.Models.Onibus", "Onibus")
                        .WithOne("Passagem")
                        .HasForeignKey("ProjetoMinsait.Models.Passagem", "OnibusId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Onibus");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Onibus", b =>
                {
                    b.Navigation("Cobrador");

                    b.Navigation("Motorista");

                    b.Navigation("Passagem");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Passagem", b =>
                {
                    b.Navigation("Passageiros");
                });
#pragma warning restore 612, 618
        }
    }
}
