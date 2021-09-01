﻿// <auto-generated />
using System;
using CausasJudiciales.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CausasJudiciales.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210901001130_UpdateDatabase")]
    partial class UpdateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CausasJudiciales.Models.Asesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AceptaCargo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Actuacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Caratula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumeroExpediente")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regulacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Representado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Asesor");
                });

            modelBuilder.Entity("CausasJudiciales.Models.Beneficio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caratula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InicioDemanda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumeroExpediente")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regulacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Representado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeDicteSentencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Sentencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Testigos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Traslado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Beneficio");
                });
#pragma warning restore 612, 618
        }
    }
}
