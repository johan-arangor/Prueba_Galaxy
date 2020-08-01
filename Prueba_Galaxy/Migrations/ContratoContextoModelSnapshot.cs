﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba_Galaxy.Controllers.Data;

namespace Prueba_Galaxy.Migrations
{
    [DbContext(typeof(ContratoContexto))]
    partial class ContratoContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Prueba_Galaxy.Controllers.Models.Entidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("entidadItems");
                });

            modelBuilder.Entity("Prueba_Galaxy.Models.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FFin")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Finicio")
                        .HasColumnType("datetime");

                    b.Property<string>("IdEntidad")
                        .HasColumnType("text");

                    b.Property<int>("IdTrabajador")
                        .HasColumnType("int");

                    b.Property<int>("NumContrato")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("contratosItems");
                });

            modelBuilder.Entity("Prueba_Galaxy.Models.Trabajador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FNacimiento")
                        .HasColumnType("datetime");

                    b.Property<int>("IdTypeDocument")
                        .HasColumnType("int");

                    b.Property<string>("PApellido")
                        .HasColumnType("text");

                    b.Property<string>("PNombre")
                        .HasColumnType("text");

                    b.Property<string>("SApellido")
                        .HasColumnType("text");

                    b.Property<string>("SNombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("trabajadorItems");
                });
#pragma warning restore 612, 618
        }
    }
}