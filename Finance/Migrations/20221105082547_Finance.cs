using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finance.Migrations
{
    public partial class Finance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassModels",
                columns: table => new
                {
                    Id_Class = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Class = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    School_Year = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Majors = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Credit = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Type_Education = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Tariff_Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Tariff_Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassModels", x => x.Id_Class);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "TariffModels",
                columns: table => new
                {
                    Id_Tariff = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeBill = table.Column<int>(type: "int", nullable: false),
                    Autumn = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    Money = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Total_Payment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ModifyBy = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffModels", x => x.Id_Tariff);
                });

            migrationBuilder.CreateTable(
                name: "TimekeepingModels",
                columns: table => new
                {
                    ID_Timekeeping = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_User = table.Column<int>(type: "int", nullable: false),
                    ID_Teacher = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimekeepingModels", x => x.ID_Timekeeping);
                });

            migrationBuilder.CreateTable(
                name: "StudentModels",
                columns: table => new
                {
                    Id_Student = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Profile = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DienThoai = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Card = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Type_Education = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Id_Class = table.Column<int>(type: "int", nullable: false),
                    ClassModelId_Class = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModels", x => x.Id_Student);
                    table.ForeignKey(
                        name: "FK_StudentModels_ClassModels_ClassModelId_Class",
                        column: x => x.ClassModelId_Class,
                        principalTable: "ClassModels",
                        principalColumn: "Id_Class",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExemptionsModels",
                columns: table => new
                {
                    Id_Exemptions = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Exemptions = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Money_Exemptions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Total_Payment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Percent = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ModifyBy = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    tariffModelsId_Tariff = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExemptionsModels", x => x.Id_Exemptions);
                    table.ForeignKey(
                        name: "FK_ExemptionsModels_TariffModels_tariffModelsId_Tariff",
                        column: x => x.tariffModelsId_Tariff,
                        principalTable: "TariffModels",
                        principalColumn: "Id_Tariff",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeacherModels",
                columns: table => new
                {
                    Teacher_ID = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    timekeepingModelsID_Timekeeping = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherModels", x => x.Teacher_ID);
                    table.ForeignKey(
                        name: "FK_TeacherModels_ClassModels_Teacher_ID",
                        column: x => x.Teacher_ID,
                        principalTable: "ClassModels",
                        principalColumn: "Id_Class",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherModels_TimekeepingModels_timekeepingModelsID_Timekeeping",
                        column: x => x.timekeepingModelsID_Timekeeping,
                        principalTable: "TimekeepingModels",
                        principalColumn: "ID_Timekeeping",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    rolesRoleId = table.Column<int>(type: "int", nullable: true),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    classsId_Class = table.Column<int>(type: "int", nullable: true),
                    tariffModelsId_Tariff = table.Column<int>(type: "int", nullable: true),
                    Id_Tariff = table.Column<int>(type: "int", nullable: false),
                    timekeepingModelsID_Timekeeping = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_UserModel_ClassModels_classsId_Class",
                        column: x => x.classsId_Class,
                        principalTable: "ClassModels",
                        principalColumn: "Id_Class",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserModel_Roles_rolesRoleId",
                        column: x => x.rolesRoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserModel_TariffModels_tariffModelsId_Tariff",
                        column: x => x.tariffModelsId_Tariff,
                        principalTable: "TariffModels",
                        principalColumn: "Id_Tariff",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserModel_TimekeepingModels_timekeepingModelsID_Timekeeping",
                        column: x => x.timekeepingModelsID_Timekeeping,
                        principalTable: "TimekeepingModels",
                        principalColumn: "ID_Timekeeping",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExemptionsModels_tariffModelsId_Tariff",
                table: "ExemptionsModels",
                column: "tariffModelsId_Tariff");

            migrationBuilder.CreateIndex(
                name: "IX_StudentModels_ClassModelId_Class",
                table: "StudentModels",
                column: "ClassModelId_Class");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherModels_timekeepingModelsID_Timekeeping",
                table: "TeacherModels",
                column: "timekeepingModelsID_Timekeeping");

            migrationBuilder.CreateIndex(
                name: "IX_UserModel_classsId_Class",
                table: "UserModel",
                column: "classsId_Class");

            migrationBuilder.CreateIndex(
                name: "IX_UserModel_rolesRoleId",
                table: "UserModel",
                column: "rolesRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserModel_tariffModelsId_Tariff",
                table: "UserModel",
                column: "tariffModelsId_Tariff");

            migrationBuilder.CreateIndex(
                name: "IX_UserModel_timekeepingModelsID_Timekeeping",
                table: "UserModel",
                column: "timekeepingModelsID_Timekeeping");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExemptionsModels");

            migrationBuilder.DropTable(
                name: "StudentModels");

            migrationBuilder.DropTable(
                name: "TeacherModels");

            migrationBuilder.DropTable(
                name: "UserModel");

            migrationBuilder.DropTable(
                name: "ClassModels");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TariffModels");

            migrationBuilder.DropTable(
                name: "TimekeepingModels");
        }
    }
}
