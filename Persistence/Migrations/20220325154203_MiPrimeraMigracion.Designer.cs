﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using Persistence.Contexts;

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220325154203_MiPrimeraMigracion")]
    partial class MiPrimeraMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Factura", b =>
                {
                    b.Property<int>("Descuento")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("SUBTOTAL");

                    b.Property<string>("DocumentoCliente")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DOCUMENTOCLIENTE");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("FECHA");

                    b.Property<int>("IdFactura")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("IDFACTURA");

                    b.Property<int>("Iva")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("IVA");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NOMBRECLIENTE");

                    b.Property<string>("NumeroFactura")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NUMEROFACTURA");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("DECIMAL(18, 2)")
                        .HasColumnName("DESCUENTO");

                    b.Property<string>("TipoDePago")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("TIPODEPAGO");

                    b.Property<decimal>("Total")
                        .HasColumnType("DECIMAL(18, 2)")
                        .HasColumnName("TOTAL");

                    b.Property<int>("TotalDescuento")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("TOTALDESCUENTO");

                    b.Property<int>("TotalImpuesto")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("TOTALIMPUESTO");

                    b.ToTable("FACTURAS");
                });

            modelBuilder.Entity("Domain.Entities.FacturaProducto", b =>
                {
                    b.Property<int>("FacturaId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("FacturaId", "ProdutoId");

                    b.ToTable("FacturaProducto");
                });

            modelBuilder.Entity("Domain.Entities.Productos", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Productos");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
