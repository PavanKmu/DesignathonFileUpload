using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Designathon.Migrations
{
    /// <inheritdoc />
    public partial class CandidateDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CandidateDetails",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternshipDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoursesCompleted = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkedInProfileLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GithubProfileLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgrammingLanguagesKnown = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateDetails");
        }
    }
}
