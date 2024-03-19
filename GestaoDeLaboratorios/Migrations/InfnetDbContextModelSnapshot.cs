﻿// <auto-generated />
using GestaoDeLaboratorios.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoDeLaboratorios.Migrations
{
    [DbContext(typeof(InfnetDbContext))]
    partial class InfnetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("GestaoDeLaboratorios.Models.Computador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataCompra")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Hd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Memoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroPatrimonio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PlacaMae")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Processador")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Computador");
                });
#pragma warning restore 612, 618
        }
    }
}
