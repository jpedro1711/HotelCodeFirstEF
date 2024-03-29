﻿// <auto-generated />
using System;
using HotelEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelEF.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20240126164839_ManyToManyItemsConsumidos")]
    partial class ManyToManyItemsConsumidos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelEF.Cargo", b =>
                {
                    b.Property<int>("CargoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoID"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoID");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("HotelEF.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnderecoID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteID");

                    b.HasIndex("EnderecoID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("HotelEF.Conta", b =>
                {
                    b.Property<int>("ItemConsumivelID")
                        .HasColumnType("int");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("ItemConsumivelID", "ReservaID");

                    b.HasIndex("ItemConsumivelID")
                        .IsUnique();

                    b.HasIndex("ReservaID")
                        .IsUnique();

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("HotelEF.Endereco", b =>
                {
                    b.Property<int>("EnderecoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnderecoID"));

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnderecoID");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("HotelEF.Filial", b =>
                {
                    b.Property<int>("FilialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilialID"));

                    b.Property<int>("EnderecoID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QtdEstrelas")
                        .HasColumnType("int");

                    b.Property<int?>("QuartosCasal")
                        .HasColumnType("int");

                    b.Property<int?>("QuartosFamilia")
                        .HasColumnType("int");

                    b.Property<int?>("QuartosPresidencial")
                        .HasColumnType("int");

                    b.Property<int?>("QuartosSolteiro")
                        .HasColumnType("int");

                    b.HasKey("FilialID");

                    b.HasIndex("EnderecoID");

                    b.ToTable("Filial");
                });

            modelBuilder.Entity("HotelEF.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FuncionarioID"));

                    b.Property<int>("CargoID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuncionarioID");

                    b.HasIndex("CargoID");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("HotelEF.ItemConsumivel", b =>
                {
                    b.Property<int>("ItemConsumivelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemConsumivelID"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Preco")
                        .HasColumnType("float");

                    b.HasKey("ItemConsumivelID");

                    b.ToTable("ItemConsumivel");
                });

            modelBuilder.Entity("HotelEF.ItemConsumo", b =>
                {
                    b.Property<int>("ItemConsumoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemConsumoID"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Preco")
                        .HasColumnType("float");

                    b.Property<bool?>("ServicoQuarto")
                        .HasColumnType("bit");

                    b.HasKey("ItemConsumoID");

                    b.ToTable("ItemConsumo");
                });

            modelBuilder.Entity("HotelEF.Pagamento", b =>
                {
                    b.Property<int>("PagamentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PagamentoID"));

                    b.Property<string>("Metodo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Pago")
                        .HasColumnType("bit");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.HasKey("PagamentoID");

                    b.HasIndex("ReservaID");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("HotelEF.Quarto", b =>
                {
                    b.Property<int>("QuartoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuartoID"));

                    b.Property<bool?>("Adaptado")
                        .HasColumnType("bit");

                    b.Property<int?>("Capacidade")
                        .HasColumnType("int");

                    b.Property<bool?>("ColchaoAdicional")
                        .HasColumnType("bit");

                    b.Property<int>("FilialID")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("ValorDiaria")
                        .HasColumnType("float");

                    b.HasKey("QuartoID");

                    b.HasIndex("FilialID");

                    b.ToTable("Quarto");
                });

            modelBuilder.Entity("HotelEF.Reserva", b =>
                {
                    b.Property<int>("ReservaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservaID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataCheckin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCheckout")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuncionarioID")
                        .HasColumnType("int");

                    b.HasKey("ReservaID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("FuncionarioID");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("HotelEF.Servico", b =>
                {
                    b.Property<int>("ServicoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicoID"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.Property<double?>("Valor")
                        .HasColumnType("float");

                    b.HasKey("ServicoID");

                    b.HasIndex("ReservaID");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("HotelEF.Telefone", b =>
                {
                    b.Property<int>("TelefoneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TelefoneID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("NumeroTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TelefoneID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("HotelEF.Cliente", b =>
                {
                    b.HasOne("HotelEF.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("HotelEF.Conta", b =>
                {
                    b.HasOne("HotelEF.ItemConsumivel", "ItemConsumivel")
                        .WithOne()
                        .HasForeignKey("HotelEF.Conta", "ItemConsumivelID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HotelEF.Reserva", "Reserva")
                        .WithOne()
                        .HasForeignKey("HotelEF.Conta", "ReservaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ItemConsumivel");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("HotelEF.Filial", b =>
                {
                    b.HasOne("HotelEF.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("endereco");
                });

            modelBuilder.Entity("HotelEF.Funcionario", b =>
                {
                    b.HasOne("HotelEF.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("HotelEF.Pagamento", b =>
                {
                    b.HasOne("HotelEF.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("HotelEF.Quarto", b =>
                {
                    b.HasOne("HotelEF.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("FilialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("HotelEF.Reserva", b =>
                {
                    b.HasOne("HotelEF.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelEF.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("HotelEF.Servico", b =>
                {
                    b.HasOne("HotelEF.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("HotelEF.Telefone", b =>
                {
                    b.HasOne("HotelEF.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
