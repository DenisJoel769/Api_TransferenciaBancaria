﻿// <auto-generated />
using Api_TransferenciaBancaria.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api_TransferenciaBancaria.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Api_TransferenciaBancaria.Models.Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Moneda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Saldo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cuenta");
                });

            modelBuilder.Entity("Api_TransferenciaBancaria.Models.Transaccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CuentaDestino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CuentaOrigen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntidadDestino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Transaccions");
                });
#pragma warning restore 612, 618
        }
    }
}
