using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ActivitiesEvent.Migrations
{
    public partial class FifthMirgration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TheUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PassWord = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    ConfirmPW = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "EventForms",
                columns: table => new
                {
                    EventFormId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    EventDuration = table.Column<int>(nullable: false),
                    Duration = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventForms", x => x.EventFormId);
                    table.ForeignKey(
                        name: "FK_EventForms_TheUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "TheUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssociatesGuest",
                columns: table => new
                {
                    AssociatesId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    EventFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociatesGuest", x => x.AssociatesId);
                    table.ForeignKey(
                        name: "FK_AssociatesGuest_EventForms_EventFormId",
                        column: x => x.EventFormId,
                        principalTable: "EventForms",
                        principalColumn: "EventFormId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssociatesGuest_TheUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "TheUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssociatesGuest_EventFormId",
                table: "AssociatesGuest",
                column: "EventFormId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociatesGuest_UserId",
                table: "AssociatesGuest",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventForms_UserId",
                table: "EventForms",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssociatesGuest");

            migrationBuilder.DropTable(
                name: "EventForms");

            migrationBuilder.DropTable(
                name: "TheUsers");
        }
    }
}
