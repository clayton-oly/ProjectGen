﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectGen;

#nullable disable

namespace ProjectGen.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjectGen.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeProfessor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("NotaPrimeiroSemestre")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("NotaSegundoSemestre")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("NumeroSala")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
