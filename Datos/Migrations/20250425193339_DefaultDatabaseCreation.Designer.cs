﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Datos.Migrations
{
    [DbContext(typeof(ContextoBD))]
    [Migration("20250425193339_DefaultDatabaseCreation")]
    partial class DefaultDatabaseCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entidades.Modelos.E_AreaConocimiento", b =>
                {
                    b.Property<int>("IdAreaConocimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAreaConocimiento"));

                    b.Property<string>("ClaveAreaConocimiento")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("DescripcionAreaConocimiento")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdAreaConocimiento");

                    b.HasIndex("ClaveAreaConocimiento")
                        .IsUnique()
                        .HasDatabaseName("UK_ClaveAreaConocimiento");

                    b.ToTable("AreasConocimiento");
                });

            modelBuilder.Entity("Entidades.Modelos.E_Carrera", b =>
                {
                    b.Property<int>("IdCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarrera"));

                    b.Property<string>("AliasCarrera")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ClaveCarrera")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<bool>("EstadoCarrera")
                        .HasColumnType("bit");

                    b.Property<string>("NombreCarrera")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCarrera");

                    b.HasIndex("AliasCarrera")
                        .IsUnique()
                        .HasDatabaseName("UK_AliasCarrera");

                    b.HasIndex("ClaveCarrera")
                        .IsUnique()
                        .HasDatabaseName("UK_ClaveCarrera");

                    b.HasIndex("NombreCarrera")
                        .IsUnique()
                        .HasDatabaseName("UK_NombreCarrera");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("Entidades.Modelos.E_Etapa", b =>
                {
                    b.Property<int>("IdEtapa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEtapa"));

                    b.Property<string>("ClaveEtapa")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("NombreEtapa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdEtapa");

                    b.HasIndex("ClaveEtapa")
                        .IsUnique()
                        .HasDatabaseName("UK_ClaveEtapa");

                    b.HasIndex("NombreEtapa")
                        .IsUnique()
                        .HasDatabaseName("UK_NombreEtapa");

                    b.ToTable("Etapas");
                });

            modelBuilder.Entity("Entidades.Modelos.E_Materia", b =>
                {
                    b.Property<int>("IdMateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMateria"));

                    b.Property<string>("BibliografiaBasica")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("BibliografiaComplementaria")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<int>("CR")
                        .HasColumnType("int");

                    b.Property<string>("ClaveMateria")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Competencia")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Criterios")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<bool>("EstadoMateria")
                        .HasColumnType("bit");

                    b.Property<string>("Evidencia")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<int>("HC")
                        .HasColumnType("int");

                    b.Property<int>("HCL")
                        .HasColumnType("int");

                    b.Property<int>("HE")
                        .HasColumnType("int");

                    b.Property<int>("HL")
                        .HasColumnType("int");

                    b.Property<int>("HPC")
                        .HasColumnType("int");

                    b.Property<int>("HT")
                        .HasColumnType("int");

                    b.Property<string>("Metodologia")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("NombreMateria")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PathPUA")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PerfilDocente")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("PropositoGeneral")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.HasKey("IdMateria");

                    b.HasIndex("ClaveMateria")
                        .IsUnique()
                        .HasDatabaseName("UK_ClaveCarrera");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("Entidades.Modelos.E_PlanEstudio", b =>
                {
                    b.Property<int>("IdPlanEstudio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlanEstudio"));

                    b.Property<string>("CampoOcupacional")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Comentarios")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<bool>("EstadoPlanEstudio")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCarrera")
                        .HasColumnType("int");

                    b.Property<string>("PerfilDeEgreso")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("PerfilDeIngreso")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("PlanEstudio")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("TotalCreditos")
                        .HasColumnType("int");

                    b.HasKey("IdPlanEstudio");

                    b.HasIndex("IdCarrera");

                    b.HasIndex("PlanEstudio")
                        .IsUnique()
                        .HasDatabaseName("UK_PlaEstudio");

                    b.ToTable("PlanEstudios");
                });

            modelBuilder.Entity("Entidades.Modelos.E_PlanEstudioMateria", b =>
                {
                    b.Property<int>("IdPlanEstudioMateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlanEstudioMateria"));

                    b.Property<int>("IdAreaConocimiento")
                        .HasColumnType("int");

                    b.Property<int>("IdEtapa")
                        .HasColumnType("int");

                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.Property<int>("IdPlanEstudio")
                        .HasColumnType("int");

                    b.Property<int>("Semestre")
                        .HasColumnType("int");

                    b.HasKey("IdPlanEstudioMateria");

                    b.HasIndex("IdAreaConocimiento");

                    b.HasIndex("IdEtapa");

                    b.HasIndex("IdMateria");

                    b.HasIndex("IdPlanEstudio");

                    b.ToTable("PlanEstudioMaterias");
                });

            modelBuilder.Entity("Entidades.Modelos.E_PlanEstudio", b =>
                {
                    b.HasOne("Entidades.Modelos.E_Carrera", "Carrera")
                        .WithMany("PlanesEstudio")
                        .HasForeignKey("IdCarrera")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Carrera");
                });

            modelBuilder.Entity("Entidades.Modelos.E_PlanEstudioMateria", b =>
                {
                    b.HasOne("Entidades.Modelos.E_AreaConocimiento", "AreaConocimiento")
                        .WithMany("PlanEstudioMaterias")
                        .HasForeignKey("IdAreaConocimiento")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entidades.Modelos.E_Etapa", "Etapa")
                        .WithMany("PlanEstudioMaterias")
                        .HasForeignKey("IdEtapa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entidades.Modelos.E_Materia", "Materia")
                        .WithMany("PlanEstudioMaterias")
                        .HasForeignKey("IdMateria")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entidades.Modelos.E_PlanEstudio", "PlanEstudio")
                        .WithMany("PlanEstudioMaterias")
                        .HasForeignKey("IdPlanEstudio")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AreaConocimiento");

                    b.Navigation("Etapa");

                    b.Navigation("Materia");

                    b.Navigation("PlanEstudio");
                });

            modelBuilder.Entity("Entidades.Modelos.E_AreaConocimiento", b =>
                {
                    b.Navigation("PlanEstudioMaterias");
                });

            modelBuilder.Entity("Entidades.Modelos.E_Carrera", b =>
                {
                    b.Navigation("PlanesEstudio");
                });

            modelBuilder.Entity("Entidades.Modelos.E_Etapa", b =>
                {
                    b.Navigation("PlanEstudioMaterias");
                });

            modelBuilder.Entity("Entidades.Modelos.E_Materia", b =>
                {
                    b.Navigation("PlanEstudioMaterias");
                });

            modelBuilder.Entity("Entidades.Modelos.E_PlanEstudio", b =>
                {
                    b.Navigation("PlanEstudioMaterias");
                });
#pragma warning restore 612, 618
        }
    }
}
