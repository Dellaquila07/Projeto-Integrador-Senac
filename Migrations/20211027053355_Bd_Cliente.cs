using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_Integrador_Senac.Migrations
{
    public partial class Bd_Cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Cliente_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente_Nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cliente_Sobrenome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Cliente_Dt_Nasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cliente_Celular = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Cliente_Email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Cliente_ID);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Produto_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Produto_Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Produto_Preco_Custo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Produto_Preco_Venda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Produto_Quantidade_Estoque = table.Column<int>(type: "int", nullable: false),
                    Produto_Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Produto_ID);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Venda_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente_ID = table.Column<int>(type: "int", nullable: false),
                    Cliente_ID1 = table.Column<int>(type: "int", nullable: true),
                    Produto_ID = table.Column<int>(type: "int", nullable: false),
                    Produto_ID1 = table.Column<int>(type: "int", nullable: true),
                    Venda_Quantidade = table.Column<int>(type: "int", nullable: false),
                    Venda_Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Venda_Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Venda_ID);
                    table.ForeignKey(
                        name: "FK_Venda_Cliente_Cliente_ID1",
                        column: x => x.Cliente_ID1,
                        principalTable: "Cliente",
                        principalColumn: "Cliente_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Venda_Produto_Produto_ID1",
                        column: x => x.Produto_ID1,
                        principalTable: "Produto",
                        principalColumn: "Produto_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venda_Cliente_ID1",
                table: "Venda",
                column: "Cliente_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_Produto_ID1",
                table: "Venda",
                column: "Produto_ID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
