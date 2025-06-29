using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity.Migrations
{
    /// <inheritdoc />
    public partial class MigrationPainInTheAss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssignments_Courses_CourseID",
                table: "CourseAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Student_StudentGradesID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Courses_CourseID",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Departments_StudentGradesID",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Mood",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "VocationCredential",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "WorkYears",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "StudentGradesID",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Student",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Departments",
                newName: "StartDate");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_DepartmentID",
                table: "Course",
                newName: "IX_Course_DepartmentID");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Genderr",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentDescription",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Departments_DepartmentID",
                table: "Course",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAssignments_Course_CourseID",
                table: "CourseAssignments",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_CourseID",
                table: "Enrollment",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Departments_DepartmentID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssignments_Course_CourseID",
                table: "CourseAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_CourseID",
                table: "Enrollment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Genderr",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DepartmentDescription",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Student",
                newName: "FirstMidName");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Departments",
                newName: "StartTime");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DepartmentID",
                table: "Courses",
                newName: "IX_Courses_DepartmentID");

            migrationBuilder.AddColumn<int>(
                name: "Mood",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VocationCredential",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkYears",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentGradesID",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_StudentGradesID",
                table: "Departments",
                column: "StudentGradesID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAssignments_Courses_CourseID",
                table: "CourseAssignments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Student_StudentGradesID",
                table: "Departments",
                column: "StudentGradesID",
                principalTable: "Student",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Courses_CourseID",
                table: "Enrollment",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
