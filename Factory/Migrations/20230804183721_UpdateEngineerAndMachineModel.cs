using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sillystrings.Solutions.Migrations
{
    public partial class UpdateEngineerAndMachineModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EngineerId",
                table: "Machines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Engineers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EngineerId",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Engineers");
        }
    }
}
