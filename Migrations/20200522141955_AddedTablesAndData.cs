using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class AddedTablesAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    IdDoctor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Doctor_PK", x => x.IdDoctor);
                });

            migrationBuilder.CreateTable(
                name: "Medicament",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Medicament_PK", x => x.IdMedicament);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    IdPatient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Patient_PK", x => x.IdPatient);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    IdPrescription = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    IdPatient = table.Column<int>(nullable: false),
                    IdDoctor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Prescription_PK", x => x.IdPrescription);
                    table.ForeignKey(
                        name: "Doctor_Prescription",
                        column: x => x.IdDoctor,
                        principalTable: "Doctor",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Patient_Prescription",
                        column: x => x.IdPatient,
                        principalTable: "Patient",
                        principalColumn: "IdPatient",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescription_Medicament",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(nullable: false),
                    IdPrescription = table.Column<int>(nullable: false),
                    Dose = table.Column<int>(nullable: false),
                    Details = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription_Medicament", x => new { x.IdMedicament, x.IdPrescription });
                    table.ForeignKey(
                        name: "Medicament_Prescription_Medicament",
                        column: x => x.IdMedicament,
                        principalTable: "Medicament",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Prescription_Prescription_Medicament",
                        column: x => x.IdPrescription,
                        principalTable: "Prescription",
                        principalColumn: "IdPrescription",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "gakrzy@dmail.com", "Krzysztof", "Gagagaga" },
                    { 2, "korzemil@dmail.com", "Milena", "Korzenna" },
                    { 3, "walucjan@dmail.com", "Lucjan", "Walenrod" },
                    { 4, "birena@dmail.com", "Irena", "Bogobojna" },
                    { 5, "kwama@dmail.com", "Marta", "Kwiatkowska" }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Usmierza swad", "KorzenioLUX", "Suplement diety" },
                    { 2, "Dziala przeciwzapalnie", "PromIBum", "Lek przeciwzapalny" },
                    { 3, "Dziala przeciwbolowo", "Papap", "Lek przeciwbolowy" },
                    { 4, "Uzupelnia witamine c", "Cetamin", "Suplement diety" },
                    { 5, "Uzupelnia witamine b", "TyraniX", "Suplement diety" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 22, 16, 19, 54, 920, DateTimeKind.Local).AddTicks(4594), "Jan", "Kowalski" },
                    { 2, new DateTime(2020, 5, 22, 16, 19, 54, 923, DateTimeKind.Local).AddTicks(5785), "Waclaw", "Dzban" },
                    { 3, new DateTime(2020, 5, 22, 16, 19, 54, 923, DateTimeKind.Local).AddTicks(5848), "Baltazar", "Gabka" },
                    { 4, new DateTime(2020, 5, 22, 16, 19, 54, 923, DateTimeKind.Local).AddTicks(5855), "Krystyna", "Mazurska" },
                    { 5, new DateTime(2020, 5, 22, 16, 19, 54, 923, DateTimeKind.Local).AddTicks(5859), "Joanna", "Kasztan" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 22, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(1585), new DateTime(2020, 5, 29, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(2161), 1, 1 },
                    { 4, new DateTime(2020, 5, 22, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3625), new DateTime(2020, 5, 29, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3629), 5, 1 },
                    { 2, new DateTime(2020, 5, 22, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3550), new DateTime(2020, 5, 29, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3591), 4, 2 },
                    { 3, new DateTime(2020, 5, 22, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3618), new DateTime(2020, 5, 29, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3621), 3, 3 },
                    { 5, new DateTime(2020, 5, 22, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3633), new DateTime(2020, 5, 29, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3636), 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "Stosowac dwa razy dziennie", 0 },
                    { 3, 4, "Stosowac trzy razy dziennie, az do zakonczenia paczki", 2 },
                    { 4, 2, "Stosowac trzy razy dziennie", 0 },
                    { 5, 2, "Stosowac trzy razy dziennie", 0 },
                    { 2, 3, "Stosowac dwa razy dziennie, przez tydzien", 2 },
                    { 1, 5, "Stosowac dwa razy dziennie", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdDoctor",
                table: "Prescription",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdPatient",
                table: "Prescription",
                column: "IdPatient");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Medicament_IdPrescription",
                table: "Prescription_Medicament",
                column: "IdPrescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescription_Medicament");

            migrationBuilder.DropTable(
                name: "Medicament");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
