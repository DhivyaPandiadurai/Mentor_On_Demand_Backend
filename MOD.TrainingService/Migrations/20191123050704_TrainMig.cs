using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TrainingService.Migrations
{
    public partial class TrainMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payment_mentors_Mid",
                table: "payment");

            migrationBuilder.DropForeignKey(
                name: "FK_payment_users_Uid",
                table: "payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_mentors_Mid",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_technology_SkillId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_users_Uid",
                table: "Training");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_technology",
                table: "technology");

            migrationBuilder.DropPrimaryKey(
                name: "PK_payment",
                table: "payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mentors",
                table: "mentors");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "technology",
                newName: "Technology");

            migrationBuilder.RenameTable(
                name: "payment",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "mentors",
                newName: "Mentor");

            migrationBuilder.RenameIndex(
                name: "IX_payment_Uid",
                table: "Payment",
                newName: "IX_Payment_Uid");

            migrationBuilder.RenameIndex(
                name: "IX_payment_Mid",
                table: "Payment",
                newName: "IX_Payment_Mid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Uid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technology",
                table: "Technology",
                column: "SkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Pid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mentor",
                table: "Mentor",
                column: "Mid");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Mentor_Mid",
                table: "Payment",
                column: "Mid",
                principalTable: "Mentor",
                principalColumn: "Mid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Users_Uid",
                table: "Payment",
                column: "Uid",
                principalTable: "Users",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Mentor_Mid",
                table: "Training",
                column: "Mid",
                principalTable: "Mentor",
                principalColumn: "Mid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Technology_SkillId",
                table: "Training",
                column: "SkillId",
                principalTable: "Technology",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Users_Uid",
                table: "Training",
                column: "Uid",
                principalTable: "Users",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Mentor_Mid",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Users_Uid",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Mentor_Mid",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Technology_SkillId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Users_Uid",
                table: "Training");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Technology",
                table: "Technology");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mentor",
                table: "Mentor");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Technology",
                newName: "technology");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "payment");

            migrationBuilder.RenameTable(
                name: "Mentor",
                newName: "mentors");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_Uid",
                table: "payment",
                newName: "IX_payment_Uid");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_Mid",
                table: "payment",
                newName: "IX_payment_Mid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Uid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_technology",
                table: "technology",
                column: "SkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payment",
                table: "payment",
                column: "Pid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mentors",
                table: "mentors",
                column: "Mid");

            migrationBuilder.AddForeignKey(
                name: "FK_payment_mentors_Mid",
                table: "payment",
                column: "Mid",
                principalTable: "mentors",
                principalColumn: "Mid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payment_users_Uid",
                table: "payment",
                column: "Uid",
                principalTable: "users",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_mentors_Mid",
                table: "Training",
                column: "Mid",
                principalTable: "mentors",
                principalColumn: "Mid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_technology_SkillId",
                table: "Training",
                column: "SkillId",
                principalTable: "technology",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_users_Uid",
                table: "Training",
                column: "Uid",
                principalTable: "users",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
