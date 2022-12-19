using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment4.Migrations
{
    public partial class addreg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseRegistrations_Courses_CourseId",
                table: "CourseRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRegistrations_Students_StudentId",
                table: "CourseRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseRegistrations",
                table: "CourseRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_CourseRegistrations_StudentId",
                table: "CourseRegistrations");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CourseRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseRegistrations",
                table: "CourseRegistrations",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseRegistrations",
                table: "CourseRegistrations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CourseRegistrations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseRegistrations",
                table: "CourseRegistrations",
                columns: new[] { "CourseId", "StudentId" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRegistrations_StudentId",
                table: "CourseRegistrations",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRegistrations_Courses_CourseId",
                table: "CourseRegistrations",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRegistrations_Students_StudentId",
                table: "CourseRegistrations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
