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
    [Migration("20221107211821_relacionamentos")]
    partial class relacionamentos
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Salario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cobradores");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Motorista", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MotoristaOnibusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Salario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MotoristaOnibusId")
                        .IsUnique();

                    b.ToTable("Motoristas");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Onibus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("OnibusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<bool?>("Seguro")
                        .HasColumnType("bit");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OnibusId");

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

                    b.Property<Guid>("PassageiroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PrecoPassagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PassageiroId")
                        .IsUnique();

                    b.ToTable("Passagem");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Motorista", b =>
                {
                    b.HasOne("ProjetoMinsait.Models.Onibus", "MotoristaOnibus")
                        .WithOne("Motorista")
                        .HasForeignKey("ProjetoMinsait.Models.Motorista", "MotoristaOnibusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MotoristaOnibus");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Passageiro", b =>
                {
                    b.HasOne("ProjetoMinsait.Models.Onibus", "Onibus")
                        .WithMany("ListaPassageiros")
                        .HasForeignKey("OnibusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Onibus");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Passagem", b =>
                {
                    b.HasOne("ProjetoMinsait.Models.Passageiro", "Passageiro")
                        .WithOne("Passagem")
                        .HasForeignKey("ProjetoMinsait.Models.Passagem", "PassageiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passageiro");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Onibus", b =>
                {
                    b.Navigation("ListaPassageiros");

                    b.Navigation("Motorista");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Passageiro", b =>
                {
                    b.Navigation("Passagem");
                });
#pragma warning restore 612, 618
        }
    }
}