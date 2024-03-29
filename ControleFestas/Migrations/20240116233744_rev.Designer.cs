﻿// <auto-generated />
using System;
using ControleFestas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleFestas.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240116233744_rev")]
    partial class rev
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControleFestas.Models.ConvidadoModel", b =>
                {
                    b.Property<int>("ConvidadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConvidadoId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("ConvidadoId");

                    b.HasIndex("EventoId");

                    b.ToTable("Convidado");
                });

            modelBuilder.Entity("ControleFestas.Models.EventoModel", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventoId"));

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioInicial")
                        .HasColumnType("datetime2");

                    b.Property<int>("PromotorId")
                        .HasColumnType("int");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TelefoneResponsavel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EventoId");

                    b.HasIndex("PromotorId");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("ControleFestas.Models.PromotorModel", b =>
                {
                    b.Property<int>("PromotorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PromotorId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Senha")
                        .HasColumnType("int");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("PromotorId");

                    b.ToTable("Promotor");
                });

            modelBuilder.Entity("ControleFestas.Models.ConvidadoModel", b =>
                {
                    b.HasOne("ControleFestas.Models.EventoModel", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("ControleFestas.Models.EventoModel", b =>
                {
                    b.HasOne("ControleFestas.Models.PromotorModel", "Promotor")
                        .WithMany()
                        .HasForeignKey("PromotorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Promotor");
                });
#pragma warning restore 612, 618
        }
    }
}
