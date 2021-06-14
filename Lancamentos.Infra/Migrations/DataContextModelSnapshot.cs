﻿// <auto-generated />
using System;
using Lancamentos.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lancamentos.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lancamentos.Domain.Entities.Desenvolvedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cargo")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Nome")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<Guid?>("ProjetoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Desenvolvedor");
                });

            modelBuilder.Entity("Lancamentos.Domain.Entities.Lancamento", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Lancamento");
                });

            modelBuilder.Entity("Lancamentos.Domain.Entities.Projeto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeProjeto")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Tipo")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasDatabaseName("ProjetoId");

                    b.ToTable("Projeto");
                });

            modelBuilder.Entity("Lancamentos.Domain.Entities.Desenvolvedor", b =>
                {
                    b.HasOne("Lancamentos.Domain.Entities.Projeto", "Projeto")
                        .WithMany("Desenvolvedors")
                        .HasForeignKey("ProjetoId");

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("Lancamentos.Domain.Entities.Lancamento", b =>
                {
                    b.HasOne("Lancamentos.Domain.Entities.Desenvolvedor", "Desenvolvedor")
                        .WithMany("Lancamentos")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desenvolvedor");
                });

            modelBuilder.Entity("Lancamentos.Domain.Entities.Desenvolvedor", b =>
                {
                    b.Navigation("Lancamentos");
                });

            modelBuilder.Entity("Lancamentos.Domain.Entities.Projeto", b =>
                {
                    b.Navigation("Desenvolvedors");
                });
#pragma warning restore 612, 618
        }
    }
}
