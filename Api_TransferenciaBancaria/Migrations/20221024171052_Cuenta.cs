using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_TransferenciaBancaria.Migrations
{
    public partial class Cuenta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Moneda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Saldo = table.Column<string>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaccions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuentaOrigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuentaDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntidadDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaccions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "Transaccions");
        }
    }
}
