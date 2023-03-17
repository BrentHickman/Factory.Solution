using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class CorrectedJoinTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngMach_Engineers_EngineerId",
                table: "EngMach");

            migrationBuilder.DropForeignKey(
                name: "FK_EngMach_Machines_MachineId",
                table: "EngMach");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EngMach",
                table: "EngMach");

            migrationBuilder.RenameTable(
                name: "EngMach",
                newName: "EngMachs");

            migrationBuilder.RenameIndex(
                name: "IX_EngMach_MachineId",
                table: "EngMachs",
                newName: "IX_EngMachs_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_EngMach_EngineerId",
                table: "EngMachs",
                newName: "IX_EngMachs_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EngMachs",
                table: "EngMachs",
                column: "EngMachId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngMachs_Engineers_EngineerId",
                table: "EngMachs",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EngMachs_Machines_MachineId",
                table: "EngMachs",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngMachs_Engineers_EngineerId",
                table: "EngMachs");

            migrationBuilder.DropForeignKey(
                name: "FK_EngMachs_Machines_MachineId",
                table: "EngMachs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EngMachs",
                table: "EngMachs");

            migrationBuilder.RenameTable(
                name: "EngMachs",
                newName: "EngMach");

            migrationBuilder.RenameIndex(
                name: "IX_EngMachs_MachineId",
                table: "EngMach",
                newName: "IX_EngMach_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_EngMachs_EngineerId",
                table: "EngMach",
                newName: "IX_EngMach_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EngMach",
                table: "EngMach",
                column: "EngMachId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngMach_Engineers_EngineerId",
                table: "EngMach",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EngMach_Machines_MachineId",
                table: "EngMach",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
