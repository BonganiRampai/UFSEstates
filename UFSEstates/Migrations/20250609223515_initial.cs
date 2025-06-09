using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UFSEstates.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Complainant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfComplaint = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Complaints",
                columns: new[] { "Id", "Complainant", "DateOfComplaint", "Description", "Service" },
                values: new object[,]
                {
                    { 1, "Ben", new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "There is a leaking pipe near the parking lot of the Library Building.", "Water" },
                    { 2, "Sandy", new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The water supply to the pumps adjacent to Revier Hall is currently not functioning.", "Water" },
                    { 3, "Gert", new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Computer Science Laboratory has been without electrical power since yesterday.", "Electricity" },
                    { 4, "Dean", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The streetlights near the residential building are malfunctioning.", "Electricity" },
                    { 5, "Merry", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The main hall has not been cleaned after the graduation ceremony.", "Cleaning" },
                    { 6, "Meggy", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The main university road next to the cafeteria is blocked by trees.", "Cleaning" },
                    { 7, "Mofokeng", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "All the new sports field showers do not have running water.", "Water" },
                    { 8, "Pule", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The electric sockets in the admin building are not working.", "Electricity" },
                    { 9, "Koena", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The road to the admin building needs repairs because the traffic road signs are no longer visible.", "Roads" },
                    { 10, "Lizzy", new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "There are unauthorized people who are using undercover parking near the old lecture hall building.", "Parking" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");
        }
    }
}
