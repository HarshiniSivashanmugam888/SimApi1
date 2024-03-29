using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimApi1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comp_Details",
                columns: table => new
                {
                    Gu_Comp_Details_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comp_Details_Id = table.Column<int>(type: "int", nullable: false),
                    Comp_Mast_Id = table.Column<int>(type: "int", nullable: false),
                    Comp_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Min_Qty = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comp_Details", x => x.Gu_Comp_Details_Id);
                });

            migrationBuilder.CreateTable(
                name: "Comp_Mast",
                columns: table => new
                {
                    Gu_Comp_Mast_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comp_Mast_Id = table.Column<int>(type: "int", nullable: false),
                    Comp_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Min_Qty = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comp_Mast", x => x.Gu_Comp_Mast_Id);
                });

            migrationBuilder.CreateTable(
                name: "Prod_Details",
                columns: table => new
                {
                    Gu_Prod_Details_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Prod_Details_Id = table.Column<int>(type: "int", nullable: false),
                    Prod_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comp_Details_Id = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prod_Details", x => x.Gu_Prod_Details_Id);
                });

            migrationBuilder.CreateTable(
                name: "Prod_Mast",
                columns: table => new
                {
                    Gu_Prod_Mast_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Prod_Mast_Id = table.Column<int>(type: "int", nullable: false),
                    Prod_Mast_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prod_Mast", x => x.Gu_Prod_Mast_Id);
                });

            migrationBuilder.CreateTable(
                name: "Spares_Out_For_Production",
                columns: table => new
                {
                    Gu_Spares_Out_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Spares_Out_Id = table.Column<int>(type: "int", nullable: false),
                    Staff_Id = table.Column<int>(type: "int", nullable: false),
                    Comp_Details_Id = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<double>(type: "float", nullable: false),
                    Prod_Mast_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spares_Out_For_Production", x => x.Gu_Spares_Out_Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff_Prod_In_Entry",
                columns: table => new
                {
                    Gu_In_Entry_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    In_Entry_Id = table.Column<int>(type: "int", nullable: false),
                    Staff_Id = table.Column<int>(type: "int", nullable: false),
                    Prod_Mast_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prod_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Qty = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff_Prod_In_Entry", x => x.Gu_In_Entry_Id);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Gu_Stock_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Stock_Id = table.Column<int>(type: "int", nullable: false),
                    Comp_Details_Id = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<double>(type: "float", nullable: false),
                    Box_unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Buyer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Gu_Stock_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comp_Details");

            migrationBuilder.DropTable(
                name: "Comp_Mast");

            migrationBuilder.DropTable(
                name: "Prod_Details");

            migrationBuilder.DropTable(
                name: "Prod_Mast");

            migrationBuilder.DropTable(
                name: "Spares_Out_For_Production");

            migrationBuilder.DropTable(
                name: "Staff_Prod_In_Entry");

            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
