using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MODUserservice.Migrations
{
    public partial class usermig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    Mid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mname = table.Column<string>(nullable: true),
                    Mobile = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    exp = table.Column<int>(nullable: false),
                    Primary_skill = table.Column<string>(nullable: true),
                    timeslot = table.Column<string>(nullable: true),
                    availability = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.Mid);
                });

            migrationBuilder.CreateTable(
                name: "Technology",
                columns: table => new
                {
                    SkillId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(maxLength: 20, nullable: true),
                    TableOfContent = table.Column<string>(nullable: true),
                    Fee = table.Column<double>(nullable: false),
                    Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technology", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Uid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Mobile = table.Column<long>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Pid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<long>(nullable: false),
                    amount = table.Column<double>(nullable: false),
                    Mid = table.Column<long>(nullable: false),
                    Mentor_Amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Pid);
                    table.ForeignKey(
                        name: "FK_Payment_Mentor_Mid",
                        column: x => x.Mid,
                        principalTable: "Mentor",
                        principalColumn: "Mid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Users_Uid",
                        column: x => x.Uid,
                        principalTable: "Users",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    TrainingID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<long>(nullable: false),
                    Mid = table.Column<long>(nullable: false),
                    SkillId = table.Column<long>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    timeslot = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    Progress = table.Column<long>(nullable: false),
                    rating = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.TrainingID);
                    table.ForeignKey(
                        name: "FK_Training_Mentor_Mid",
                        column: x => x.Mid,
                        principalTable: "Mentor",
                        principalColumn: "Mid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Technology_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Technology",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Users_Uid",
                        column: x => x.Uid,
                        principalTable: "Users",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Mentor",
                columns: new[] { "Mid", "Active", "Email", "Mname", "Mobile", "Password", "Primary_skill", "availability", "exp", "timeslot" },
                values: new object[] { 12L, true, "abc@gmail.com", "DB", 9876543245L, "234", "DotNet", true, 0, "2 to 6" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Uid", "Active", "Email", "Mobile", "Name", "Password" },
                values: new object[] { 12L, true, "abc@gmail.com", 9876543212L, "D", "234" });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Mid",
                table: "Payment",
                column: "Mid");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Uid",
                table: "Payment",
                column: "Uid");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Mid",
                table: "Training",
                column: "Mid");

            migrationBuilder.CreateIndex(
                name: "IX_Training_SkillId",
                table: "Training",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Uid",
                table: "Training",
                column: "Uid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "Technology");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
