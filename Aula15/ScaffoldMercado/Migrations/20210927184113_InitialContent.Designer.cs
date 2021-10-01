﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScaffoldMercado.Data;

namespace ScaffoldMercado.Migrations
{
    [DbContext(typeof(ScaffoldMercadoContext))]
    [Migration("20210927184113_InitialContent")]
    partial class InitialContent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScaffoldMercado.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PRODUTO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("NM_PRODUTO");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime2")
                        .HasColumnName("DT_VALIDADE_PRODUTO");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("VLR_PRODUTO");

                    b.HasKey("Id");

                    b.ToTable("TB_PRODUTO");
                });

            modelBuilder.Entity("ScaffoldMercado.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("NM_USUARIO");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIO");
                });

            modelBuilder.Entity("ScaffoldMercado.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_VENDA")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO_VENDA");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("VLR_TOTAL_VENDA");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("TB_VENDA");
                });

            modelBuilder.Entity("ScaffoldMercado.Models.VendaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_VENDA_ITEM")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnName("ID_PRODUTO");

                    b.Property<int>("IdVenda")
                        .HasColumnType("int")
                        .HasColumnName("ID_VENDA");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("QTD_VENDA");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto");

                    b.HasIndex("IdVenda");

                    b.ToTable("TB_VENDA_ITEM");
                });

            modelBuilder.Entity("ScaffoldMercado.Models.Venda", b =>
                {
                    b.HasOne("ScaffoldMercado.Models.Usuario", "Usuario")
                        .WithMany("Vendas")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ScaffoldMercado.Models.VendaItem", b =>
                {
                    b.HasOne("ScaffoldMercado.Models.Produto", "Produto")
                        .WithMany("VendasDoProduto")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ScaffoldMercado.Models.Venda", "Venda")
                        .WithMany("Itens")
                        .HasForeignKey("IdVenda")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("ScaffoldMercado.Models.Produto", b =>
                {
                    b.Navigation("VendasDoProduto");
                });

            modelBuilder.Entity("ScaffoldMercado.Models.Usuario", b =>
                {
                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("ScaffoldMercado.Models.Venda", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}