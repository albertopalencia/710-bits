using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class MiPrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FacturaProducto",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProdutoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturaProducto", x => new { x.FacturaId, x.ProdutoId });
                });

            migrationBuilder.CreateTable(
                name: "FACTURAS",
                columns: table => new
                {
                    IDFACTURA = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMEROFACTURA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FECHA = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    TIPODEPAGO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DOCUMENTOCLIENTE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NOMBRECLIENTE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DESCUENTO = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    SUBTOTAL = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    IVA = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TOTALDESCUENTO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TOTALIMPUESTO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Producto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacturaProducto");

            migrationBuilder.DropTable(
                name: "FACTURAS");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
