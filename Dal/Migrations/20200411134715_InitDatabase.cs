using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeyWordEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyWordEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectorEntities",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEntities",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    AdLogin = table.Column<string>(maxLength: 32, nullable: false),
                    Role = table.Column<int>(nullable: false),
                    Pin = table.Column<string>(maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemEntities",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SectorId = table.Column<uint>(nullable: false),
                    ContainerId = table.Column<uint>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemEntities_ItemEntities_ContainerId",
                        column: x => x.ContainerId,
                        principalTable: "ItemEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemEntities_SectorEntities_SectorId",
                        column: x => x.SectorId,
                        principalTable: "SectorEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemKeywordRelationEntities",
                columns: table => new
                {
                    ItemId = table.Column<uint>(nullable: false),
                    KeyWordId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemKeywordRelationEntities", x => new { x.ItemId, x.KeyWordId });
                    table.ForeignKey(
                        name: "FK_ItemKeywordRelationEntities_ItemEntities_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemKeywordRelationEntities_KeyWordEntities_KeyWordId",
                        column: x => x.KeyWordId,
                        principalTable: "KeyWordEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecordEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<uint>(nullable: false),
                    ItemId = table.Column<uint>(nullable: false),
                    Comment = table.Column<string>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecordEntities_ItemEntities_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecordEntities_UserEntities_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemEntities_ContainerId",
                table: "ItemEntities",
                column: "ContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemEntities_SectorId",
                table: "ItemEntities",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemKeywordRelationEntities_KeyWordId",
                table: "ItemKeywordRelationEntities",
                column: "KeyWordId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordEntities_ItemId",
                table: "RecordEntities",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordEntities_UserId",
                table: "RecordEntities",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemKeywordRelationEntities");

            migrationBuilder.DropTable(
                name: "RecordEntities");

            migrationBuilder.DropTable(
                name: "KeyWordEntities");

            migrationBuilder.DropTable(
                name: "ItemEntities");

            migrationBuilder.DropTable(
                name: "UserEntities");

            migrationBuilder.DropTable(
                name: "SectorEntities");
        }
    }
}
