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
    [Migration("20221030195204_relacionamento")]
    partial class relacionamento
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("OnibusId")
                        .HasColumnType("int");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Salario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OnibusId")
                        .IsUnique();

                    b.ToTable("Motoristas");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Onibus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CobradorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CobradorId");

                    b.ToTable("Onibus");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Passageiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.Property<int?>("OnibusId")
                        .HasColumnType("int");

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DestinoChegada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinoSaida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioChegada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioSaida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preco")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Passagem");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Motorista", b =>
                {
                    b.HasOne("ProjetoMinsait.Models.Onibus", "Onibus")
                        .WithOne("Motorista")
                        .HasForeignKey("ProjetoMinsait.Models.Motorista", "OnibusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Onibus");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Onibus", b =>
                {
                    b.HasOne("ProjetoMinsait.Models.Cobrador", "Cobrador")
                        .WithMany()
                        .HasForeignKey("CobradorId");

                    b.Navigation("Cobrador");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Passageiro", b =>
                {
                    b.HasOne("ProjetoMinsait.Models.Onibus", null)
                        .WithMany("PassageiroList")
                        .HasForeignKey("OnibusId");
                });

            modelBuilder.Entity("ProjetoMinsait.Models.Onibus", b =>
                {
                    b.Navigation("Motorista");

                    b.Navigation("PassageiroList");
                });
#pragma warning restore 612, 618
        }
    }
}
