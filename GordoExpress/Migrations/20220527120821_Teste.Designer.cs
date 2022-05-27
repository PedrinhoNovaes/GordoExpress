﻿// <auto-generated />
using GordoExpress.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GordoExpress.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220527120821_Teste")]
    partial class Teste
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GordoExpress.Models.Bebida", b =>
                {
                    b.Property<int>("BebidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BebidaId"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<bool>("EmEstoque")
                        .HasColumnType("bit");

                    b.Property<string>("ImagemThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBebidaPreferido")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BebidaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Bebidas");
                });

            modelBuilder.Entity("GordoExpress.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"), 1L, 1);

                    b.Property<string>("CategoriaNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("GordoExpress.Models.Bebida", b =>
                {
                    b.HasOne("GordoExpress.Models.Categoria", "Categoria")
                        .WithMany("Bebidas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("GordoExpress.Models.Categoria", b =>
                {
                    b.Navigation("Bebidas");
                });
#pragma warning restore 612, 618
        }
    }
}