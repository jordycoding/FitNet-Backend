using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitNet.Migrations
{
    /// <inheritdoc />
    public partial class ExerciseMuscles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ExerciseId",
                table: "Muscles",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Muscles_ExerciseId",
                table: "Muscles",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Muscles_Exercises_ExerciseId",
                table: "Muscles",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Muscles_Exercises_ExerciseId",
                table: "Muscles");

            migrationBuilder.DropIndex(
                name: "IX_Muscles_ExerciseId",
                table: "Muscles");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "Muscles");
        }
    }
}
